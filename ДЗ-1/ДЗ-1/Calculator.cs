using System;

namespace ДЗ_1
{
    internal sealed class Calculator
    {
        private const int _startValue = 1;
        private const int _initValue = 0;

        public (int,int,int) Calculate(string value)
        {
            int convertedString = Int32.Parse(value);

            int _sumOfFactorial = _startValue;
            int _sumOfNumbers = _initValue;
            int _oddValue = _initValue;
            for (int i = 1; i <= convertedString; i++)
            {
                _sumOfFactorial = _sumOfFactorial * i;
                _sumOfNumbers = _sumOfNumbers + i;
                if (i % 2 == 0)
                {
                    _oddValue = i;
                }
            }

            return (_sumOfFactorial, _sumOfNumbers, _oddValue);
        }
    }
}