using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTutorial
{
    public class Product
    {
        public string Name { get; set; }
        public int CategoryID { get; set; }

    }
    public class Category
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
    class caseIsesitive : IComparer<string>
    {
        public int Compare(string s1, string s2)
        {
            return string.Compare(s1, s2, true);
        }
    }
    class Program
    {
        private static readonly string Text =
            "Mary had a little lamb " +
            "little Lamb, little Lamb, " +
            "Mary had a Little lamb, " +
            "whose fleece were white as snow.";
        static void Main(string[] args)
        {
            //DateTime date = DateTime.Now.AddDays(-DateTime.Now.Date.Day);
            //DateTime lastTwoMounts = DateTime.Now.AddDays(-(date.Day + DateTime.Now.Date.Day));
            //Console.WriteLine(date.Day.ToString());
            //Console.WriteLine("");
            //Console.WriteLine(lastTwoMounts.ToString());

            //List<Category> categories = new List<Category>()
            //{
            //    new Category() { ID = 1, Name = "Fruit" },
            //    new Category() { ID = 2, Name = "Food" },
            //    new Category() { ID = 3, Name = "Shoe" },
            //    new Category() { ID = 4, Name = "Juice" },
            //};
            //List<Product> products = new List<Product>()
            //{
            //    new Product() {Name = "Strawberry", CategoryID=1},
            //    new Product() { Name = "Strawberry", CategoryID = 1 },
            //    new Product() { Name = "Banana", CategoryID = 1 },
            //    new Product() { Name = "Chicken meat", CategoryID = 2 },
            //    new Product() { Name = "Apple Juice", CategoryID = 4 },
            //    new Product() { Name = "Fish", CategoryID = 2 },
            //    new Product() { Name = "Orange Juice", CategoryID = 4 },
            //    new Product() { Name = "Sandal", CategoryID = 3 },
            //};

            //var productsWithCategories = from product in products
            //                             join category in categories
            //                             on product.CategoryID equals category.ID
            //                             select new { name = product.Name, category = category.Name };
            //foreach(var item in productsWithCategories)
            //{
            //    Console.WriteLine(item);
            //}
            //IDictionary<string, double> studentMarks = new Dictionary<string, double>();
            //studentMarks["Paul"] = 3.22;
            //Console.WriteLine("Paul 's mark: {0:0.00}",
            //studentMarks["Paul"]);
            //Console.Read();

            // IDictionary<string, int> wordCount = GetWordOccurrenceMap(Text);

            // foreach (var wdcount in wordCount)
            // {
            //     Console.WriteLine("word {0} occurs {1} times in the text", wdcount.Key, wdcount.Value);
            // }
             int[] ar = new int[]{ 1, 5, 8, 3, 4 };
            Array.Sort(ar);

            //int[] secondArray = new int[10];

            if(ar.Contains(8))
            //for (int x = 1; x <= 10; x++)
            //{
            //    secondArray[x - 1] = x;
            //}

            //var results = secondArray.Except(ar).First();

            //// foreach (var aa in results) { Console.WriteLine(aa); }
            //Console.WriteLine(results.ToString());
            
            Console.WriteLine(Solution.solution(ar));

            Console.Read();
        }
        public static IDictionary<string, int> GetWordOccurrenceMap(string Text)
        {
            string[] tokens = Text.Split(' ', ',', '.', '?', '-', '!');

            IDictionary<string, int> words = new SortedDictionary<string, int>(new caseIsesitive());

            foreach (var word in tokens)
            {
                if (!string.IsNullOrEmpty(word))
                {
                    int count;
                    if (!words.TryGetValue(word, out count))
                    {
                        count = 0;
                    }
                    words[word] = count + 1;
                }
            }
            return words;
        }

    }

    class Solution
    {
        public static int solution(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            Array.Sort(A);
            int num = 0;
            int[] secondArray = new int[1000000]; 
            for (int x = 1; x <= 1000000; x++)
            {
                secondArray[x - 1] = x;
            }
            var results = secondArray.Except(A);

            foreach (var aa in results)
            {
                if(!(aa <= 0))
                {
                    num = aa;
                    break;
                }
            }

            return num;

        }
    }
}
