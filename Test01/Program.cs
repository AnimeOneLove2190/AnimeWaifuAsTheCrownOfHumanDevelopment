using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Test01
{
    class Program
    {

        static void Main(string[] args)
        {
            var tech = new TechService();
            var f = "зубенко";
            var i = "михаил";
            var o = "петрович";
            char[] surnameArray = f.ToCharArray();
            surnameArray[0] = char.ToUpper(surnameArray[0]);
            f = new string(surnameArray);
            Console.WriteLine($"{f} {char.ToUpper(i[0])}. {char.ToUpper(o[0])}.");
        }
    }
}
