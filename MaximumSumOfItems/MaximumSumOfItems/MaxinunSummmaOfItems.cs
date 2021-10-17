using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace MaximumSumOfItems
{
    public class MaxinunSummmaOfItems
    {
        public List<string> ReadFile(string path)
        {
            if (path == null)
            {
                throw new ArgumentNullException();
            }
            var listLine = new List<string>();

            try
            {
                string line = string.Empty;
                using var readFile = new StreamReader(path);
                while ((line = readFile.ReadLine()) != null)
                {
                    if (!string.IsNullOrWhiteSpace(line))
                    {
                        listLine.Add(line);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
            return listLine;
        }

        public Dictionary<int, List<string>> ResultSummaNew(List<string> line)
        {
            double suma = double.MinValue;
            var keyValuePairs = new Dictionary<int, double>();
            int count = 0;
            var countString = new List<int>();

            foreach (var item in line)
            {
                count++;
                if (FlagString(item))
                {
                    suma = GetSummaLine(item);
                    keyValuePairs.Add(count, suma);
                }
                else
                {
                    countString.Add(count);
                }
            }
            Dictionary<int, List<string>> resultLine = new Dictionary<int, List<string>>();
            double max = double.MinValue;
            max = keyValuePairs.Max(s => s.Value);
            var resultSuma = keyValuePairs.Where(s => s.Value.Equals(max)).Select(s => s.Key).ToList();


            List<string> outNamberMaximum = new List<string>();
            foreach (var item in resultSuma)
            {
                outNamberMaximum.Add(item.ToString());
            }
            resultLine.Add(1, outNamberMaximum);

            List<string> textErrorOut = new List<string>();
            foreach (var item in countString)
            {
                textErrorOut.Add(item.ToString());
            }
            resultLine.Add(2, textErrorOut);

            List<string> stringPositionNamberMaximum = new List<string>();
            stringPositionNamberMaximum.Add(max.ToString());
            resultLine.Add(3, stringPositionNamberMaximum);

            return resultLine;
        }

        public void PrintSummaLine(Dictionary<int, List<string>> valueToPrint)
        {
            List<string> linePositionMaximin = new List<string>();
            List<string> lineStringError = new List<string>();
            List<string> lineNamberMaximum = new List<string>();
            linePositionMaximin = valueToPrint[1]; //return position namber in text
            lineStringError = valueToPrint[2];   //  return error string
            lineNamberMaximum = valueToPrint[3];  // return maximum


            Console.Write("Maximum namber string => \n");
            foreach (var item in linePositionMaximin)
            {
                Console.WriteLine(item);
            }

            Console.Write("Maximum namber \n");
            foreach (var item in lineNamberMaximum)
            {
                Console.WriteLine(item);
            }

            Console.Write("Line to string \n");

            foreach (var item in lineStringError)
            {
                Console.Write($"{item} ");
            }
        }

        private double GetSummaLine(string line)
        {
            double suma = double.MinValue;
            var length = line.Length;
            var arrayNamber = new int[length];
            var listNamber = new List<string>();
            var summaArray = 0;

            for (int i = 0; i < arrayNamber.Length; i++)
            {
                summaArray += arrayNamber[i];
            }

            listNamber = SplittingStringIntoElements(line);
            double summaDouble = 0;

            foreach (var item in listNamber)
            {
                string text = item.Replace(".", ",");
                summaDouble += double.Parse(text);
            }

            suma = (double)summaArray + summaDouble;
            return suma;
        }

        private static List<string> SplittingStringIntoElements(string line)
        {
            if (String.IsNullOrWhiteSpace(line))
            {
                Console.WriteLine("Пустая строка");
            }
            var pareLine = line.Split(',');
            var arrayList = pareLine.ToArray();

            var lineDouble = new List<string>();
            var tempString = string.Empty;

            for (int i = 0; i < arrayList.Length; i++)
            {
                tempString = arrayList[i];

                foreach (var item in tempString)
                {
                    if (item == '.')
                    {
                        lineDouble.Add(tempString);
                    }

                }
                if (arrayList[i] == String.Empty)
                {
                    tempString = "0";
                }
                else if (String.IsNullOrWhiteSpace(arrayList[i]))
                {
                    tempString = "0";
                }
                else
                {
                    lineDouble.Add(tempString);
                }
            }
            return lineDouble;
        }

        private bool FlagString(string line)
        {
            var pareLine = line.Split(',');
            var arrayList = pareLine.ToArray();

            var lineDouble = new List<string>();
            var tempString = string.Empty;

            for (int i = 0; i < arrayList.Length; i++)
            {
                tempString = arrayList[i];

                foreach (var item in tempString)
                {
                    if (char.IsLetter(item))
                    {
                        return false;
                    }
                }
                if (String.IsNullOrWhiteSpace(arrayList[i]))
                {
                    return false;
                }

            }
            return true;
        }
    }
}

