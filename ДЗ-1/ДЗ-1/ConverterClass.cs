namespace ДЗ_1
{
    internal sealed class ConverterClass : IConverterClass
    {
        private string endedText = "Факториал равен ";

        private string endedText1 = "Сумма от 1 до N равна ";

        private string endedText2 = "Максимальное четное число меньше N равно";

        private string fulltext;
        public void ConvertTuple((int, int, int) tuple)
        {
            fulltext = $"{endedText} {tuple.Item1} " +
            $"\n{endedText1} {tuple.Item2} " +
            $"\n{endedText2} {tuple.Item3} ";
        }

        public string ReturnString()
        {
            return fulltext;
        }
    }
}
