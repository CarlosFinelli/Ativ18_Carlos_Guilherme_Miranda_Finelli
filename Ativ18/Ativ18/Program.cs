using System;

namespace Ativ18
{
    class Program
    {
        static void Main(string[] args)
        {
            int? A = null;
            long? b = null;
            ushort? c = null;
            double? d = null;
            int e = A ?? 34;
            long f = b ?? 65000000;
            ushort g = c ?? 500;
            double h = d ?? 7.50;
            int i = A.GetValueOrDefault(e);
            Console.WriteLine(i);
        }
    }
}
