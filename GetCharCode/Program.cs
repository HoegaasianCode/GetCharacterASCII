using System;

namespace GetCharCode
{
    class Program
    {
        // https://edabit.com/challenge/zaokQWNdEudmFWpk7
        // SOLVED

        static void Main(string[] args)
        {
            var c = new CharBois('a');
            c.InvertCase();
            c.ReConvert();
            Console.Write(c.GetASCII());
        }
    }
}
