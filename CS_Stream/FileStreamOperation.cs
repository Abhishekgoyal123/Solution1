using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Stream
{
    public class FileStreamOperation : IDisposable
    {
        FileStream fs;
        string filePath = string.Empty;
        public FileStreamOperation()
        {
            filePath = @"C:\FileStream\data.txt";
        }

        //public void CreateFile()
        //{
        //    try
        //    {
        //        fs = new FileStream(filePath, FileMode.CreateNew);
        //        fs.Close();
        //        // fs.Dispose();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        //public void WriteFile(string contents)
        //{
        //    try
        //    {
        //        fs = new FileStream(filePath, FileMode.Open, FileAccess.Write);
        //        StreamWriter sw = new StreamWriter(fs);
        //        sw.Write(contents);
        //        sw.Close();
        //        sw.Dispose();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        public string ReadFile()
        {
            string str = string.Empty;
            try
            {
                fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                str = sr.ReadToEnd();
               
                sr.Close();
                sr.Dispose();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return str;
        }

        public string ReadByLine()
        {
            string str = string.Empty;
            try
            {
                fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                str = sr.ReadLine();

                sr.Close();
                sr.Dispose();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return str;
        }

        public string ReadSpecificIndex(int start, int count)
        {
            string str = string.Empty;
            //char[] arr = new char[] { };

            //for (int i =start; i < count; i++)
            //{
            //    arr[i] = FileAccess.Read(start)
            //}

           // char[] arr = new char[] {};
            try
            {
                fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);

                char[] arr = new char[] { };

                for (int i = start; i < count; i++)
                {
                    //arr[i] = FileAccess.Read(start)
                    str = sr.ReadBlock(arr[i], start, count);
                }
                str = sr.ReadBlock(arr[], start, count);

                sr.Close();
                sr.Dispose();
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
