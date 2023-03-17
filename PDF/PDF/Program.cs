using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //create folder

            string textDocument = $"C:\\Users\\student\\Desktop\\Elpros\\Vjezbe";
            if (!Directory.Exists(textDocument))
            {
                Directory.CreateDirectory(textDocument);
            }


            //create file

            string fileName = "firstFile.txt";
            string fileLocation = Path.Combine(textDocument, fileName);

            if (!File.Exists(fileLocation))
            {
                FileStream stream = File.Create(fileLocation);
                stream.Flush();
                stream.Close();


            }
            // input text in file

            using (FileStream fileStream = new FileStream(fileLocation, FileMode.Open))
            {
                StreamWriter writer = new StreamWriter(fileStream);
                writer.WriteLine("This works. ");
                writer.Flush();
                writer.Close();
            }


            //reading a file + copy/paste file

            string filePath = @"C:\Users\student\Desktop\Elpros\Vjezbe\Tekst.txt";  //(.txt)moramo napisati format file-a ince nece raditi

            if (File.Exists(filePath))
            {
                string fileContents = File.ReadAllText(filePath);
                Console.WriteLine("File contents:" + fileContents);

                //copy file contents to another file

                string destFileLocation = @"C:\Users\student\Desktop\Elpros\Vjezbe\Copy.txt";

                if (File.Exists(destFileLocation))
                {
                    //if the destination file exists, overwrite it
                    File.Copy(filePath, destFileLocation, true);
                }
                else
                {
                    //if the destination file doesn't exist, create it and copy the contents
                    File.WriteAllText(destFileLocation, fileContents);
                }
            }
            else
            {
                Console.WriteLine("File does not exist!");
            }

        }
    }
}