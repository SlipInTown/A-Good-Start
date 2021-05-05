using System;
using System.Collections.Generic;
using System.Text;

namespace ДЗ_1
{
    public class ConverterClass
    {
        private string endedText;
        public void ConvertTuple((int, int, int) tuple)
        {
            endedText = $"Факториал равен {tuple.Item1} " +
            $"\nСумма от 1 до N равна {tuple.Item2} " +
            $"\nМаксимальное четное число меньше N равно {tuple.Item3}";
        }

        public string ReturnString()
        {
            return endedText;
        }
    }
}
