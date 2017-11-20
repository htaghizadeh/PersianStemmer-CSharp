using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Stemming.Persian;

namespace PersianStemmer
{
    class Program
    {
        static void Main(string[] args)
        {
            var ps = new Stemmer();
            //Console.WriteLine(ps.run("زیباست"));
            Console.WriteLine(ps.run("پدران"));

            Console.ReadKey();
        }
    }
}
