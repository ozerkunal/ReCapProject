using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarImageService
    {
        IDataResult<List<CarImage>> GetAll();
        IResult Add(IFormFile file, CarImage carimage);
        IResult Update(IFormFile file, CarImage carimage);
        IResult Delete(CarImage carimage);
        IDataResult<List<CarImage>> GetImagesByCarId(int id);
        IDataResult<CarImage> Get(int id);
    }
}
