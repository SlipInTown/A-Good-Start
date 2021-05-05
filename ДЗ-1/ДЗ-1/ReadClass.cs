using System;

namespace ДЗ_1
{
    internal class ReadClass : IRead
    {
        public string ReadString()
        {
            return Console.ReadLine();
        }
    }
}