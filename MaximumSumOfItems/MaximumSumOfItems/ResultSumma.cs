using System;
using System.Collections.Generic;
using System.Linq;


namespace MaximumSumOfItems
{
    public class ResultSumma
    {
        private List<string> _textFile = new List<string>();
        private List<int> _countString = new List<int>() ;
        private Dictionary<int, double> _keyValueMax = new Dictionary<int, double> ();
        private double _maxNamber = double.MinValue;

        public double MaxNamber { get => _maxNamber; }
        private FlagString FlagString { get; } = new FlagString();
        private GetSummaLine GetSummaLine { get; } = new GetSummaLine();

        public ResultSumma(List<string> textFile)
        {
            _textFile = textFile;
            InitStringAndMaximum();
        }

        public List<string> Maximum()
        {
            var maxNamber = double.MinValue;
            maxNamber = _keyValueMax.Max(s => s.Value);
            var resultSuma = _keyValueMax.Where(s => s.Value.Equals(maxNamber)).Select(s => s.Key).ToList();
            _maxNamber = maxNamber;
            return resultSuma.Select(s => Convert.ToString(s)).ToList<string>();
        }

        public List<string> ErrorStringNamber()
        {
            return _countString.Select(s => Convert.ToString(s)).ToList<string>();
        }

        private void InitStringAndMaximum()
        {
            var count = 0;
            foreach (var item in _textFile)
            {
                count++;
                if (FlagString.Flag(item))
                {
                    double suma = GetSummaLine.SummaLine(item);
                    _keyValueMax.Add(count, suma);
                }
                else
                {
                    _countString.Add(count);
                }
            }
        }
    }
}
