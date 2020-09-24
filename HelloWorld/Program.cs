using HelloWorld.Calculation;
using System;
//using HelloWorld.Calculation;

namespace HelloWorld
{
    /// <summary>
    /// 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Cal c = new Cal();
            //c.AddNunber(3, 6);
            int ca = c.AddNumber(3, 6);
            Console.WriteLine(ca);
            Console.WriteLine("Hello welcome, back Guys!");
            string x = Console.ReadLine();

            Console.WriteLine(x);
        }
    }
}
