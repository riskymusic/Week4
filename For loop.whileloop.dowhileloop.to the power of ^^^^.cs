using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {
     

            int start = 76;

            int finish = 46; //creates a rule towards the words finish & start
           

            Console.WriteLine(">>>Display odd numbers from 76 to 46 (descending)");

            while (start >= finish) //builds the table 
            
            {
                if (start % 2 != 0) //check each number to see if even or odd// !=  if an odd number print//
                    Console.WriteLine($" {start} ");
                start--; // -- means less to stop
            }
            Console.WriteLine("Please enter a charater: "); //Writes the questions 
            string char1 = Console.ReadLine(); //Creates the end result + the entered character to the questions//
            Console.WriteLine($"please enter the number of times you would like to display {char1}: "); //client inputs character// $ activates {} - brackets//
            int num1 = int.Parse(Console.ReadLine()); 

            for(int i = 0; i <= num1; i++)
            {
                Console.WriteLine(char1);
            }
            Console.WriteLine("\n Task2 end");
            Console.ReadLine();

                









        }
    }
}
