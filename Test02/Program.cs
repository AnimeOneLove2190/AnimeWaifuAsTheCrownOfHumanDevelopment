using System;
using System.Collections.Generic;
using System.Linq;

namespace Test02Feature531
{
    class Program
    {
        static void Main(string[] args)
        {
            //566
            var phoneCaseOne = new Product
            {
                Name = "Case for phone one",
                Price = 450,
                Category = Categories.PhoneCases
            };
            var phoneCaseTwo = new Product
            {
                Name = "Case for phone two",
                Price = 500,
                Category = Categories.PhoneCases
            };
            var passportCoverOne = new Product
            {
                Name = "Passport Cover one",
                Price = 150,
                Category = Categories.PassportCovers
            };
            var passportCoverTwo = new Product
            {
                Name = "Passport Cover two",
                Price = 200,
                Category = Categories.PassportCovers
            };
            var productListOne = new List<Product>
            {
                phoneCaseOne,
                phoneCaseTwo,
                passportCoverOne,
                passportCoverTwo
            };
            var minPrice = productListOne.Min(x => x.Price);
            var productWithMinPrice = productListOne.FirstOrDefault(x => x.Price == minPrice);
            if (productWithMinPrice == null)
            {
                throw new Exception("Студент с искомым возрастом не найден");
            }
            else
            {
                Console.WriteLine(productWithMinPrice.Name);
                Console.WriteLine(productWithMinPrice.Price);
                Console.WriteLine(productWithMinPrice.Category);
            }
            //569
            var categoryProductList = productListOne.Where(x => x.Category == Categories.PhoneCases).ToList();
            if (categoryProductList == null || categoryProductList.Count == 0)
            {
                throw new Exception("Студенты с искомым возрастом не найдены");
            }
            else
            {
                foreach (var product in categoryProductList)
                {
                    Console.WriteLine(product.Name);
                    Console.WriteLine(product.Price);
                    Console.WriteLine(product.Category);
                }
            }
            //572
            var poroductNamesList = productListOne.Where(x => x.Category == Categories.PassportCovers).Select(x => x.Name).ToList();
            if (poroductNamesList == null || poroductNamesList.Count == 0)
            {
                throw new Exception("Студенты с искомым возрастом не найдены");
            }
            else
            {
                foreach (var name in poroductNamesList)
                {
                    Console.WriteLine(name);
                }
            }
            //573
            var productNamesWithPriceHigher = productListOne.Where(x => x.Price > 470).Select(x => x.Name).ToList();
            if (productNamesWithPriceHigher == null || productNamesWithPriceHigher.Count == 0)
            {
                throw new Exception("Студенты с искомым возрастом не найдены");
            }
            else
            {
                foreach (var name in productNamesWithPriceHigher)
                {
                    Console.WriteLine(name);
                }
            }
        }
    }
}
