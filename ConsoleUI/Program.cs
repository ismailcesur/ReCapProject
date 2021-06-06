using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
           //CarTest();

            BrandTest();

            //ColorTest();

        }

        private static void ColorTest()
        {
            ColorManager color = new ColorManager(new EfColorDal());

            foreach (var colors in color.GetAll())
            {
                Console.WriteLine(colors.ColorName);
            }
        }

        private static void BrandTest()
        {
            BrandManager brand = new BrandManager(new EfBrandDal());


            foreach (var brands in brand.GetAll())
            {
                Console.WriteLine(brands.BrandId=5);
            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine("{0} / {1} / {2}",  car.CarName, car.DailyPrice, car.ColorName);
            }
        }
    }
}
