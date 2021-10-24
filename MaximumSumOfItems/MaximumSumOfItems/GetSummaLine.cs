using System.Collections.Generic;
using System.Globalization;
using System.Linq;


namespace MaximumSumOfItems
{
    public class GetSummaLine
    {
        public double SummaLine(string line)
        {
            double summaArray = 0;
            var listNamber = SplittingStringIntoElements(line);

            foreach (var item in listNamber)
            {
                double.TryParse(item, NumberStyles.Any,CultureInfo.InvariantCulture, out double summa);
                summaArray += summa;
            }
            return summaArray;
        }

        private static List<string> SplittingStringIntoElements(string line)
        {
            var arrayList = line.Split(',');
            var lineDouble = new List<string>();

            for (int i = 0; i < arrayList.Length; i++)
            {
                string tempString = arrayList[i];
                lineDouble.Add(tempString);
            }
            return lineDouble;
        }
    }
}
