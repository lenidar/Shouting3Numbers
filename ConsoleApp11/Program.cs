using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] temp = new int[] { 0, 0, 0 };
            int attempt = 0;
            double attemptTotal = 0;

            for (int a = 0; a < 1000; a++)
            {
                attempt = 0;
                while (true)
                {
                    attempt++;
                    for (int x = 0; x < temp.Length; x++)
                    {
                        temp[x] = rnd.Next(1, 10);
                    }

                    if (temp[0] == temp[1] && temp[1] == temp[2])
                        break;
                }

                Console.WriteLine("I took {0} attempts to shout in unison!", attempt);
                attemptTotal += attempt;
            }
            Console.WriteLine("On average I took {0} attempts", attemptTotal/1000);
            Console.ReadKey();
        }
    }
}
