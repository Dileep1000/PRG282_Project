using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PRG282_Project
{
    public class FileHandler
    {
        List<string> outContents = new List<string>();
           
        public string filePath = @"C:\Users\Dilee\Desktop\Client Credentials.txt";

        public void Write(List<ClientCredentials> lst) 
        {
            using (StreamWriter write = new StreamWriter(filePath))
            {
                foreach (ClientCredentials item in lst)
                {
                    outContents.Add(item.ToString());
                    write.Close();
                }
                File.WriteAllLines(filePath, outContents);
            }
        }
    }
}
