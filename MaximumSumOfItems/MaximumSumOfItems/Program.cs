using System;
using System.IO;
using System.Linq;

namespace MaximumSumOfItems
{
    public class Program
    {
        public static void Main(string[] args)
        {
            do
            {
                try
                {
                    string line = args.FirstOrDefault();
                    if (string.IsNullOrWhiteSpace(line))
                    {
                        line = InputUserPath();
                    }
                    Start(line);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exit");
                    Console.WriteLine($"Error : {ex.Message}");
                    Console.WriteLine("Plees enter any key to continue or NO to exit");
                    
                    var exit = Convert.ToString(Console.ReadLine());

                    if (ExitProgramm(exit))
                    {
                        break;
                    }
                }
            } while (true);
        }

        public static void Start(string arg)
        {
            
            while (true)
            {
                try
                {
                    var readFileMaximum = new ReadFileMaximum(arg);
                    var fileText = readFileMaximum.ReadFile();

                    var resultSumma = new ResultSumma(fileText);
                    var namberPositionMaximum = resultSumma.Maximum();

                    var maximum = resultSumma.MaxNamber;

                    var stringError = resultSumma.ErrorStringNamber();

                    foreach (var item in namberPositionMaximum)
                    {
                        Console.WriteLine("The line where the maximum value is =>{0} ", item.ToString());
                    }

                    Console.WriteLine("Maximum value => {0} ", maximum);
                    Console.Write("Strings that contain characters => ");

                    foreach (var item in stringError)
                    {
                        Console.Write($"*{ item}* ");
                    }

                    Console.WriteLine();
                    Console.WriteLine("Plees enter any key to continue or NO to exit");
                    var exit = Convert.ToString(Console.ReadLine());

                    if (ExitProgramm(exit))
                    {
                        break;
                    }

                    if (string.IsNullOrWhiteSpace(exit))
                    {
                        Console.WriteLine("Exit");
                        Console.ReadLine();
                        break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exit");
                    Console.WriteLine($"Error : {ex.Message}");
                    Console.WriteLine("Plees enter any key to continue or NO to exit");
                    var exit = Convert.ToString(Console.ReadLine());

                    if (ExitProgramm(exit))
                    {
                        break;
                    }
                }
            }
        }

        private static string InputUserPath()
        {
            Console.WriteLine("Enter PATH");
            var path = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(path))
            {
                throw new ArgumentNullException("Argumen nuull");
            }

            var exists = File.Exists(path);

            if (!(exists))
            {
                throw new FileNotFoundException("There is no file with this name in this directory");
            }
            return path;
        }

        private static bool ExitProgramm(string line)
        {
            if (line == "NO")
            {
                return true;
            }
            return false;
            
        }
    }
}
