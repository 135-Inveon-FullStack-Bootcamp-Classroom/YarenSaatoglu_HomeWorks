using OOP.Application.Models;
using OOP.Application.Models.Abstacts;
using System;
using System.Collections.Generic;

namespace OOP.Application
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Celestialbodys List
            List<CelestialBody> celestialBodyList = new List<CelestialBody>();
            //Polimorfizm
            celestialBodyList.Add(new Satellite("AY", "4,53E9 yıl", "Beyaz-Gümüşi", "384.400 km","DÜNYA"));
            celestialBodyList.Add(new Star("VEGA", "4455.300.000 yıl", "Mavi", "25,05 ışık yılı"));
            celestialBodyList.Add(new Satellite("TİTAN", "Bilinmiyor","Turuncu", "1.6 milyar km", "SATÜRN"));
            celestialBodyList.Add(new Planet("JUPİTER", "4,603E9 yıl", "Beyaz-Turuncu-Kahverengi", "588 milyon km", "GÜNEŞ"));
            celestialBodyList.Add(new Satellite("TRİTON", "Bilinmiyor", "Beyaz", "4,338E9 km", "NEPTÜN"));
            celestialBodyList.Add(new Star("SİRİUS", "200 milyon yıl", "Beyaz", "8,611 ışık yılı"));
            celestialBodyList.Add(new Planet("MERKÜR", "4,503E9 yıl", "Koyu Gri", "77 Milyon km","GÜNEŞ"));
            celestialBodyList.Add(new Planet("VENUS", "4,503E9 yıl", "Sarı-Turuncu", "38 milyon km", "GÜNEŞ"));
            celestialBodyList.Add(new Star("GÜNEŞ", "4,603E9 yıl", "Sarı-Turuncu", "149.600.000 km"));
            celestialBodyList.Add(new Planet("MARS", "4,603E9 yıl", "Kızıl-Gümüşi", "225 milyon km", "GÜNEŞ"));
            #endregion

            Console.WriteLine("Uzaya gidiyoruma hoşgeldin!");
            Console.WriteLine("Yapman gereken 1-9 arasında bir rakam girerek yolculuğunu bize bırakmak. Örn:3");
            Console.Write("");
            string selectedCelestialBody = Console.ReadLine();
            int index = Convert.ToInt32(selectedCelestialBody)-1;
            Console.WriteLine("Vay canına şansına çıkan gök cismi : "+ celestialBodyList[index].Name.ToUpper());
            Console.WriteLine(celestialBodyList[index].GetDistanceFromEarth(celestialBodyList[index]));
            Console.WriteLine(celestialBodyList[index].GetInformation(celestialBodyList[index]));
            Console.WriteLine("İyi uçuşlar...");
        }
    }
}
