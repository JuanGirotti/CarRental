using CarRental.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Models
{
    public class Car
    {
        public int Id { get; set; }
        public Brand Brand { get; set; }
        public Model Model { get; set; }
        public byte NumberOfDoors { get; set; }
        public string Color { get; set; }
        public bool IsAutomatic { get; set; }
    }
    
}
