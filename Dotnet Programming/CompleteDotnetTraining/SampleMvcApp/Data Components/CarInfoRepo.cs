using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleMvcApp.Data_Components
{
    public class CarInfoRepo : ICarInfoRepo
    {
        private readonly CarInfoDataContext _context = new CarInfoDataContext();
        public void AddNewCar(CarInfo info)
        {
            _context.CarInfos.InsertOnSubmit(info);
            _context.SubmitChanges();
        }

        public List<CarInfo> GetAllCars() => _context.CarInfos.ToList();

        public CarInfo FindCar(int id) => _context.CarInfos.FirstOrDefault((c) => c.EntryId == id);

        public void UpdateCar(CarInfo carInfo)
        {
            var car = FindCar(carInfo.EntryId);
            Copy(car, carInfo);
            _context.SubmitChanges();
        }

        public void DeleteCar(int entryId)
        {
            var car = FindCar(entryId);
            _context.CarInfos.DeleteOnSubmit(car);
            _context.SubmitChanges();
        }
        private void Copy(CarInfo current, CarInfo other)
        {
            current.BodyType = other.BodyType;
            current.BrandName = other.BrandName;
            current.Capacity = other.Capacity;
            current.Engine = other.Engine;
            current.FuelType = other.FuelType;
            current.Model = other.Model;
            current.Price = other.Price;            
        }
    }
}