using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] kolekcjaLiczb= { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            string[] tesktArray = new string[] { "ala", "ma", "ala", "ma", "kota", "a", "kot", "lubi", "ale" };
            //var querry1 = kolekcjaLiczb.Select(n => n).ToArray().OrderByDescending (b => b);
            //var querry1 = kolekcjaLiczb.Select(n => n).Where(b => b <= 5).ToArray();
            // var querry1 = kolekcjaLiczb.Select(n =>n).Where(b => 5 <= b).ToArray();
            //var querry1 = tesktArray.Select(n => n).Where(a => a.Length == 3).ToArray();  // rowne 3 
           // var querry1 = tesktArray.Select(n => n).Where(a => 4 <= a.Length).ToArray(); //wieksze od 4 
            foreach (var item in querry1)
            {
                Console.Write(item + " ");
            }

            Console.ReadKey();
        }
         
}
}
