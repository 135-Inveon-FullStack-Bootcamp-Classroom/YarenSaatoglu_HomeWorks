using OOP.Application.Models.Abstacts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Application.Models
{
    //Gezegen sınıfı base sınıf olan Gökcismi(CelestialBody) inherit eder.
    class Planet: CelestialBody
    {
        //Etrafında döndüğü yıldız adı
        public string StarName { get; set; }
        public Planet(string name, string age, string color, string distanceFromEarth, string starName) : base()
        {
            base.Name = name;
            base.Age = age;
            base.Color = color;
            base.DistanceFromEarth = distanceFromEarth;
            this.StarName = starName;
        }
        public override string GetDistanceFromEarth(CelestialBody celestialBody)
        {
            string message = celestialBody.Name + " gezegeninin Dünya' ya olan uzaklığı " + celestialBody.DistanceFromEarth.ToString();
            return message;
        }

        public override string GetInformation(CelestialBody celestialBody)
        {
            string message = celestialBody.Name + " gezegeni hakkında bilmen gerekenler : Gezegenin yaşı= " + celestialBody.Age + " | Hangi yıldızın etrafında dönüyor= " + StarName
                + " | Gezegenin rengi= " + celestialBody.Color;
            return message;
        }
    }
}
