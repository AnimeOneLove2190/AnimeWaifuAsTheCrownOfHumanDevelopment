using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Test01
{
    class Program
    {
        public static object JsonConvert { get; private set; }

        static void Main(string[] args)
        {
            var nagatoro = new Person
            {
                Name = "Nagatoro",
                Hobbies = new List<string>()
            };
            nagatoro.Hobbies.Add("Cats");
            nagatoro.Hobbies.Add("Judo");
            nagatoro.Hobbies.Add("Bullying Hachioji");
            using(StreamWriter file = File.CreateText("Nagatoro.txt"))
            {
                file.Write("Hayachi Nagatoro");
            }
            var text = string.Empty;
            using(StreamReader read = File.OpenText("Nagatoro.txt"))
            {
                text = read.ReadToEnd();
            }
            Console.WriteLine(text);
            string json = JsonConvert.SerializeObject(nagatoro, Formatting.Indented);
            //крч эта хуйня не работает
        }
    }
}
