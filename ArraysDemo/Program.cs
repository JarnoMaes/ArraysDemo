using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] movies = { "LOTR", "Fight Club", "Interstellar", "Fight Night" };
            //for (int i = 0; i < movies.Length; i++)
            //{
            //    int rank = i + 1;
            //    Console.WriteLine(rank + ". " + movies[i] );
            //}

            //Console.ReadLine();


            string[] movies = new string[4];


            Console.WriteLine("Type in 4 movies");
            
            for (int i = 0; i < movies.Length; i++)
            {
                movies[i] = Console.ReadLine();
            }
           
            
            Console.WriteLine("Here they are Alpha:  ");
            Array.Sort(movies);

            for (int i = 0; i < movies.Length; i++)
            {
                Console.WriteLine(movies[i]);
            }
            
            Console.ReadLine();
            
           
            
            
            
            


            




        }
    }
}
