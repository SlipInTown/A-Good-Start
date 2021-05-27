
namespace ДЗ_1
{
    internal sealed class Program
    {
        private const string _badString = "q";

        private static IOutPut outPut;
        
        private static IInput input;
        
        private static IRead read;
        
        private static ICalculator calculator;

        private static IConverterClass converterClass;

        private static string _pathWelcome = @"Text\Welcome.txt";

        private static string _pathEnd = @"Text\Answer.txt";


        public static void Main(string[] args)
        {
            StartProgram();
        }

        private static void StartProgram()
        {
            outPut = new OutPutClass();

            input = new InPutClass();

            read = new ReadClass();

            calculator = new Calculator();

            converterClass = new ConverterClass();

            outPut.Show(input.Input(_pathWelcome));

            string _userString = read.ReadString();

            if (CheckForErrorString(_userString)) return;

            converterClass.ConvertTuple(calculator.Calculate(_userString));

            input.WriteFile(_pathEnd, converterClass.ReturnString());

            outPut.Show(input.Input(_pathEnd));

        }

        private static bool CheckForErrorString(string temp)
        {
            return temp == _badString;
        }
    }
}
