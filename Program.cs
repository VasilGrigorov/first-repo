using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++) {
                Console.Write($"{i} ");
                for (int j = 1; j < i; j++) {
                    Console.Write($"{i} so lets go home");
                }
                --------test conflict,. conflict not found:)
                Console.WriteLine();
<<<<<<< HEAD
                Console.WriteLine("Vasil");
		Console.WriteLine("Project");
=======
                Console.WriteLine("V");
                Console.WriteLine("We are Great");
                
            
>>>>>>> b455e53f1913b78996ab006874bc1fa3aff21194
            }
        }
    }
}
