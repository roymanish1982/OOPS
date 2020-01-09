using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcepts
{
    public abstract class A { }

    public sealed class B { }

    public class D
    {
        private D() { }
    }


    public class C
    {
        public C()
        {
            //Error : Compaile Time
            //A a = new A();
            //D d = new D();
        }
    }

    /*
     * Can you mark static constructor with access modifiers?
        No, we cannot use access modifiers on static constructor.

        Can you have parameters for static constructors?
            No, static constructors cannot have parameters.

        What happens if a static constructor throws an exception?
            If a static constructor throws an exception, the runtime will not invoke it a second time, and the type will remain uninitialized for the lifetime of the application domain in which your program is running.

        Give 2 scenarios where static constructors can be used?
            1. A typical use of static constructors is when the class is using a log file and the constructor is used to write entries to this file.
            2. Static constructors are also useful when creating wrapper classes for unmanaged code, when the constructor can call the LoadLibrary method.
     */

    public abstract class Base
    {
        static Base()
        {
            Console.WriteLine("Base Ststic");
        }

        public Base() 
        {
            Console.WriteLine("In Base");
        }
    }

    public class child : Base 
    {
        static child()
        {
            Console.WriteLine("Child Ststic");
        }

        public child() : base() 
        {
            Console.WriteLine("Child");
        }
    }
}
