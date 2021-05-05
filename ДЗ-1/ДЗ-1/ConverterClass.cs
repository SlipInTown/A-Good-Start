namespace ДЗ_1
{
    public class ConverterClass
    {
        private string endedText = "Факториал равен ";

        private string endedText1 = "Сумма от 1 до N равна ";

        private string endedText2 = "Максимальное четное число меньше N равно";
        public void ConvertTuple((int, int, int) tuple)
        {

            var tempText = 
            $"{endedText} {tuple.Item1} " +
            $"\n{endedText1} {tuple.Item2} " +
            $"\n{endedText2} {tuple.Item3} ";
        }

        public string ReturnString()
        {
            return endedText;
        }
    }
}
