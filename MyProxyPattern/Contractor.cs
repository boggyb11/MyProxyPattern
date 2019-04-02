using System;

namespace MyProxyPattern
{
    class Contractor : IEmployee
    {
        private Employee employee = new Employee();

        public Contractor()
        {
            Console.WriteLine("Employed a contractor");
        }

        public void Work()
        {
            employee.Work();
        }
    }
}
