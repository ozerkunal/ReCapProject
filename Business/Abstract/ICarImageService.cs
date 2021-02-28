using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarImageService
    {
        IDataResult<List<CarImage>> GetAll();
        IResult Add(CarImage carimage);
        IResult Update(CarImage carimage);
        IResult Delete(CarImage carimage);
        IDataResult<CarImage> GetById(int Id);
    }
}
