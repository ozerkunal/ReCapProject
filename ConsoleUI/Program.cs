using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carmanager = new CarManager(new EfCarDal());
            foreach (var car in carmanager.GetCarDetails())
            {
                Console.WriteLine(car.CarName+" "+car.BrandName+" "+car.ColorName+" "+car.DailyPrice);
            }


        }
    }
}
