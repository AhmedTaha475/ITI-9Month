using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using static D10_SD43_Task.ListGenerators;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace D10_SD43_Task
{   
   
    internal class Program
    {
        public static int ConvertStringToInt(string str)
        {
            switch (str)
            {
                case "zero":
                    return 0;
                    break;
                case "one":
                    return 1;
                    break;
                case "two":
                    return 2;
                    break;
                case "three":
                    return 3;
                    break;
                case "four":
                    return 4;
                    break;
                case "five":
                    return 5;
                    break;
                case "six":
                    return 6;
                    break;
                case "seven":
                    return 7;
                    break;
                case "eight":
                    return 8;
                    break;
                case "nine":
                    return 9;
                    break;

            }
            return 0;
        }
        static void Main(string[] args)
        {
            #region 1-Restriction Operator defered execution

            //1-Find all products that are out of stock

            //var result1 = ProductList.Where(p => p.UnitsInStock == 0);
            //var result2 = from p in ProductList
            //              where p.UnitsInStock == 0
            //              select p;


            //foreach (var result in result1)
            //{
            //    Console.WriteLine(result);
            //}

            //Console.WriteLine("================================");
            //foreach (var item in result2)
            //{
            //    Console.WriteLine(item);
            //}

            //2- Find all products that are in stock and cost more than 3.00 per unit.
            //var result1 = ProductList.Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3.00M);
            //var result2= from p in ProductList
            //             where p.UnitsInStock>0 && p.UnitPrice>3.00M
            //             select p;


            //foreach (var result in result1)
            //{
            //    Console.WriteLine(result);
            //}

            //Console.WriteLine("================================");
            //foreach (var item in result2)
            //{
            //    Console.WriteLine(item);
            //}

            //3- Returns digits whose name is shorter than their value.
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var result1 = Arr.Where(n => n.Length < ConvertStringToInt(n));
            //var result2 = from n in Arr
            //              where n.Length < ConvertStringToInt(n)
            //              select n;

            //foreach (var result in result1)
            //{
            //    Console.WriteLine(result);
            //}

            //Console.WriteLine("================================");
            //foreach (var item in result2)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 2-Element Operators
            //1-get the first product out of stock
            //var result = ProductList.FirstOrDefault(p=>p.UnitsInStock==0);
            //Console.WriteLine(result);

            //2- Return the first product whose Price > 1000, unless there is no match, in which case null is returned.
            //var result1 = ProductList.Where(p => p.UnitPrice > 1000).FirstOrDefault();
            //var result = ProductList.FirstOrDefault(p=>p.UnitPrice>1000);
            //Console.WriteLine(result);

            //3- Retrieve the second number greater than 5 

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = Arr.Where(n => n > 5).ElementAtOrDefault(1);
            //Console.WriteLine(result);
            #endregion

            #region 3-Set Operators
            //1. Find the unique Category names from Product List
            //var result = ProductList.DistinctBy(p => p.Category).Select(p=>new {p.ProductName,p.Category });
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //2- Produce a Sequence containing the unique first letter from both product and customer names.
            //var prdList = ProductList.Select(p => p.ProductName.ToLower().ToCharArray().Distinct().FirstOrDefault());
            //var custList= CustomerList.Select(c=>c.CustomerID.ToLower().ToCharArray().Distinct().FirstOrDefault());
            //var result=prdList.Concat(custList);
            ////var result2 =prdList.Union(result);
            //foreach (var item in result)
            //{
            //    Console.Write(item+" , ");
            //}


            //3- Create one sequence that contains the common first letter from both product and customer names.
            //var prdList = ProductList.Select(p => p.ProductName.ToLower().ToCharArray().FirstOrDefault());
            //var custList = CustomerList.Select(c => c.CustomerID.ToLower().ToCharArray().FirstOrDefault());
            //var result = prdList.Concat(custList);
            //foreach (var item in result)
            //{
            //    Console.Write(item + " , ");
            //}



            //4- Create one sequence that contains the first letters of product names that are not also first letters of customer names.

            //var prdlist = ProductList.Select(p => p.ProductName.ToLower().ToCharArray().FirstOrDefault());
            //var custlist= CustomerList.Select(c=>c.CustomerID.ToLower().ToCharArray().FirstOrDefault());
            //var result=prdlist.Except(custlist);
            //foreach (var item in result)
            //{
            //    Console.Write(item+" , ");
            //}


            //5- Create one sequence that contains the last Three Characters in each names of all customers and products, including any duplicates
            //var prdlist = ProductList.Select(p => p.ProductName.Substring(p.ProductName.Length - 3, 3));
            //var custlist=CustomerList.Select(c=>c.CustomerID.Substring(c.CustomerID.Length- 3, 3));
            //var result=prdlist.Concat(custlist);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //    Console.WriteLine("----------------");
            //}
            #endregion

            #region 4-Aggregate Operators

            // 1-Uses Count to get the number of odd numbers in the array
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result= Arr.Count(i=>i%2!=0);
            //Console.WriteLine(result);



            //2- Return a list of customers and how many orders each has.
            //var result = CustomerList.Select(c => new { c.CustomerID, c.City, numberOfOrders = c.Orders.Count() });
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //3- Return a list of categories and how many products each has
            //var result = ProductList.GroupBy(p => p.Category).Select(p=> new { Category=p.Key,ProductCount=p.Count()});
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //4- Get the total of the numbers in an array.
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = Arr.Sum();
            //Console.WriteLine(result);

            //5. Get the total number of characters of all words in dictionary_english.txt
            //(Read dictionary_english.txt into Array of String First).

            //var result = Dictionary.Sum(d => d.Length);
            //Console.WriteLine(result);

            //6- Get the total units in stock for each product category.
            //var result = ProductList.GroupBy(p => p.Category).Select(p => new { Category = p.Key, TotalStock = p.Sum(p => p.UnitsInStock) });
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //7- Get the length of the shortest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //var result = Dictionary.Min(w => w.Length);
            //Console.WriteLine(result);

            //8. Get the cheapest price among each category's products
            //var result = ProductList.GroupBy(p => p.Category).
            //    Select(p => new { Category = p.Key, LowestProductPrice = p.Min(p => p.UnitPrice) });
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //9. Get the products with the cheapest price in each category (Use Let)
            //var result = from p in ProductList
            //             group p by p.Category into groupedElem

            //             let singlePrd = groupedElem.Min(p => p.UnitPrice)
            //             select new { Category = groupedElem.Key, SmallestPrice = singlePrd };


            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //10. Get the length of the longest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //var result = Dictionary.Max(w => w.Length);
            //Console.WriteLine(result);

            //11- Get the most expensive price among each category's products.
            //var result = ProductList.GroupBy(p => p.Category).
            //    Select(p => new { Category = p.Key, highestPrice = p.Max(p => p.UnitPrice) });
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //12. Get the products with the most expensive price in each category.
            //var result = from p in ProductList
            //             group p by p.Category into groupedElements
            //             let highestPrice = groupedElements.Max(p => p.UnitPrice)
            //             let productName = groupedElements.Where(p => p.UnitPrice == highestPrice).Select(p => p.ProductName).FirstOrDefault()
            //             select new { Category = groupedElements.Key, HighestPrice = highestPrice, ProducName = productName };

            //var result2 = from p in ProductList
            //              group p by p.Category into groupedElements
            //              let highestPrice2 = groupedElements.MaxBy(p => p.UnitPrice)
            //              select new { Category = groupedElements.Key, HighestPrice = highestPrice2.UnitPrice, ProducName = highestPrice2.ProductName };


            //var result3 = ProductList.GroupBy(p => p.Category).SelectMany(y => y.Where(z => z.UnitPrice == y.Max(i => i.UnitPrice)))
            //    .Select(p => new { p.Category, HighestPrice = p.UnitPrice, p.ProductName });

            //var result4 = ProductList.GroupBy(p => p.Category)
            //    .Select(p => new { Category = p.Key, HighestPrice = p.Max(p => p.UnitPrice), productName = p.MaxBy(p => p.UnitPrice).ProductName });
            //foreach (var item in result4)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("+===============================+");
            //foreach (var item in result3)
            //{
            //    //Console.WriteLine($@" Category={item.Category},HighestPrice={item.UnitPrice},ProductName={item.ProductName}");
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("+=============================+");
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("+========================+");
            //foreach (var item in result2)
            //{
            //    Console.WriteLine(item);
            //}

            //13- Get the average length of the words in dictionary_english.txt(Read dictionary_english.txt into Array of String First).
            //var result = Dictionary.Average(w => w.Length);
            //Console.WriteLine(result);

            //14- Get the average price of each category's products.
            //var result = ProductList.GroupBy(p => p.Category).Select(p => new { Category = p.Key, AveragePrice = p.Average(p => p.UnitPrice) });
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 5-Ordering Operators

            //1. Sort a list of products by name

            //var result = ProductList.OrderBy(p => p.ProductName.Length).Select(p=>new {p.ProductName,p.UnitPrice});
            //foreach (var item in result) 
            //{
            //    Console.WriteLine(item);
            //}

            //

            //2- Uses a custom comparer to do a case-insensitive sort of the words in an array.
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var result = Arr.OrderBy(w => w, new compare());
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}


            //3-Sort a list of products by units in stock from highest to lowest.
            //var result = ProductList.OrderByDescending(p => p.UnitsInStock).Select(p=> new { p.ProductName,p.UnitsInStock});
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //4. Sort a list of digits, first by length of their name, and then alphabetically by the name itself.
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var result = Arr.OrderBy(w => w.Length).ThenBy(w => w);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}


            //5. Sort first by word length and then by a case-insensitive sort of the words in an array.
            //string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var result = words.OrderBy(w => w.Length).ThenBy(w => w, new compare());
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            // 6-Sort a list of products, first by category, and then by unit price, from highest to lowest.

            //var result = ProductList.OrderBy(p => p.Category).ThenByDescending(p => p.UnitPrice).Select(p=> new { p.Category,p.ProductName,p.UnitPrice});
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //7- Sort first by word length and then by a case-insensitive descending sort of the words in an array.
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var result = Arr.OrderBy(w => w.Length).ThenByDescending(w => w, new compare());
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}


            //8- Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var result = Arr.Where(w => w.ElementAt(1) == 'i').Reverse();
            //var result2=Arr.Where(w=>w.ElementAtOrDefault(1)=='i').Reverse();
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion


            #region 6-Partitioning Operators

            //1- Get the first 3 orders from customers in Washington

            //var result = CustomerList.Where(c => c.Country == "Germany");
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.CustomerID+"::::");
            //    foreach (var item2 in item.Orders.Take(3))
            //    {
            //        Console.WriteLine("-----"+item2);
            //    }

            //}

            //2- Get all but the first 2 orders from customers in Washington
            //var result = CustomerList.Where(c => c.Country == "Germany");
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.CustomerID + "::::");
            //    foreach (var item2 in item.Orders.Skip(2))
            //    {
            //        Console.WriteLine("-----" + item2);
            //    }

            //}


            //3-Return elements starting from the beginning of the array until a number is hit that is less than its position in the array.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = numbers.TakeWhile((e, i) => e >= i);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //4- Get the elements of the array starting from the first element divisible by 3.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = numbers.SkipWhile(n => n % 3 != 0);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}


            //5-Get the elements of the array starting from the first element less than its position.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result=numbers.SkipWhile((e,i)=>e>i);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion


            #region 7-Projection Operators
            //1-Return a sequence of just the names of a list of products.

            //var result = ProductList.Select(p => p.ProductName);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}


            //2-Produce a sequence of the uppercase and lowercase versions of each word in the original array (Anonymous Types).
            //string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };
            //var result = words.Select(w => new { UpperCase = w.ToUpper(), LowerCase = w.ToLower() });
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}


            //3-Produce a sequence containing some properties of Products,
            //including UnitPrice which is renamed to Price in the resulting type.
            //var result = ProductList.Select(p => new { p.ProductName, Price = p.UnitPrice, p.UnitsInStock });
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}


            //4-Determine if the value of ints in an array match their position in the array.
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = Arr.Select((w,index) => new { V = $"{w}:{(w==index?"true":"false")}" });
            //Console.WriteLine("Number: In-place?");
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}


            //5- Returns all pairs of numbers from both arrays such that the number from numbersA is less than the number from numbersB.
            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };

            //var result = numbersB.Where((e, i) => e > numbersA[i]).Zip(numbersA);

            //var result2 = numbersA.SelectMany((a, i) =>
            //{
            //    List<string> x = new();
            //    foreach (var item in numbersB)
            //    {

            //        if (a < item)
            //            x.Add($"{a} is less than {item}");
            //    }
            //    return x;

            //});
            //foreach (var item in result2)
            //{
            //    Console.WriteLine(item);
            //}
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}




            //6-Select all orders where the order total is less than 500.00.
            //var result = CustomerList.SelectMany(c => c.Orders).Where(o=>o.Total<500);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}


            //7-Select all orders where the order was made in 1998 or later.

            //var result = CustomerList.SelectMany(c => c.Orders).Where(o => o.OrderDate.Year >= 1998).Select(o=> new { o.OrderID,o.OrderDate.Year});
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 8-Quantifiers
            //1-Determine if any of the words in dictionary_english.
            //txt(Read dictionary_english.txt into Array of String First) contain the substring 'ei'.

            //var result = Dictionary.Contains("ei");
            //Console.WriteLine(result);

            //2-Return a grouped a list of products only for categories that have at least one product that is out of stock.
            //var result = ProductList.GroupBy(p => p.Category).Where(p => p.Any(p => p.UnitsInStock == 0));
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.Key);
            //}

            //3-Return a grouped a list of products only for categories that have all of their products in stock.

            //var result = ProductList.GroupBy(p => p.Category).Where(p => p.All(p => p.UnitsInStock > 0));
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.Key);
            //}


            #endregion

            #region 9-Grouping Operators
            // 1-Use group by to partition a list of numbers by their remainder when divided by 5

            //var numberList = Enumerable.Range(0, 15);
            //var result = numberList.GroupBy(n => n % 5);
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"numbers with reminder of {item.Key} when divied by 5");
            //    foreach (var item2 in item)
            //    {
            //        Console.WriteLine($"---{item2}");
            //    }
            //}

            //2-Uses group by to partition a list of words by their first letter.
            //Use dictionary_english.txt for Input

            //var result = Dictionary.GroupBy(w => w.ElementAt(0));

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"words starts with the letter {item.Key}");
            //    foreach (var item2 in item.Take(10))
            //    {
            //        Console.WriteLine($"---{item2}");
            //    }
            //}



            //6-Use Group By with a custom comparer that matches words that are consists of the same Characters Together
            //string[] Arr = { "from   ", " salt", " earn ", "  last   ", " near ", " form  " };

            //var result = Arr.GroupBy(w=>w,new CustomComparer());
            //foreach (var item in result)
            //{
            //    Console.WriteLine("----");
            //    foreach (var item2 in item)
            //    {
            //        Console.WriteLine(item2.Trim());
            //    }
            //}
            #endregion
        }
    }
    public  class compare : IComparer<string>
    {
     

        public int Compare(string? x, string? y)
        {
            return x.ToLower().CompareTo(y.ToLower());
        }
    }

    public class CustomComparer:IEqualityComparer<string>
    {
     

        public bool Equals(string? x, string? y)
        {
            var temp1 = x.Trim().ToCharArray();
            var temp2 = y.Trim().ToCharArray();
            Array.Sort(temp1);
            Array.Sort(temp2);
            string st1 = new string(temp1);
            string st2 = new string(temp2);
            return st1.Equals(st2);
        }

        public int GetHashCode([DisallowNull] string obj)
        {
            return 0;
        }
    }
}