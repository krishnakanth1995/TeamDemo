using System;


namespace Inheritance
{
    class Organisation // Parent class 
    {
        protected String Orgname = " LTI";
        protected string location;
        protected void DisplayOrg()
        {
            Console.WriteLine(" Orgname:{0},location{1}", Orgname, location);

        }
    }
    
        class Employee : Organisation// Here employee class is child class of organisation
    {
        int Eid = 1001;
        float salaryperhr = 20.5f;


        void DisplayEmp()
        {
            Console.WriteLine(" Eid:{0},Ename{1},Orgname{2}", Eid, salaryperhr, Orgname);
        }

        static void Main()
        {
            Employee employee = new Employee();
            // accessing parent class details through child class
            // non static information from parent class can be accessed through child class object, when protected is given 
            employee.location = " Hyderabad";
            employee.DisplayOrg();
            employee.DisplayEmp();

            Console.Read();
        }




        }  
    

    class SingleInheritance
    {
    }
}
