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
            //RentalManager rentalManager = new RentalManager(new EfRentalDal());
            //foreach (var rental in rentalManager.GetRentalDetails().Data)
            //{
            //    Console.WriteLine(rental.CarName + " " + rental.CarDescription + " " + rental.CustomerName + " " + rental.RentalDate + " " + rental.ReturnDate + " " + rental.UnitPrice);
            //}
            //Console.WriteLine(rentalManager.GetRentalDetails().Message);

            //AddUser();

            //AddCustomer();

            AddRental();


        }

        private static void AddRental()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            Rental rentaltoadd = new Rental()
            {
                CarId = 7,
                CustomerId = 1,
                RentDate = DateTime.Now,
                ReturnDate = Convert.ToDateTime("10/02/2021")
            };
            var result = rentalManager.Add(rentaltoadd);
            Console.WriteLine(result.Message);
        }

        private static void AddCustomer()
        {
            CustomerManager customermanager = new CustomerManager(new EfCustomerDal());
            Customer customertoadd = new Customer()
            {
                UserId = 1,
                CompanyName = "Ünal Şirketler Grubu",
            };
            var result = customermanager.Add(customertoadd);
            Console.WriteLine(result.Message);
        }

        private static void AddUser()
        {
            UserManager usermanager = new UserManager(new EfUserDal());
            User usertoadd = new User()
            {
                FirstName = "Özer",
                LastName = "Ünal",
                Email = "ozer@unal-group.com",
                Password = "pass1",
            };
            var result = usermanager.Add(usertoadd);
            Console.WriteLine(result.Message);
        }
    }
}
