using System.IO;

namespace ДЗ_1
{
    sealed class InPutClass : IInput
    {
        public string Input(string path)
        {
            if (!FileExist(path)) return null;

            StreamReader streamReader = File.OpenText(path);

            var text = streamReader.ReadToEnd().ToString();

            streamReader.Close();

            return text;
        }

        public void WriteFile(string path, string text)
        {
            StreamWriter sw = File.CreateText(path);

            sw.WriteLine(text);

            sw.Close();
        }

        private bool FileExist(string path)
        {
            if (!File.Exists(path)) return false;
            else return true;
        } 
    }
}
