using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {

        ICarDal  _carDal;


        public CarManager (ICarDal carDal)
        {
            _carDal = carDal;
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }


        List<Car> ICarService.GetByBrandId()
        {
            throw new NotImplementedException();
        }

        List<Car> ICarService.GetByColorId()
        {
            throw new NotImplementedException();
        }
    }
}
