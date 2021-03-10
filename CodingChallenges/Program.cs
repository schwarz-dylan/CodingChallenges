using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a new, public repository and add a blank solution.Add a new Console Application project called Multiples3And5.

            //If we list all the natural numbers below 10
            //that are multiples of 3 or 5, we get 3, 5,
            //6 and 9. The sum of these multiples is 23.

            //Find the sum of all the multiples of 3 or 5 below 1000 and print it out to the console.

            //Remember to commit changes to the repository.Submit your repo url to this assignment.



            int sum = 0; //defining sum as an int that = 0
            for (int i = 1; i < 1000; i++) //counting by i or 1 until we hit 1000, i++ = the update; its counting all the way 1000 for every single intiger. Which is the condition that is i < 1000
            {
                int x = i % 3; //if it = 0 then we know its a multiple of 3 or 5 below
                int y = i % 5;
                if (x == 0 || y == 0)
                {
                    //Console.Write("{0}  ", i);
                    sum = sum + i; //adding all of the i's that equal 0 which then adds up to our answer
                }//end if statement
            }//end for loop
            Console.WriteLine("Multiples of 3 and 5 in 1000 = {0}\n", sum);
            Console.Read();

        }//end main


    }//end class


}//end namepsace
