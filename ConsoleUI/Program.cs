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

            //BrandTest();

            //ColorTest();

            //UserAddTest();

            //CustomerAddTest();

            RentalAddTest();

        }

        private static void RentalAddTest()
        {
            RentalManager rental = new RentalManager(new EfRentalDal());

            rental.Add(new Rental { CarId = 4, CustomerId = 5, RentDate = DateTime.Now, ReturnDate = null });

            foreach (var rentals in rental.GetAll().Data)
            {
                Console.WriteLine("{0},{1},{2},{3}", rentals.RentalId, rentals.CarId, rentals.CustomerId, rentals.RentDate);
            }


        }

        private static void CustomerAddTest()
        {
            CustomerManager customer = new CustomerManager(new EfCustomerDal());
            customer.Add(new Customer { UserId = 7, CompanyName = "Yıldız Hg" });

            foreach (var customers in customer.GetAll().Data)
            {
                Console.WriteLine(customers.UserId + "/" + customers.CompanyName);
            }
        }

        private static void UserAddTest()
        {
            UserManager user = new UserManager(new EfUserDal());

            user.Add(new User { FirstName = "Fatih", LastName = "Erkoç", Email = "fatiher@gmail.com", Password = "1234" });

            foreach (var users in user.GetAll().Data)
            {
                Console.WriteLine("{0},{1},{2},{3},{4}", users.UserId, users.FirstName, users.LastName, users.Email, users.Password);
            }
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
                Console.WriteLine(brands.BrandId = 5);
            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetCarDetails().Data)
            {
                Console.WriteLine("{0} / {1} / {2}", car.CarName, car.DailyPrice, car.ColorName);
            }
        }
    }
}
