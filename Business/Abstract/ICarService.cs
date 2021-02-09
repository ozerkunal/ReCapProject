﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        void Add(Car entity);
        void Update(Car entity);
        void Delete(Car entity);
        List<Car> GetCarsByBrandId(int Id);
        List<Car> GetCarsByColorId(int Id);
    }
}
