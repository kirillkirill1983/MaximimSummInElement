using Microsoft.VisualStudio.TestTools.UnitTesting;

using MaximumSumOfItems;
using System.Collections.Generic;
using System;

namespace TestMaximumSumOfItem
{
    [TestClass]
    public class UnitTaest
    {
        [TestMethod]
        public void Test_find_maximum_position()
        {
            var outResult = new Dictionary<int, List<string>>();
            var lineNamber = new List<string>();
            var maximumSuma = new MaxinunSummmaOfItems();
            var inputText = new List<string>
            {"1,2,3,4",
            "1,2,3,",
            "1,2,2,3,4,5"
            };


            int exeptionResult = 3;
            outResult = maximumSuma.ResultSummaNew(inputText);
            lineNamber = outResult[1];
            int actualResult = Int32.Parse(lineNamber[0]);
            Assert.AreEqual(exeptionResult, actualResult);

        }

        [TestMethod]
        public void Test_find_maximum_()
        {
            var outResult = new Dictionary<int, List<string>>();
            var lineNamber = new List<string>();
            var maximumSuma = new MaxinunSummmaOfItems();

            var inputText = new List<string>
            {"1,2,3,4",
            "1,2,3,",
            "1,2,2,3,4,5"
            };

            int exeptionResult = 17;
            outResult = maximumSuma.ResultSummaNew(inputText);
            lineNamber = outResult[3];
            int actualResult = Int32.Parse(lineNamber[0]);
            Assert.AreEqual(exeptionResult, actualResult);

        }

        [TestMethod]
        public void Test_find_error_string()
        {
            var outResult = new Dictionary<int, List<string>>();
            var lineNamber = new List<string>();
            var maximumSuma = new MaxinunSummmaOfItems();

            var inputText = new List<string>
            {"1,2,3,4",
            "1,we,3,",
            "1,2,2,3,4,5"
            };

            int exeptionResult = 2;
            outResult = maximumSuma.ResultSummaNew(inputText);
            lineNamber = outResult[2];
            int actualResult = Int32.Parse(lineNamber[0]);
            Assert.AreEqual(exeptionResult, actualResult);

        }
    }
}
