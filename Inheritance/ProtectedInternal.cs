using System;


namespace Inheritance
{
    class Parts
    {
       protected internal int wheel;
        protected internal string motor;

       protected internal  void DisplayParts()
        {
            Console.WriteLine("wheel:{0},motor:{1}", wheel, motor);

        }
    }
    class ProtectedInternal
    {
    }
}
