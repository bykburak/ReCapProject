using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {

        List<Car> _cars;
        List<Brand> _brand;
        List<Color> _color;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{ CarId= 1, BrandId = 1,ColorId = 2, DailyPrice= 40000, Description="Otomatik Dizel", ModelYear= 2016},
                new Car{ CarId= 2, BrandId = 3,ColorId = 1, DailyPrice= 100000, Description="Düz vites Benzin", ModelYear= 2019},
                new Car{ CarId= 3, BrandId = 4,ColorId = 2, DailyPrice= 450000, Description="Otomatik vites Benzin", ModelYear= 2021},
                new Car{ CarId= 4, BrandId = 2,ColorId = 4, DailyPrice= 30000, Description="Otomatik Dizel", ModelYear= 2014},
                new Car{ CarId= 5, BrandId = 1,ColorId = 3, DailyPrice= 75000, Description="Düz vites Dizel + Gaz", ModelYear= 2018}
            };

            _brand = new List<Brand>
            {
                new Brand{ BrandId= 1, BrandName = "BMW"},
                new Brand{ BrandId= 2, BrandName = "Mercedes"},
                new Brand{ BrandId= 3, BrandName = "Audi"},
                new Brand{ BrandId= 4, BrandName = "Volvo"}
            };

            _color = new List<Color>
            {
                new Color{ ColorId= 1, ColorName = "Siyah"},
                new Color{ ColorId= 2, ColorName = "Kırmızı"},
                new Color{ ColorId= 3, ColorName = "Beyaz"},
                new Color{ ColorId= 4, ColorName = "Mavi"}
            };


        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car CarToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(CarToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetByColorId(int colorId)
        {
            return _cars.Where(c => c.ColorId == colorId).ToList();
        }

        public List<Car> GetByBrandId(int brandId)
        {
            return _cars.Where(c => c.BrandId == brandId).ToList();
        }

        public void Update(Car car)
        {
            Car CartoUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);

            CartoUpdate.BrandId = car.BrandId;
            CartoUpdate.ColorId = car.ColorId;
            CartoUpdate.DailyPrice= car.DailyPrice;
            CartoUpdate.Description= car.Description;
            CartoUpdate.ModelYear= car.ModelYear;

        }
    }
}
