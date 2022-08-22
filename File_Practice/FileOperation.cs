using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace File_Practice
{
    public class FileOperation 
    {
        public void CreateFile(string fileName) 
        {
            try
            {
                if (fileName == string.Empty)
                {
                    throw new ArgumentException("FileName cannot be empty");
                }

                FileStream fs = File.Create(fileName);
                Console.WriteLine("file created");

                fs.Close();
            }

            catch ( Exception ex)
            {
                throw ex;
            }
        }

        public void WriteFile( string fileName,string content)
        {
            try
            {
                if (fileName == string.Empty)
                {
                    throw new Exception("file name cannot be empty");
                }

                File.WriteAllText(fileName, content);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void ReadFile( string filename)
        {
            try
            {
                if(filename == string.Empty)
                {
                    throw new Exception("file name ecannot be empty");
                }

                string[] Content = File.ReadAllLines(filename);
                Console.WriteLine("++++++++++++++++++++++++++++++++++++Contents from file are : ++++++++++++++++++++++++++++++++++++++");
                
                foreach(var item in Content)
                {
                    Console.WriteLine(item);
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        
    }
}
