using System;
using System.Text;

namespace ConsoleApp.Cars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            Cars cars1 = new Cars();

            cars1.City = "Bakı";
            cars1.Brand = "Mercedes-Benz";
            cars1.Model = "G 63";
            cars1.Year = 2021;
            cars1.BanType = "Offroader / SUV";
            cars1.Color = "Qara";
            cars1.Motor = "4.0 L";
            cars1.MotorPower = 585;
            cars1.FuelType = "Benzin";
            cars1.Kilometer = 6170;
            cars1.GearType = "Avtomat";
            cars1.New = "No";
            cars1.Price = "425.000";


            Cars cars2 = new Cars();

            cars2.City = "Bakı";
            cars2.Brand = "BMW";
            cars2.Model = "M8";
            cars2.Year = 2020;
            cars2.BanType = "Kupe";
            cars2.Color = "Göy";
            cars2.Motor = "4.4 L";
            cars2.MotorPower = 625;
            cars2.FuelType = "Benzin";
            cars2.Kilometer = 2500;
            cars2.GearType = "Avtomat";
            cars2.New = "No";
            cars2.Price = 310250;

            Cars[] cars = new Cars[2];

            cars[0] = cars1;
            cars[1] = cars2;

            foreach (Cars car in cars)
            {
                Console.WriteLine(car.GetInfo());
                Console.WriteLine("--------------------------");
            }

          


        }
    }
}
