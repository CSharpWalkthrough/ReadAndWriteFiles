using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadAndWriteFiles.Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadFromFile("read.txt");
            WriteToFile();
            AppendToFile("write.txt");

            Console.WriteLine();

            ReadFromFile("write.txt");
            Console.ReadLine();
        }

        private static void ReadFromFile(string path)
        {
            // Check if file exists
            if (!File.Exists(path))
                throw new FileNotFoundException();

            // Initialize StreamReader with OpenText
            using (StreamReader sr = File.OpenText(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null) // Assign new line to variable
                    Console.WriteLine(line); // Print read line
            }

        }

        private static void WriteToFile()
        {
            string path = "write.txt";
            // Initialize StreamWriter with CreateText
            using (StreamWriter sw = File.CreateText(path))
            {
                // Write content using StreamWriter object
                sw.WriteLine("First line");
                sw.WriteLine("Second line");
                sw.WriteLine("Third line");
            }
        }
        private static void AppendToFile(string path)
        {
            // Check if file exists
            if (!File.Exists(path))
                throw new FileNotFoundException();

            // Append text to end of file using AppendAllText
            string textOne = "\nUsing AppendAllText method" + Environment.NewLine;
            File.AppendAllText(path, textOne); // Two params (path, text)

            // Append text to end of file using AppendText
            // Initialize StreamWriter with AppendTextw
            using (StreamWriter sw = File.AppendText(path)) 
            {
                // Write content using StreamWriter object
                sw.WriteLine("Using AppendText method");
                sw.WriteLine("We use the StreamWriter object");
            }

        }
    }
}
