using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaceconcept
{
    interface Father
    {
         void FAddress();
    }
    interface Mother: Father
    {
        void MAddress();
    }

    class Son : Father, Mother
    {
        public void FAddress()
        {
            Console.WriteLine("Father Address");
        }

        public void MAddress()
        {
            Console.WriteLine("Mother Address");
        }
    }
    class Program: Son
    {
        static void Main(string[] args)
        {
            Son s = new Son();
            s.FAddress();
            s.MAddress();
            Console.ReadLine();
        }
    }
}
