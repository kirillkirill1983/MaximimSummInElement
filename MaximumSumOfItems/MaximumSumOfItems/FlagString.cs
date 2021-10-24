using System;
using System.Linq;


namespace MaximumSumOfItems
{
    public class FlagString
    {
        public bool Flag(string line)
        {
            if (string.IsNullOrWhiteSpace(line))
            {
                return false;
            }

            var arrayList = line.Split(',');

            for (int i = 0; i < arrayList.Length; i++)
            {
                if (String.IsNullOrWhiteSpace(arrayList[i]))
                {
                    return false;
                }
                string tempString = arrayList[i];
                foreach (var item in tempString)
                {
                    if (char.IsDigit(item))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
