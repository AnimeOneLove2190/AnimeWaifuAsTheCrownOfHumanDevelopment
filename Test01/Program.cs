using System;
using System.Collections.Generic;

namespace Test01
{
    class Program
    {
        static void Main(string[] args)
        {
            Helicopter helicopter = new Helicopter();
            helicopter.Owner = "Ростех";
            helicopter.Speed = 250;
            helicopter.Carrying = 4000;
            Console.WriteLine(helicopter.GetInfo());
            Car hayachi = new Car();
            hayachi.Owner = "Давлетшин Даниил";
            hayachi.Speed = 111;
            hayachi.Сonsumption = 6;
            Console.WriteLine(hayachi.GetInfo());
            Boat meteor = new Boat();
            meteor.Owner = "Зеленодольский завод имени А. М.Горького";
            meteor.Speed = 77;
            meteor.Displacement = 53;
            Console.WriteLine(meteor.GetInfo());
        }
    }
}
