using System;

namespace MyProxyPattern
{
    public class Employee : IEmployee
    {
        public void Work()
        {
            Console.WriteLine("Employee doing work!!!");
        }
    }
}
