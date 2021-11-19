using OOP.Application.Models.Abstacts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Application.Models
{
    //Yıldız sınıfı base sınıf olan Gökcismi(CelestialBody) inherit eder.
    public class Star : CelestialBody
    {
        public Star(string name, string age, string color, string distanceFromEarth) : base()
        {
            base.Name = name;
            base.Age = age;
            base.Color = color;
            base.DistanceFromEarth = distanceFromEarth;
        }
        public override string GetDistanceFromEarth(CelestialBody celestialBody)
        {
            string message = celestialBody.Name + " yıldızının Dünya' ya olan uzaklığı " + celestialBody.DistanceFromEarth.ToString();
            return message;
        }

        public override string GetInformation(CelestialBody celestialBody)
        {
            string message = celestialBody.Name + " yıldızı hakkında bilmen gerekenler : Yıldızın yaşı= " + celestialBody.Age + " | Yıldızın rengi= " + celestialBody.Color;
            return message;
        }
    }
}
