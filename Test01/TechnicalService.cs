using System;
using System.Collections.Generic;
using System.Text;

namespace Test01
{
    class TechnicalService
    {
        Genre genre = new Genre();
        public void WriteList(List<string> list)
        {
            if (list == null || list.Count == 0)
            {
                Console.WriteLine("Сработала защита в WriteList");
                return;
            }
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
        public void WriteGenres(List<Genre> list)
        {
            if (list == null || list.Count == 0)
            {
                Console.WriteLine("Сработала защита в WriteList");
                return;
            }
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == Genre.anime)
                {
                    Console.Write("anime, ");
                }
                if (list[i] == Genre.multfilm)
                {
                    Console.Write("multfilm, ");
                }
                if (list[i] == Genre.fantastic)
                {
                    Console.Write("fantastic, ");
                }
                if (list[i] == Genre.adventure)
                {
                    Console.Write("adventure, ");
                }
                if (list[i] == Genre.family)
                {
                    Console.Write("family, ");
                }
                if (list[i] == Genre.melodrama)
                {
                    Console.Write("melodrama, ");
                }
                if (list[i] == Genre.drama)
                {
                    Console.Write("drama, ");
                }
                if (list[i] == Genre.action)
                {
                    Console.Write("action, ");
                }
                if (list[i] == Genre.fantasy)
                {
                    Console.Write("fantasy, ");
                }
                if (list[i] == Genre.darkFantasy)
                {
                    Console.Write("dark fantasy, ");
                }
                if (list[i] == Genre.postApocalyptic)
                {
                    Console.Write("post-apocalyptic, ");
                }
                if (list[i] == Genre.cruelty)
                {
                    Console.Write("cruelty, ");
                }
            }
            Console.WriteLine();
        }
        public void WriteList(List<Movie> list)
        {
            if (list == null || list.Count == 0)
            {
                Console.WriteLine("Сработала защита в WriteList");
                return;
            }
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"Name: {list[i].Name}");
                Console.Write("Genre: ");
                WriteGenres(list[i].Genres);
                Console.WriteLine($"Duration: {list[i].Duration}");
                Console.WriteLine($"Age limit: {list[i].AgeLimit}");
                Console.WriteLine($"Production year: {list[i].ProductionYear}");
                Console.WriteLine($"Country: {list[i].Country}");
                Console.WriteLine($"World premiere date: {list[i].PremiereDate}");
                Console.WriteLine("мяв");
            }
        }
        public void WriteMovie(Movie movie)
        {
            if (movie == null)
            {
                Console.WriteLine("Сработала защита в WriteList");
                return;
            }
            Console.WriteLine($"Name: {movie.Name}");
            Console.Write("Genre: ");
            WriteGenres(movie.Genres);
            Console.WriteLine($"Duration: {movie.Duration}");
            Console.WriteLine($"Age limit: {movie.AgeLimit}");
            Console.WriteLine($"Production year: {movie.ProductionYear}");
            Console.WriteLine($"Country: {movie.Country}");
            Console.WriteLine($"World premiere date: {movie.PremiereDate}");
        }
        public void BubbleSort(char[] charArray)
        {
            for (int i = 0; i < charArray.Length; i++)
            {
                for (int j = 0; j < charArray.Length - i - 1; j++)
                {
                    if (charArray[j] > charArray[j + 1])
                    {
                        int temporaryStorage = charArray[j];
                        charArray[j] = charArray[j + 1];
                        charArray[j + 1] = (char)temporaryStorage;
                    }
                }
            }
        }
        public void BubbleSort(int[] numberArray)
        {
            for (int i = 0; i < numberArray.Length; i++)
            {
                for (int j = 0; j < numberArray.Length - i - 1; j++)
                {
                    if (numberArray[j] > numberArray[j + 1])
                    {
                        int temporaryStorage = numberArray[j];
                        numberArray[j] = numberArray[j + 1];
                        numberArray[j + 1] = temporaryStorage;
                    }
                }
            }
        }
        public void BubbleSort(DateTime[] dateArray)
        {
            for (int i = 0; i < dateArray.Length; i++)
            {
                for (int j = 0; j < dateArray.Length - i - 1; j++)
                {
                    if (dateArray[j] > dateArray[j + 1])
                    {
                        DateTime temporaryStorage = dateArray[j];
                        dateArray[j] = dateArray[j + 1];
                        dateArray[j + 1] = temporaryStorage;
                    }
                }
            }
        }
    }
}

