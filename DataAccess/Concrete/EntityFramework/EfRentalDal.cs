using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental,CarRentalContext>,IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails()
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                var result = from r in context.Rentals
                             join c in context.Cars on r.CarId equals c.Id
                             join u in context.Users on r.CustomerId equals u.Id
                             join b in context.Brands on c.BrandId equals b.Id
                             select new RentalDetailDto {CarName=b.Name, CarDescription=c.Description, CustomerName=u.FirstName+" "+u.LastName, RentalDate=r.RentDate, ReturnDate=r.ReturnDate, UnitPrice=c.DailyPrice};
                return result.ToList();
            }
        }
    }
}
