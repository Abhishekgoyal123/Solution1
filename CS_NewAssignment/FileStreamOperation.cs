using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text;
using System.Drawing;
using CS_NewAssignment;
//using CS_NewAssignment.Database;
//using CS_New1.Entities;
//using CS_New1.Models;
using System.IO;
//using System.Text.Json;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CS_NewAssignment
{

    public class FileStreamOperation : IDisposable
    {
        FileStream fs;

        string filePath = string.Empty;
        public FileStreamOperation()
        {
            filePath = @"C:\Assignment\NewFile1.txt";
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


        public void ReadFileByID(int Id)
        {

            string ln = string.Empty;
            //string final = string.Empty;



            // fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            // string abc = JsonConvert.DeserializeObject<Doctor>(fs);

            // var a=JsonSerializer.Deserialize<Staff>(fs);

            using (StreamReader sr = File.OpenText(filePath))
            {
                while ((ln = sr.ReadLine()) != null)
                {
                    var a = JsonConvert.DeserializeObject<Staff>(ln);

                    {
                        if (a.StaffCategory == "doctor")
                        {
                            Console.Write(a.StaffName);
                            Console.WriteLine();
                        }
                    }
                }
            }

                
               // sr.Close();


            
            
        }







        public void Dispose()
        {
            fs.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
