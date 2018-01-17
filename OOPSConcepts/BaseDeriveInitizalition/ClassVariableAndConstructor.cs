using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcepts.BaseDeriveInitizalition
{
    public class Base
    {
        private int x = BaseInitializer();

        public Base()
        {
            Console.WriteLine("Base ctor");
        }

        private static int BaseInitializer()
        {
            Console.WriteLine("BaseInitializer");
            return 0;
        }
    }

    public class Derived : Base
    {
        private int x = DerivedInitializer();

        public Derived() : base()
        {
            Console.WriteLine("Derived ctor");
        }

        private static int DerivedInitializer()
        {
            Console.WriteLine("DerivedInitializer");
            return 0;
        }
    }
}
