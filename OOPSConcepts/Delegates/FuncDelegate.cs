using System;

namespace OOPSConcepts.Delegates
{

    public delegate int myDelegate(int x, int y);

    public delegate T myGenericDelegate<T>(T args);

    public class DelegateImplementation
    {
        private static DelegateImplementation _FuncDelegate = null;

        public static DelegateImplementation Object
        {
            get
            {
                if (_FuncDelegate == null)
                {
                    _FuncDelegate = new DelegateImplementation();
                }

                return _FuncDelegate;
            }
        }

     

        public void DelegateOutput()
        {
            myDelegate myAddFunction = WorkerClass.Add;

            int sum = myAddFunction(10, 30);

            Console.WriteLine($"By Using Delegate {sum}");

            myGenericDelegate<int> myGenericDelegate = WorkerClass.Sum;

            Console.WriteLine($"By Using  Geniric Delegate {myGenericDelegate(40)}");

        }


        public void FunctionAndActionDelegate()
        { 
            Func<int,int,int> func = WorkerClass.Add;

            Console.WriteLine($"By Using  Func {func(40,30)}");

            //// Gives error
            ////Func<int, int> func1 = WorkerClass.WithOutReturnTypeSum;
            
            Action action = WorkerClass.Nothing;
            action();

            Action<int, int> actionWithOutReturnType = WorkerClass.WithOutReturnTypeSum;
            actionWithOutReturnType(50,30);



        }
    }

    public static class WorkerClass
    {
        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static int Sum(int x)
        {
            return 10 + x;
        }

        public static void Nothing()
        {
            Console.WriteLine($"Action : Method with out any return type");
        }

        public static void WithOutReturnTypeSum(int x , int y)
        {
            Console.WriteLine($"Action : Sum = {x + y}");
        }
    }
}