using System;

namespace ДЗ_1
{
    internal sealed class OutPutClass : IOutPut
    {
        public void Show(string temp)
        {
            Console.WriteLine(temp);
        }
    }
}