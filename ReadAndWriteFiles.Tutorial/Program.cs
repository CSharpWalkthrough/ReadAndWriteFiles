using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadAndWriteFiles.Tutorial
{
    /// <summary>
    /// A program to showcase the use of System.IO methods to read and 
    /// write to files. Use of breakpoints and debugging is suggested.
    /// </summary>
    class Program
    {
        private const string READ_FILE_PATH = "read.txt";
        private const string WRITE_FILE_PATH = "write.txt";
        static void Main(string[] args)
        {
            Console.WriteLine("---READ FILE---" + Environment.NewLine);
            ReadFromFile(READ_FILE_PATH);
            WriteToFile();

            Console.WriteLine("---WRITE TO FILE---" + Environment.NewLine);
            Console.WriteLine("Check the write.txt file and any key to continue");
            Console.ReadKey();

            AppendToFile(WRITE_FILE_PATH);
            Console.WriteLine("Check the write.txt file again");
            Console.ReadKey();
        }

        #region Read File
        private static void ReadFromFile(string path)
        {
            // Check if file exists
            if (!File.Exists(path))
                throw new FileNotFoundException();

            // Using OpenText method
            OpenText(path);

            // Using ReadAllText method
            ReadAllText(path);

            // Using ReadAllLines method
            ReadAllLines(path);
        }

        private static void OpenText(string path)
        {
            // Initialize StreamReader with OpenText
            Console.WriteLine("Using OpenText :" + Environment.NewLine);
            using (StreamReader sr = File.OpenText(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null) // Assign new line to variable
                    Console.WriteLine(line); // Print read line
            }
        }

        private static void ReadAllText(string path)
        {
            Console.WriteLine(Environment.NewLine + "Using ReadAllText :" + Environment.NewLine);

            // The following will return all the file text into a string
            string content = File.ReadAllText(path);
            Console.WriteLine(content);

            // We could also split our content into an array and loop through it
            Console.WriteLine(Environment.NewLine + "Looping through lines" + Environment.NewLine);

            string[] newLine = new[] { Environment.NewLine };
            string[] contentLines = content.Split(newLine, StringSplitOptions.None);
            foreach (string line in contentLines)
                Console.WriteLine(line);
        }

        private static void ReadAllLines(string path)
        {
            Console.WriteLine(Environment.NewLine + "Using ReadAllLines :" + Environment.NewLine);

            // The following will return an array of string where each element represents a line of content
            string[] lines = File.ReadAllLines(path);
            foreach (string line in lines)
                Console.WriteLine(line);

            Console.WriteLine();
        }
        #endregion


        #region Write to File
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
        #endregion
    }
}
