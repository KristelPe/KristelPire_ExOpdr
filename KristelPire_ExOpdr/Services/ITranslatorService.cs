using KristelPire_ExOpdr.Entities;
using KristelPire_ExOpdr.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KristelPire_ExOpdr.Services
{
    public interface ITranslatorService
    {
        CarDetailViewModel ConvertCar(Car car);
        CarEditDetailViewModel ConvertEditCar(Car car);
        OwnerDetailViewModel ConvertOwner(Owner owner);
        TypeDetailViewModel ConvertType(CarType type);
    }
}
