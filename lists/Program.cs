using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lists
{
    class Program
    {
        static void Main(string[] args)
        {
            var fruitList = new List<string>();

            fruitList.Add("Apple");
            fruitList.Add("Pears");
            fruitList.Add("Fig");
            fruitList.Add("Date");
            fruitList.Add("Papaya");
            fruitList.Add("Mango");

            foreach (var item in fruitList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---------------------------------");
            fruitList.Sort();

            foreach (var item in fruitList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---------------------------------");

            ReportOnFigs(fruitList);
        }

        static void ReportOnFigs(List<string> items)
        {
            string figReport =
                items.Contains("Fig", StringComparer.OrdinalIgnoreCase) ?
                "Yes there are figs." :
                "No, no figs";
            Console.WriteLine(figReport);
        }

    }
}
