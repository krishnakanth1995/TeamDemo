using System;


namespace Inheritance
{
    class Car:Parts
    {
        static void Main()
        {
            Car car = new Car();
            car.wheel = 10;
            car.motor = " v10";
            car.DisplayParts();
        }
    }
}
