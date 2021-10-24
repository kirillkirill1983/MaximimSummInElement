using System;
using System.Collections.Generic;
using System.IO;


namespace MaximumSumOfItems
{
    public class ReadFileMaximum
    {
        private string _path;

        public string Path { get => _path; }

        public ReadFileMaximum(string path)
        {
            if (string.IsNullOrWhiteSpace(path))
            {
                throw new ArgumentNullException();
            }
            _path = path;
            ReadFile();
        }

        public List<string> ReadFile()
        {
            var listLine = new List<string>();

            try
            {
                string line = string.Empty;
                using var readFile = new StreamReader(_path);
                while ((line = readFile.ReadLine()) != null)
                {
                    if (line!=null)
                    {
                        listLine.Add(line);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"{nameof(ReadFile)} - {e.Message} The file could not be read:");
            }
            return listLine;
        }
    }
}
