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
                Id = 1,
                Name = "Tenkuu no Shiro Laputa",
                Description = "Мяв. Альтернативная реальность, соответствующая началу XX века. В руках девочки по имени Сита находится Летающий Камень. За ним охотятся агенты правительства и пираты, потому что Камень представляет огромную ценность. Пытаясь скрыться от преследователей, Сита встречает Падзу, своего ровесника, работающего в шахтерском городке. Вместе дети выясняют, что Камень — ключ к таинственному летающему острову Лапута.",
                Duration = 125,
                GenreIds = new List<int>
                {
                    1,
                    2,
                    3,
                    4,
                    5,
                }
            };
            string movieJson = JsonConvert.SerializeObject(laputa, Formatting.Indented);
            using (StreamWriter somePlaylist = File.CreateText("Some Movie.json"))
            {
                somePlaylist.Write(movieJson);
            }
        }
    }
}
