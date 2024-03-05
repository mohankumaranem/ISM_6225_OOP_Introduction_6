using System;
namespace Vehicles
{
    class Car:Vehicle
    {
        public string Model;
        public string Type;
        public string Fuel;
        public string colour;
        public DateTime YearofRegistar;
        public int Numofowners;

        public string GetDeatils() { 
            return  Manufacturer+"\n"+Model+"\n"+Type+"\n"+Fuel;
        }




         


    }
}

