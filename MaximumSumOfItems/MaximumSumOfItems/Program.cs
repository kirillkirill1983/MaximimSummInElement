using System;
using System.Collections.Generic;
using System.Linq;

namespace MaximumSumOfItems
{
    class Program
    {
        public static void Main(string[] args)
        {
            Program program = new Program();
            Start(args.FirstOrDefault());
        }

        public static void Start(string arg)
        {
            try
            {
                string path = InputUserPath(arg);
                var maxinun = new MaxinunSummmaOfItems();
                var readFile = maxinun.ReadFile(path);

                var valueToPrint = new Dictionary<int, List<string>>();
                valueToPrint = maxinun.ResultSummaNew(readFile);
                maxinun.PrintSummaLine(valueToPrint);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }

        private static string InputUserPath(string inputPath)
        {
            Console.WriteLine("Enter PATH");
            string path = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(path))
            {
                throw new ArgumentNullException(nameof(InputUserPath), "Error path");
            }
            return path;
        }
    }
}
