using System;

// Process
using System.Diagnostics;

// Compile
using Microsoft.CSharp;
using Microsoft.VisualC;
using System.CodeDom.Compiler;

// File
using System.IO;

// Regex
using System.Text.RegularExpressions;

namespace TextBasedProgramming.Classes
{
    public class CompilerAndRunner
    {
        // Biên dịch Source code sang file exe
        public static CompilerResults CompileFromSource(string sourceCode, string outputFile, string language)
        {
            CSharpCodeProvider codeCSharpProvider = new CSharpCodeProvider();
            CppCodeProvider codeCPPProvider = new CppCodeProvider();

            CompilerParameters paramters = new CompilerParameters();
            paramters.OutputAssembly = outputFile;
            paramters.GenerateExecutable = true;


            CompilerResults results = null;

            if (language == "C#")
                results = codeCSharpProvider.CompileAssemblyFromSource(paramters, sourceCode);
            else if (language == "C++")
                results = codeCPPProvider.CompileAssemblyFromSource(paramters, sourceCode);

            return results;
        }



        // Biên dịch file chứa Source code sang file exe
        public static CompilerResults CompileFromFile(string fileName, string outputFile, string language)
        {
            CSharpCodeProvider codeCSharpProvider = new CSharpCodeProvider();
            CppCodeProvider codeCPPProvider = new CppCodeProvider();

            CompilerParameters paramters = new CompilerParameters();
            paramters.OutputAssembly = outputFile;
            paramters.GenerateExecutable = true;


            CompilerResults results = null;
            if (language == "C#")
                results = codeCSharpProvider.CompileAssemblyFromFile(paramters, fileName);
            else if (language == "C++")
                results = codeCPPProvider.CompileAssemblyFromFile(paramters, fileName);

            return results;
        }



        // Chạy file exe với input, sinh ra output
        public static bool Run(string executableFile, string[] inputs, out string[] outputs, int timeToRun)
        {
            // Tạo thông tin cho Process
            ProcessStartInfo info = new ProcessStartInfo
            {
                FileName = executableFile,
                UseShellExecute = false,
                RedirectStandardInput = true,
                RedirectStandardOutput = true
            };
            //info.WindowStyle = ProcessWindowStyle.Hidden;
            //info.CreateNoWindow = true;



            // Tạo và Chạy process
            Process process = new Process();
            process.StartInfo = info;

            process.Start();


            // Nhập dữ liệu Input vào process 
            StreamWriter sw = process.StandardInput;
            foreach (string input in inputs)
            {
                try
                {

                    sw.WriteLine(input);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }


            // Chờ chạy xong
            bool exit = false;
            if (timeToRun < int.MaxValue)
                exit = process.WaitForExit(timeToRun * 1000); //process.WaitForExit(milliseconds);
            else
                exit = process.WaitForExit(timeToRun);  // timeToRun == int.MaxValue
            if (!exit)
            {
                process.Kill();
                outputs = null;
                return exit;
            }



            // Nhận Output
            StreamReader sr = process.StandardOutput;
            string results = sr.ReadToEnd();
            results = Regex.Replace(results, "\r\n", "\n");
            outputs = results.Split(new[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);

            return exit;
        }
    }
}
