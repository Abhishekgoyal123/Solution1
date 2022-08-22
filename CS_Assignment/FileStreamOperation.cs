﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text;
using System.Drawing;

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

        public void ReadFileByCategory(string category)
        {
            string str = string.Empty;
            string ln = string.Empty;

            
            try
            {
                fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);

                while ((ln = sr.ReadLine()) != null)
                {
                    if(ln.Contains(category))
                    {
                        Console.WriteLine(ln);
                    }
                       
                    
                }
                    //char[] buffer = new char[1024];
                   // str = sr.ReadLine();
                sr.Close();
                
                sr.Dispose();
                // Console.WriteLine(str);
            }
            catch (Exception ex)
            {
                throw ex;
            }
           
        }

        public void ReadFileByID(int Id)
        {
            
            string ln = string.Empty;
            

            try
            {
                fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                
                while ((ln = sr.ReadLine()) != null)
                {
                    if (ln.Contains(Convert.ToString(Id)))
                    {
                        Console.WriteLine(ln);
                        
                    }


                }
                //char[] buffer = new char[1024];
                // str = sr.ReadLine();
                sr.Close();

                sr.Dispose();
                // Console.WriteLine(str);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void ReadRecordsByCount(int count)
        {
            int cnt = 0;
            string ln = string.Empty;


            try
            {
                fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);

                while ((ln = sr.ReadLine()) != null && cnt !=count)
                {  
                        Console.WriteLine(ln);
                    cnt++;

                }
                //char[] buffer = new char[1024];
                // str = sr.ReadLine();
                sr.Close();

                sr.Dispose();
                // Console.WriteLine(str);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void DeleteStaffById(int id)
        {
           
            string ln = string.Empty;

            try
            {
               fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                //fs = new FileStream(filePath, FileMode.Open, FileAccess.Write);
                StreamReader sr = new StreamReader(fs);
                string temp = String.Empty;
                while (( temp = sr.ReadLine()) != null )
                {
                    if (!temp.Contains(Convert.ToString(id)))
                    {
                        ln += temp;
                       ln +="\n";
                        Console.WriteLine(temp);
                        
                        
                    }
                   

                }
                sr.Close();sr.Dispose();
                fs = new FileStream(filePath, FileMode.Open, FileAccess.Write);
                StreamWriter streamWriter = new StreamWriter(fs);

                // File.AppendText(ln);
                //char[] buffer = new char[1024];
                // str = sr.ReadLine();
                //fs.Flush();
                //streamWriter.Flush();
                streamWriter.WriteLine(ln);
                
                streamWriter.Close();

                streamWriter.Dispose();
                // Console.WriteLine(str);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        public void UpdateStaffById(int id, string abc, string def)
        {

            string ln = string.Empty;

            try
            {
                fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                //fs = new FileStream(filePath, FileMode.Open, FileAccess.Write);
                StreamReader sr = new StreamReader(fs);
               // string temp = String.Empty;
                while ((ln = sr.ReadLine()) != null)
                {
                    if (ln.Contains(Convert.ToString(id)) && ln.Contains(abc))
                    {
                        //ln += temp;
                        //ln += "\n";
                        ln.Replace(abc, def);
                        Console.WriteLine(ln);
                        
                       // ln.Replace(abc, def);
                    }


                }
                sr.Close(); sr.Dispose();
                fs = new FileStream(filePath, FileMode.Open, FileAccess.Write);
                StreamWriter streamWriter = new StreamWriter(fs);

                // File.AppendText(ln);
                //char[] buffer = new char[1024];
                // str = sr.ReadLine();
                //fs.Flush();
                //streamWriter.Flush();
                streamWriter.WriteLine(ln);

                streamWriter.Close();

                streamWriter.Dispose();
                // Console.WriteLine(str);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }



        public  void FileDetails()
        {
            string filename = @"C:\Assignment\Screenshot (9).abc";
            FileInfo fi = new FileInfo(filename);
            string fname = fi.Name;
            string ext = fi.Extension;
           Console.WriteLine($"file name  = {fname}");
            Console.WriteLine($"file name  = {ext}");
            //return ext;
        }

        //public void ImgtoByteArray(Image image)
        //{
        //    //MemoryStream ms = new MemoryStream()
        //    //{
               
        //    //}
            
        //}
        public void Dispose()
        {
            fs.Dispose();
            GC.SuppressFinalize(this);
        }

       public void DirectoryInfo()
        {
            string Dirpath = @"C:\Assignment";
            DirectoryInfo dinfo = new DirectoryInfo(Dirpath);

            FileInfo[] Files = dinfo.GetFiles();
           
            
            foreach (FileInfo i in Files)
            {
                
                Console.WriteLine($"File Name - {i.Name}");
                Console.WriteLine($"Creation Time - {i.CreationTime}");
            }
                           


        }
    }
}
