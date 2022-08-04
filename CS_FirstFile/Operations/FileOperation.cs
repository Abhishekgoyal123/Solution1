using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using CS_FirstFile.Logic;
namespace CS_FirstFile.Operations
{
    public class FileOperation
    {
        public void CreateFile(string path, string filename)
        {
            try
            {
                if (filename == string.Empty)
                {
                    throw new Exception("File Name Cannot be Empty");
                }

                if (File.Exists($"{path} {filename}.txt"))
                {
                    {
                        throw new Exception("File already exists");
                    }
                }

                if (!Directory.Exists($"{path}"))
                {
                    {
                        throw new Exception("Directory does not exists");
                    }
                }
                string file = $"{path} {filename}.txt";
                FileStream fs = File.Create(file);



                Console.WriteLine("The File is created successfully");
                // Close the file so that the handle can be released
                // and the file is accessible fr other operations
                fs.Close();
                fs.Dispose();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void WriteFileIncome(string path, string filename, string[] contents)
        {
            try
            {
                if (filename == string.Empty)
                {
                    throw new Exception("File Name Cannot be Empty");
                }
                string file = $"{path} {filename}.txt";
                File.WriteAllLines(file, contents);
                Console.WriteLine("Contents are written to the File");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //public void WriteFile(string path, string filename, string contents)
        //{
        //    try
        //    {
        //        if (filename == string.Empty)
        //        {
        //            throw new Exception("File Name Cannot be Empty");
        //        }

        //        string file = $"{path} {filename}.txt";
        //        File.WriteAllText(file, contents);
        //        Console.WriteLine("Contents are written to the File");
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }
        //}

        //public string ReadFile(string path, string fileName)
        //{
        //    try
        //    {
        //        string contents = string.Empty;
        //        if (fileName == string.Empty)
        //        {
        //            throw new Exception("File Name Cannot be Empty");
        //        }

        //        string file = $"{path} {fileName}.txt";
        //        contents = File.ReadAllText(file);
        //        return contents;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        //public void AppendFile(string path, string filename, string contents)
        //{
        //    try
        //    {
        //        if (filename == string.Empty)
        //        {
        //            throw new Exception("File Name Cannot be Empty");
        //        }

        //        string file = $"{path} {filename}.txt";
        //        File.AppendAllText(file, contents);
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }
        //}

        //public void MoveFile(string path, string filename, string src , string dec)
        //{
        //    try
        //    {
        //        if (filename == string.Empty)
        //        {
        //            throw new Exception("File Name Cannot be Empty");
        //        }

        //         //src = $"{path} {filename}.txt";

        //        //string decpath = $@"C:\CheckMoved\";

        //        //dec = $"{path} {decpath}.txt";
        //        File.Move(src, dec);


        //        Console.WriteLine("Filed moved successfully");
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }
        //}

        //public void EncryptFile(string path, string filename)
        //{
        //    try
        //    {
        //        if (filename == string.Empty)
        //        {
        //            throw new Exception("File Name Cannot be Empty");
        //        }

        //        string file = $"{path} {filename}.txt";

        //        //string decpath = $@"C:\CheckMoved\";

        //        //dec = $"{path} {decpath}.txt";
        //        File.Encrypt(file);


        //        Console.WriteLine("Filed Encrypted successfully");
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }
        //}

        //public void DecryptFile(string path, string filename)
        //{
        //    try
        //    {
        //        if (filename == string.Empty)
        //        {
        //            throw new Exception("File Name Cannot be Empty");
        //        }

        //        string file = $"{path} {filename}.txt";

        //        //string decpath = $@"C:\CheckMoved\";

        //        //dec = $"{path} {decpath}.txt";
        //        File.Decrypt(file);


        //        Console.WriteLine("Filed Decrypted successfully");
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }
        //}

        //public void DeleteFile(string path, string filename)
        //{
        //    try
        //    {
        //        if (filename == string.Empty)
        //        {
        //            throw new Exception("File Name Cannot be Empty");
        //        }

        //        string file = $"{path} {filename}.txt";

        //        //string decpath = $@"C:\CheckMoved\";

        //        //dec = $"{path} {decpath}.txt";
        //        File.Delete(file);


        //        Console.WriteLine("Filed Deleted successfully");
        //   }
        //catch (Exception ex)
        //{

        //    throw ex;
        //}
    }

    }
//}
