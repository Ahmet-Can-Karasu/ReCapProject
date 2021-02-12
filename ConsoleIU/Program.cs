using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleIU
{
    class Program
    {
        static void Main(string[] args)
        {
            //BrandTest();
            //ColorTest();
            //CarTest();
            RentalTest();
            UserTest();
            CustomerTest();


        }


       

        private static void RentalTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            var result = rentalManager.Add(new Rental { CarId = 2, CustomerId = 2, 
                RentDate = new DateTime(2021, 2, 12), ReturnDate = null });

            Console.WriteLine(result.Message);
        }

        private static void UserTest()
        {
            UserManager userManager = new UserManager(new EfUserDal());

            var result = userManager.Add(new User { FirstName = "AhmetCan", LastName = "Karasu", 
                Email = "karasu_ahmetcan@hotmail.com", Password = "asdasadda" });
            Console.WriteLine(result.Message);
        }

        private static void CustomerTest()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            var result = customerManager.Add(new Customer { CompanyName = "Karasu A.Ş.", UserId = 2 });
            Console.WriteLine(result.Message);
        }

        private static void BrandTest()
        {
            Console.WriteLine("------------------");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Brand Test");
            Console.ResetColor();
            Console.WriteLine("------------------");

            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var brand in brandManager.GetAll().Data)
            {
                Console.WriteLine(brand.BrandName);
            }
        }

        private static void ColorTest()
        {
            Console.WriteLine("------------------");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Color Test");
            Console.ResetColor();
            Console.WriteLine("------------------");

            ColorManager colorManager = new ColorManager(new EfColorDal());

            foreach (var color in colorManager.GetAll().Data)
            {
                Console.WriteLine(color.ColorName);
            }
        }

        private static void CarTest()
        {
            Console.WriteLine("------------------");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Car Test");
            Console.ResetColor();
            Console.WriteLine("------------------");

            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetCarDetails();
            if (result.Success == true)
            {

                foreach (var car in result.Data)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(car.CarName + " --/-- " + car.BrandName + " --/-- " + car.ColorName + " --/-- " + car.DailyPrice);
                    Console.ResetColor();
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }



            Car car1 = new Car();
            car1.BrandId = 2;
            car1.ColorId = 3;
            car1.DailyPrice = 150;
            car1.Descriptions = "Otomatik , Diesel";

            var result1 = carManager.Add(car1);
            if (result1.Success)
                Console.WriteLine(result1.Message);
            else
                Console.WriteLine(result1.Message);
        }
    }
}
