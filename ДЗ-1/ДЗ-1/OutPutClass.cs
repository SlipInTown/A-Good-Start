using System;

namespace ДЗ_1
{
    public sealed class OutPutClass : IOutPut
    {
        public void Show(string temp)
        {
            Console.WriteLine(temp);
        }
    }
}