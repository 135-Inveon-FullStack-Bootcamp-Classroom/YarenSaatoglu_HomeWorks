using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Application.Models.Abstacts
{
    public abstract class CelestialBody
    {

        //GökCismi adı
        public string Name { get; set; }
        //Gökcismi Rengi
        public string Color { get; set; }
        //Gökcismi yaşı
        public string Age { get; set; }
        //Gökcismi Dünyaya uzaklığı
        public string DistanceFromEarth { get; set; }

        public abstract string GetDistanceFromEarth(CelestialBody celestialBody);
        public abstract string GetInformation(CelestialBody celestialBody);

    }
}
