using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSharpMoudleX
{
    class Program
    {
        static void Main(string[] args)
        {
            Function fun = new Function();
            Console.WriteLine(fun.add(2000, 3000));
            Console.WriteLine(fun.say("hello world!"));
            Console.ReadKey();
        }
    }
}
