using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KristelPire_ExOpdr.Entities;

namespace KristelPire_ExOpdr.Services
{
    public interface ICarService
    {
        List<Car> GetAllCars();
        Car GetCarById(int id);
        List<Owner> GetAllOwners();
        Owner GetOwnerById(int? id);
        List<CarType> GetAllTypes();
        CarType GetTypeById(int id);
        void Persist(Car car);
        void Delete(int id);
    }
}
