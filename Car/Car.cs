using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Car
{
    class Car
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Models { get; set; }
        public int NumOfDoors { get; set; }
        public string Color { get; set; }
        public string Transmission { get; set; }
    }
    public enum Brand
    {
        Fiat=1, Ford=2, Chevrolet=3, Peugeot=4, Renault=5, Volkswagen=6
    }
    public enum Model
    {
        Uno=1, Focus=2, Corsa=3, Partner=4, Clio=5, Gol=6
    }
    public enum NumOfDoors
    {
        ThreeDoors=1, FiveDoors=2
    }
    public enum Color
    {
        White=1, Black=2, Grey=3, Blue=4, Red=5
    }
    public enum Transmission
    {
        Automatic=1, Manual=2
    }
}
