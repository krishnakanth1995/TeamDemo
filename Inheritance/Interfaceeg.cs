using System;


namespace Inheritance
{
    interface INormalCalculator
    {
        int Add(int a, int b); // interface by default methods abstract,public 
        string CalciName();
    }

    class Compute : INormalCalculator,IScientificCalculator
    {
        internal string Getname()
        {
            return "Compute";

        }
        public int Add(int a, int b)
        {
            return a + b;
        }

        string INormalCalculator.CalciName()
        {
            return "INormalCalculator";
        }

        string IScientificCalculator.CalciName()
        {
            return " IScientificCalculator";
        }
    }
    class Interfaceeg
    {
        static void Main()
        {
            Compute compute = new Compute();
           
            Console.WriteLine(" Result:{0}", compute.Add(30, 50));
            Console.WriteLine(" Class Name is :{0}", compute.Getname());

            INormalCalculator r = new Compute();
            Console.WriteLine(r.CalciName());

            IScientificCalculator s = new Compute();
            Console.WriteLine(s.CalciName());



            Console.Read();
        }
        

        

    }
}
