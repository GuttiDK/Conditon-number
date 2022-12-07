using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Program
{

    public class Program
    {

        static void MainStart(string[] args)
        {
            Console.Write("input: ");
            string test = Kondital("Hejsa med dig");
            Console.WriteLine(test);
        }

        static string Kondital(string est)
        {
            Console.WriteLine(est);
            return "Hejsa";
        }

    }
}
