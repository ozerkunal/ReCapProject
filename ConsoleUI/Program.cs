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
            //foreach (var car in carmanager.GetAll())
            //{
            //    Console.WriteLine(car.Description);
            //}

            Car eklenecek = new Car();
            eklenecek.BrandId = 3;
            eklenecek.ColorId=5;
            eklenecek.DailyPrice = 0;
            eklenecek.ModelYear = 2015;
            eklenecek.Description = "kkjh";
            carmanager.Add(eklenecek);
            
        }
    }
}
