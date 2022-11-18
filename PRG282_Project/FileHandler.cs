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
        List<string> outContents2 = new List<string>();
        public string filePath = @"C:\Users\Dilee\Desktop\PRG282_Project\PRG282_Project\bin\Debug\Client Credentials.txt";

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
        public void WriteRegistration(List<ClientRegistration> list) 
        {
            FileStream stream = new FileStream(filePath, FileMode.Create);

            StreamWriter wr = new StreamWriter(stream);

            foreach (ClientRegistration item in list)
            {
                outContents2.Add(item.ToString());
                wr.Close();
            }
            File.AppendAllLines(filePath, outContents2);
        }
    }
}
