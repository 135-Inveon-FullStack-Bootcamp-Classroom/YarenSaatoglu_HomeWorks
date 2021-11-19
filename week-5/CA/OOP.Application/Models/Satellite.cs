using OOP.Application.Models.Abstacts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Application.Models
{
    //Uydu sınıfı base sınıf olan Gökcismi(CelestialBody) inherit eder.
    class Satellite : CelestialBody
    {
        //Bağlı olduğu gezegen adı
        public string PlanetName { get; set; }
        public Satellite(string name, string age, string color, string distanceFromEarth, string planetName) : base()
        {
            this.Name = name;
            this.Age = age;
            this.Color = color;
            this.DistanceFromEarth = distanceFromEarth;
            this.PlanetName = planetName;
        }
        public override string GetDistanceFromEarth(CelestialBody celestialBody)
        {
            string message = celestialBody.Name+ " uydusunun Dünya' ya olan uzaklığı " + celestialBody.DistanceFromEarth.ToString();
            return message;
        }

        public override string GetInformation(CelestialBody celestialBody)
        {
            string message = celestialBody.Name+" uydusu hakkında bilmen gerekenler : Uydunun yaşı= "+celestialBody.Age+ " | Hangi gezegenin uydusu= "+PlanetName
                +" | Uydunun rengi= "+ celestialBody.Color;
            return message;
        }
    }
}
