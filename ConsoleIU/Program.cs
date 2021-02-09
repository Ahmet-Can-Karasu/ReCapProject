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
            CarManager carManager = new CarManager(new EfCarDal());

            carManager.Add(new Car { DailyPrice = 250 });


            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine( car.DailyPrice);
            }

            BrandManager brandManager = new BrandManager(new EfBrandDal());

            brandManager.Add(new Brand { BrandName = "Audi" });


            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.BrandName);
            }



        }
    }
}
