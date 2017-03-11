using MySql.Data.MySqlClient;
using System;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace TextBasedProgramming.Helpers
{
    class Function
    {
        private MySqlConnection conn = new MySqlConnection();

        public void ConnectDatabase()
        {

            conn.ConnectionString = "Server=localhost;Database=testbasedprogramming;Port=3306;User ID=root;Password=";
            if (conn.State == System.Data.ConnectionState.Closed || conn.State == System.Data.ConnectionState.Broken)
            {
                try
                {
                    conn.Open();
                    //MessageBox.Show("Connected successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Failed. Please try again" + ex.Message, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                //finally
                //{
                //    conn.Close();
                //    MessageBox.Show("Connection closed");
                //}
            }
        }

        public void CloseConnection()
        {
            try
            {
                conn.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public string getSingleData(string variable1, string table, string variable2)
        {
            string variable = "";
            try
            {
                string sql = "SELECT " + variable1 + " FROM " + table + " WHERE " + variable1 + " = ?Parameter";
                using (var connection = new MySqlConnection("Server=localhost;Database=testbasedprogramming;Port=3306;User ID=root;Password="))
                using (var command = new MySqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("?Parameter", variable2);
                    connection.Open();
                    variable = (string)command.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message");
            }

            return variable;
        }

        public string EncodeSHA1(string pass)
        {

            SHA1CryptoServiceProvider sha1 = new SHA1CryptoServiceProvider();

            byte[] bs = System.Text.Encoding.UTF8.GetBytes(pass);

            bs = sha1.ComputeHash(bs);

            System.Text.StringBuilder s = new System.Text.StringBuilder();

            foreach (byte b in bs)
            {

                s.Append(b.ToString("x1").ToLower());

            }
            pass = s.ToString();
            return pass;
        }

    }
}
