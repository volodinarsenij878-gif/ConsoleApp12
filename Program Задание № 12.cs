using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"sbyte: [{sbyte.MinValue}, {sbyte.MaxValue}]");
            Console.WriteLine($"byte: [{byte.MinValue}, {byte.MaxValue}]");

            Console.WriteLine($"short: [{short.MinValue}, {short.MaxValue}]");
            Console.WriteLine($"ushort: [{ushort.MinValue}, {ushort.MaxValue}]");

            Console.WriteLine($"int: [{int.MinValue}, {int.MaxValue}]");
            Console.WriteLine($"uint: [{uint.MinValue}, {uint.MaxValue}]");

            Console.WriteLine($"long: [{long.MinValue}, {long.MaxValue}]");
            Console.WriteLine($"ulong: [{ulong.MinValue}, {ulong.MaxValue}]");
        }
    }
}


