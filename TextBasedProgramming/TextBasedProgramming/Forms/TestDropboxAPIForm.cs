using Nemiro.OAuth;
using Nemiro.OAuth.LoginForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TextBasedProgramming.Properties;

namespace TextBasedProgramming.Forms
{
    public partial class TestDropboxAPIForm : Form
    {
        private string CurrentPath = "/";

        public TestDropboxAPIForm()
        {
            InitializeComponent();
        }

        private void TestDropboxAPIForm_Load(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Settings.Default.AccessToken))
            {
                GetAccessToken();
            }
            else
            {
                GetFiles();
            }
        }

        private void TestDropboxAPIForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            StartForm startForm = new StartForm();
            startForm.Show();
        }

        //Functions
        private void GetFiles()
        {
            loadingProgressBar.Visible = true;
            OAuthUtility.GetAsync
            (
                "https://api.dropbox.com/1/metadata/auto",
                new HttpParameterCollection
                {
                    { "path", CurrentPath },
                    { "access_token", Settings.Default.AccessToken }
                },
                callback: GetFiles_Result
            );
        }

        private void GetFiles_Result(RequestResult result)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<RequestResult>(GetFiles_Result), result);
                return;
            }

            if (result.StatusCode == 200)
            {
                listView2.Items.Clear();
                imageList1.Images.Clear();
                int imageIndex = 0;
                ResourceManager rm = Resources.ResourceManager;
                foreach (UniValue file in result["contents"])
                {
                    //MessageBox.Show(file.ToString());
                    Bitmap myImage = (Bitmap)rm.GetObject(file["icon"].ToString() + "48");
                    imageList1.Images.Add(myImage);
                    ListViewItem item = new ListViewItem(file["path"].ToString());
                    item.Tag = file;
                    item.ImageIndex = imageIndex;
                    listView2.Items.Add(item);
                    imageIndex++;
                }

                if (CurrentPath != "/")
                {
                    ListViewItem item = new ListViewItem("Back to previous");
                    item.Tag = UniValue.ParseJson("{path: '..'}");
                    listView2.Items.Insert(0, item);
                }
            }
            else
            {
                MessageBox.Show("error");
            }
            loadingProgressBar.Visible = false;
        }

        private void GetAccessToken()
        {
            var login = new DropboxLogin("hfpevik0rsrulaj", "ck1ye2fy2rark82");
            login.Owner = this;
            login.ShowDialog();
            if (login.IsSuccessfully)
            {
                Settings.Default.AccessToken = login.AccessToken.Value;
                Settings.Default.Save();
            }
            else
            {
                MessageBox.Show("error");
            }
        }

        private void CreateFolder_Result(RequestResult result)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<RequestResult>(CreateFolder_Result), result);
                return;
            }

            if (result.StatusCode == 200)
            {
                GetFiles();
                textBox1.Clear();
            }
            else
            {
                if (result["error"].HasValue)
                {
                    MessageBox.Show(result["error"].ToString());
                }
                else
                {
                    MessageBox.Show("error");
                }
            }

        }

        private void Web_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void btn_create_folder_Click(object sender, EventArgs e)
        {
            OAuthUtility.PostAsync
            (
                "https://api.dropbox.com/1/fileops/create_folder",
                new HttpParameterCollection
                {
                    { "access_token", Settings.Default.AccessToken },
                    { "root", "auto"},
                    { "path", Path.Combine(CurrentPath, textBox1.Text.Trim()).Replace("\\", "/")}
                },
                callback: CreateFolder_Result
            );
        }

        private void btn_upload_file_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.OK) { return; }

            OAuthUtility.PutAsync
            (
                "https://content.dropboxapi.com/1/files_put/auto/",
                new HttpParameterCollection
                {
                    { "access_token", Properties.Settings.Default.AccessToken },
                    { "path", Path.Combine(CurrentPath, Path.GetFileName(openFileDialog1.FileName)).Replace("\\", "/") },
                    { "overwrite", "true"},
                    { "autorename", "true" },
                    { openFileDialog1.OpenFile() }
                },
                callback: Upload_Result
            );
        }

        private void Upload_Result(RequestResult result)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<RequestResult>(Upload_Result), result);
                return;
            }

            if (result.StatusCode == 200)
            {
                GetFiles();
                textBox1.Clear();
            }
            else
            {
                if (result["error"].HasValue)
                {
                    MessageBox.Show(result["error"].ToString());
                }
                else
                {
                    MessageBox.Show("error");
                }
            }
        }

        private void listView2_DoubleClick(object sender, EventArgs e)
        {
            if (listView2.SelectedItems == null) { return; }
            UniValue file = (UniValue)listView2.SelectedItems[0].Tag;
            if (file["path"] == "..")
            {
                if (CurrentPath != "/")
                {
                    CurrentPath = Path.GetDirectoryName(CurrentPath).Replace("\\", "/");
                }
            }
            else
            {
                if (file["is_dir"] == 1)
                {
                    CurrentPath = file["path"].ToString();
                }
                else
                {
                    saveFileDialog1.FileName = Path.GetFileName(file["path"].ToString());
                    if (saveFileDialog1.ShowDialog() != DialogResult.OK) { return; }

                    var web = new WebClient();
                    web.DownloadProgressChanged += Web_DownloadProgressChanged;
                    web.DownloadFileAsync(new Uri(String.Format("https://content.dropboxapi.com/1/files/auto/{0}?access_token={1}", file["path"], Properties.Settings.Default.AccessToken)), saveFileDialog1.FileName);

                }
            }
            GetFiles();
        }
    }
}
