using System;
namespace Vehicles

{
    class Program
    {
       public static void Main(string[] args) 
        {
            Vehicle V1 = new Vehicle();
            Car c1 = new Car();
            c1.Manufacturer = "Honda";
            c1.Model = "BR-v";
            c1.Type = "SUV";
            c1.colour = "Burgundy";
            Console.WriteLine(c1.GetDeatils());





        }


    }

}