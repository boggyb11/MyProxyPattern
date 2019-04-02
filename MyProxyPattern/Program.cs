using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyProxyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Contractor contractor = new Contractor();
            contractor.Work();

            Console.ReadLine();
        }
    }
}
