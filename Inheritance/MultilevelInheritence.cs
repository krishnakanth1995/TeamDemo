using System;


namespace Inheritance
{
    class College
    {
        protected string collegename;
        protected string id = " C101";

        internal College(string collegename)
        {
            this.collegename = collegename;
            Console.WriteLine("College constructor");
        }

       protected  void GetcollegeDetails()
        {
            Console.WriteLine(" college:name{0}", collegename);
        }
        ~College()
        {
            Console.WriteLine(" student destructor");
        }

    }

    class Department: College
        
    {
        protected string Dept;
        protected string id = " D1010";
        internal Department (string collegename,string Dept): base (collegename)
        {
            this.Dept = Dept;
            Console.WriteLine("Department constructor");
        }

       protected  void GetDepartmentDetails()
        {
            Console.WriteLine(" college id: {0},deptid : {1}", base.id, id);
            Console.WriteLine(" collegename:{0},deptname:{1}", collegename, Dept);
        }

        ~Department()
        {
            Console.WriteLine(" student destructor");
        }

    }


    
    class Student: Department
    {
         string studentname;

        Student(string collegename, string Dept,string studentname):base (collegename,Dept)
        {
            this.studentname = studentname;
            Console.WriteLine("Student constructor");
        }
        
        void GetstudentDetails()
        {
            Console.WriteLine("Collegename:{0},deptname:{1},studentname:{2}", collegename, Dept, studentname);
        }

        static void Main()
        {
            Student student = new Student("JNTUK","PE","Tyni");
            student.GetcollegeDetails();
            student.GetDepartmentDetails();
            student.GetstudentDetails();
            GC.Collect();

            Console.Read();

        }
   
         ~Student()
        {
            Console.WriteLine(" student destructor");
        }
    
    
    }


        

        
    
    class MultilevelInheritence
    {
    }
}
