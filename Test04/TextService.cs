using System;
using System.Collections.Generic;
using System.Text;

namespace Test04
{
    class TextService
    {
        public TextFile ConnectedTextFile(TextFile personOne, TextFile personTwo)
        {
            TextFile connectedTextFile = new TextFile
            {
                name = $"{personOne.name}. {personTwo.name}",
                description = $"{personOne.description} {personTwo.description}",
                weight = personOne.weight + personTwo.weight,
            };
            return connectedTextFile;
        }
        public void AddedTextFile(TextFile person, string meow)
        {
            TextFile addedTextFile = new TextFile
            {
                description = $"{person.description} {meow}"
            };
            Console.WriteLine(addedTextFile.description);
        }
    }
}
