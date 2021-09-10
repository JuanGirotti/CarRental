using CarRental.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.CRUDS
{
    interface ICarCRUD
    {
        public void Create();
        public void Update(int carId);
        public Car Get();
        public void Delete(int carId);
    }
}
