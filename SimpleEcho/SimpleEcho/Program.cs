using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleEcho
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Count() > 0)
            {
                Console.WriteLine(args[0]);
            }
            else
            {
                Console.WriteLine("No argument passed");
            }
        }
    }
}
