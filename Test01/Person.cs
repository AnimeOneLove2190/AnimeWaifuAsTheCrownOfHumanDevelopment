using System;
using System.Collections.Generic;
using System.Text;

namespace Test01
{
    class Person
    {
        private string name { get; set; }
        private int age;
        private int weight;
        private int height;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    return;
                }
                name = value;
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine($"Неверный формат возраста у {name}");
                    return;
                }
                age = value;
            }
        }
        public int Weight
        {
            get
            {
                return weight;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine($"Неверный формат веса у {name}");
                    return;
                }
                weight = value;
            }
        }
        public int Height
        {
            get
            {
                return height;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine($"Неверный формат роста у {name}");
                    return;
                }
                height = value;
            }
        }
    }
}
