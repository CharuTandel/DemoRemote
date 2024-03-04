using System;

namespace MyCompiler {
    class Program {
        public static void Main(string[] args) {
            Console.WriteLine("Hello world!");
            int? a = null;
            int b = 3;

            Console.WriteLine($"prin{b}ted value {a}");
            string? stor = null;
            //Type vari = a.GetType();
            Console.WriteLine( "and " +stor);
        }
    }
}
