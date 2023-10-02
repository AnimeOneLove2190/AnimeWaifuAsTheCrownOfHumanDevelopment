using System;
using System.Collections.Generic;
using System.Text;

namespace Test01
{
    class TechService
    {
        public string GetDuration(int techDuration)
        {
            string duration = string.Empty;
            if (techDuration <= 0)
            {
                duration = "00 : 00";
            }
            int countOfMinutes = techDuration / 60;
            int countOfSeconds = techDuration % 60;
            int countOfHours = countOfMinutes / 60;
            int hasOneTen = countOfSeconds / 10;
            if (countOfHours == 0)
            {
                if (hasOneTen > 0)
                {
                    duration = $"{countOfMinutes} : {countOfSeconds}";
                }
                else
                {
                    duration = $"{countOfMinutes} : 0{countOfSeconds}";
                }
            }
            if (countOfHours > 0)
            {
                if (hasOneTen > 0)
                {
                    duration = $"{countOfHours} : {countOfMinutes} : {countOfSeconds}";
                }
                else
                {
                    duration = $"{countOfHours} : {countOfMinutes} : 0{countOfSeconds}";
                }
            }
            return duration;
        }
        public void Write1DArray(string array)
        {
            if (array == null || array.Length == 0)
            {
                Console.WriteLine("Пустой массив в Write1DArray");
                return;
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
            }
        }
        public string GetSubstring(string text, int firstLetter, int lastLetter)
        {
            if (string.IsNullOrEmpty(text) || string.IsNullOrWhiteSpace(text))
            {
                Console.WriteLine("Сработала защита в GetSubstring");
                return null;
            }
            if (firstLetter < 0 || lastLetter > text.Length)
            {
                Console.WriteLine("Указанная длина подстроки превышает длину исходной строки");
                return null;
            }
            var substring = string.Empty;
            for (int i = 0, j = firstLetter; i <= lastLetter - 1; i++, j++)
            {
                if (j <= text.Length - 1)
                {
                    substring = $"{substring}{text[j]}";
                }
                else
                {
                    Console.WriteLine("Искомый элемент подстроки вышел за границу исходной строки");
                    break;
                }
            }
            return substring;
        }
    }
}

