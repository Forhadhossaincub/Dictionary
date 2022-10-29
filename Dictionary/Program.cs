using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, float> rating = new Dictionary<string, float>();
            rating["Dhaka"] = 3.5F;
            rating["Chittagong"] = 5.0F;
            rating["Sylet"] = 3.5F;
            rating["Khulna"] = 3.8F;
            rating["Rajshahi"] = 4.3F;

            Console.WriteLine(rating["Dhaka"]);
            Console.WriteLine(rating["Rajshahi"]);

            foreach (var kv in rating)
            {
                Console.WriteLine($"{kv.Key} {kv.Value}");
            }



            foreach (var k in rating.Keys)
            {
                Console.WriteLine($"{rating[k]}");
            }



            Console.ReadKey();
        }
    }
}
