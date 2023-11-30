using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using System.Linq;

namespace Test01
{
    class Program
    {

        static void Main(string[] args)
        {
            var tech = new TechService();
            var laputa = new UniversalClass
            {
                Id = 4,
                Name = "Meow",
                RowsNumbers = new List<int>
                {
                    1,
                    2,
                    3,
                    4,
                    5,
                }
            };
            string movieJson = JsonConvert.SerializeObject(laputa, Formatting.Indented);
            using (StreamWriter somePlaylist = File.CreateText("Update Hall.json"))
            {
                somePlaylist.Write(movieJson);
            }
            var date = DateTime.Now;
            Console.WriteLine(date);
        }
    }
}
