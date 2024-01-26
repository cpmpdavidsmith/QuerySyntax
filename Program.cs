using System;
using System.Linq;

namespace SpringClean
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dogs = { "K 9", "Brian Griffin", "Scooby Doo", "Old Yeller", "Rin Tin Tin", "Rambo", "Lassie", "Snoopy" };

            var dogSpaces = from dog in dogs
                            where dog.Contains(" ")
                            orderby dog descending
                            select dog;

            foreach (var i in dogSpaces)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            Console.Read();
        }
    }
}