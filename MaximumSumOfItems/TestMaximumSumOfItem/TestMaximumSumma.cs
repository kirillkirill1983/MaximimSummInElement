using Microsoft.VisualStudio.TestTools.UnitTesting;
using MaximumSumOfItems;
using System.Collections.Generic;
using System;
using System.IO;

namespace TestMaximumSumOfItem
{
    [TestClass]
    public class TestMaximumSumma
    {
        [TestMethod]
        public void Test_find_maximum_position()
        {
            var inputText = new List<string>
            {"1,2,3,4",
            "1,2,3,",
            "1,2,2,3,4,5"
            };
            var maximumSuma = new ResultSumma(inputText);
            var exeptionResult = 3;
            var max = maximumSuma.Maximum();
            Assert.AreEqual(exeptionResult, Int32.Parse(max[0]));
        }

        [TestMethod]
        public void Test_find_maximum_()
        {
            var inputText = new List<string>
            {"1,2,3,4",
            "1,2,3,",
            "1,2,2,3,4,5"
            };
            var maximumSuma = new ResultSumma(inputText);
            var exeptionResult = 17;
            var outResult = maximumSuma.Maximum();
            var actualResult = maximumSuma.MaxNamber;
            Assert.AreEqual(exeptionResult, actualResult);
        }

        [TestMethod]
        public void Test_find_maximum_minus()
        {
            var inputText = new List<string>
            {"-1,-2,-3",
            "-1,-2",
            "-1"
            };
            var maximumSuma = new ResultSumma(inputText);
            var exeptionResult = -1;
            var outResult = maximumSuma.Maximum();
            var actualResult = maximumSuma.MaxNamber;
            Assert.AreEqual(exeptionResult, actualResult);
        }

        [TestMethod]
        public void Test_find_error_string()
        {
            var inputText = new List<string>
            {"1,2,3,4",
            "1,we,3,",
            "1,2,2,3,4,5"
            };
            var maximumSuma = new ResultSumma(inputText);
            var exeptionResult = 2;
            var outResult = maximumSuma.ErrorStringNamber();
            var lineNamber = outResult;
            var actualResult = Int32.Parse(lineNamber[0]);
            Assert.AreEqual(exeptionResult, actualResult);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Test_spase_file_name() 
        { 
            ReadFileMaximum readFileMaximum =new ReadFileMaximum(null);
            
        }
    }
}
