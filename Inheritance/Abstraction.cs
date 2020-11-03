using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    abstract class RBI
    {
        int empno = 20;
        public abstract int Homeloan();
        public abstract int Educationalloan();
        // non abstract method 
        internal void RBIEmployee()
        {
            Console.WriteLine("RBI Employee details:{0}", empno);
        }

    }
     class SBI: RBI
    {
        public override int Homeloan()
        {
            return 9;
        }

        public override int Educationalloan()
        {
            return 10;
        }
    }

    class HDFC:RBI
    {
        public override int Homeloan()
        {
            return 8;
        }

        public override int Educationalloan()
        {
            return 12;
        }
    }
        

    class Abstraction
    {
        static void Main()
        {
            // cannot create object for abstract class ie RBI class 
            // to access non abstarct methods in abstract class. either of child class object 
            // can be used.

            /*SBI sbi = new SBI();
            sbi.RBIEmployee();
            
            Console.WriteLine(" SBI HOMELOAN:{0}", sbi.Homeloan());
            Console.WriteLine(" SBI EDUCATIONALLOAN:{0}", sbi.Educationalloan());
           
            HDFC hdfc = new HDFC();
            Console.WriteLine(" HDFC HOMELOAN:{0}", hdfc.Educationalloan());
            Console.WriteLine(" HDFC EDUCATIONALLOAN:{0}", hdfc.Educationalloan());
            Console.Read();*/

            // Runtime polymorphism
            RBI r; // reference creation for RBI
            // creation of object for SBI
            r = new SBI();
            r.RBIEmployee();
            Console.WriteLine(" SBI HOMELOAN:{0}", r.Homeloan());
            Console.WriteLine(" SBI EDUCATIONALLOAN:{0}", r.Educationalloan());

            r = new HDFC();
            Console.WriteLine(" HDFC HOMELOAN:{0}", r.Homeloan());
            Console.WriteLine(" HDFC EDUCATIONALLOAN:{0}", r.Educationalloan());
            Console.WriteLine("Changes made ");

            Console.Read();

            // in runtime polymorphism reference created for RBI (r), 
            //refers object created for SBI first and same reference refers object created for 
            // HDFC so, unwanted memory creation unlike two object creation can be eliminated.

        }
        
    }
}
