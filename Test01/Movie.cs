using System;
using System.Collections.Generic;
using System.Text;

namespace Test01
{
    class Movie
    {
        private string name;
        private int id;
        private List<Genre> genres;
        private int duration;
        private int ageLimit;
        private int productionYear;
        private string country;
        private DateTime premiereDate;
        public Movie()
        {

        }
        readonly DateTime birthOfJesus = new DateTime(1, 1, 1);
        public Movie(string name, int id, List<Genre> genres, int duration, int ageLimit, int productionYear, string country, DateTime premiereDate)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("А хде название, йобана в рот?");
                return;
            }
            this.name = name;
            if (id < 0)
            {
                Console.WriteLine($"Неверный формат id у {name}");
                return;
            }
            this.id = id;
            if (genres == null || genres.Count == 0)
            {
                Console.WriteLine($"Неверный формат жанра у {name}");
                return;
            }
            this.genres = genres;
            if (duration < 0)
            {
                Console.WriteLine($"Неверный формат длительности у {name}");
                return;
            }
            this.duration = duration;
            if (ageLimit < 0)
            {
                Console.WriteLine($"Неверный формат возрастного ограничения у {name}");
                return;
            }
            this.ageLimit = ageLimit;
            if (productionYear < 0)
            {
                Console.WriteLine($"Неверный формат года производства у {name}");
                return;
            }
            this.productionYear = productionYear;
            if (string.IsNullOrEmpty(country) || string.IsNullOrWhiteSpace(country))
            {
                Console.WriteLine($"Неверный формат страны у {name}");
                return;
            }
            this.country = country;
            if (premiereDate < birthOfJesus)
            {
                Console.WriteLine($"Неверный формат даты премьеры у {name}");
                return;
            }
            this.premiereDate = premiereDate;
        }
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
                    Console.WriteLine("А хде название, йобана в рот?");
                    return; 
                }
                name = value;
            }
        }
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine($"Неверный формат id у {name}");
                    return;
                }
                id = value;
            }
        }
        public List<Genre> Genres
        {
            get
            {
                return genres;
            }
            set
            {
                if (value == null || value.Count == 0)
                {
                    Console.WriteLine($"Неверный формат жанра у {name}");
                    return;
                }
                genres = value;
            }
        }
        public int Duration
        {
            get
            {
                return duration;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine($"Неверный формат длительности у {name}");
                    return;
                }
                duration = value;
            }
        }
        public int AgeLimit
        {
            get
            {
                return ageLimit;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine($"Неверный формат возрастного ограничения у {name}");
                    return;
                }
                ageLimit = value;
            }
        }
        public int ProductionYear
        {
            get
            {
                return productionYear;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine($"Неверный формат года производства у {name}");
                    return;
                }
                productionYear = value;
            }
        }
        public string Country
        {
            get
            {
                return country;
            }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine($"Неверный формат страны у {name}");
                    return;
                }
                country = value;
            }
        }
        public DateTime PremiereDate
        {
            get
            {
                return premiereDate;
            }
            set
            {
                if (value < birthOfJesus)
                {
                    Console.WriteLine($"Неверный формат даты премьеры у {name}");
                    return;
                }
                premiereDate = value;
            }
        }
    }
}
