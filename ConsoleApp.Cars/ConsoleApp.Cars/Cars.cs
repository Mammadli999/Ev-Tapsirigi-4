using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Cars
{
    internal class Cars
    {
        public string City;
        public string Brand;
        public string Model;
        public int Year;
        public string BanType;
        public string Color;
        public string Motor;
        public int MotorPower;
        public string FuelType;
        public int Kilometer;
        public string GearType;
        public string New;
        public string Price;


        public string GetInfo() 
        {
            string outpout = $"{City}\n" +
                $"{Brand}\n" +
                $"{Model}\n" +
                $"{Year}\n" +
                $"{BanType}\n" +
                $"{Color}\n" +
                $"{Motor}\n" +
                $"{MotorPower}\n" +
                $"{Kilometer}\n" +
                $"{GearType}\n" +
                $"{New}\n" +
                $"{Price}₼";

            return outpout;

        }





    }
}
