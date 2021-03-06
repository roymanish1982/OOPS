﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcepts
{
    class Program
    {
        static void Main(string[] args)
        {
            CompareAndIComparer.MainClass.Processor();

            Delegates.DelegateImplementation.Object.DelegateOutput();

            Delegates.DelegateImplementation.Object.FunctionAndActionDelegate();

            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            new BaseDeriveInitizalition.Derived();
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.Green;
            new child();

            Console.ReadLine();
        }
    }
}
