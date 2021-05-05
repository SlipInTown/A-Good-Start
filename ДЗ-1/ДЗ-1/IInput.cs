namespace ДЗ_1
{
    internal interface IInput
    {
        public string Input(string path);

        public void WriteFile(string path, string text);
    }
}