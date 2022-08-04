using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CS_Assignment
{
    public class FileStreamOperation : IDisposable
    {
        FileStream fs;
        string filePath = string.Empty;
        public FileStreamOperation()
        {
            filePath = @"C:\Assignment\MyFile.txt";
        }

        public void CreateFile()
        {
            try
            {
                fs = new FileStream(filePath, FileMode.CreateNew);
                fs.Close();
                // fs.Dispose();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void WriteFile(string[] contents)
        {
            foreach (var item in contents)
            {
                string s = item;
                try
                {
                    fs = new FileStream(filePath, FileMode.Open, FileAccess.Write);
                    StreamWriter sw = new StreamWriter(fs);
                    //contents = new string[] {"abc" , "wdf" }; 
                    sw.Write(s);
                    sw.Close();
                    sw.Dispose();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            
        }

        public string ReadFile()
        {
            string str = string.Empty;
            try
            {
                fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                char[] buffer = new char[1024];
                int res = sr.ReadBlock(buffer, 0, 6);
                sr.Close();
                sr.Dispose();
                Console.WriteLine(buffer);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return str;
        }


        public void Dispose()
        {
            fs.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
