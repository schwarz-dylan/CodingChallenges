using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciChallenge2
{
    class Program
    {
        static void Main(string[] args)
        {
            long firstNumb = 1;
            long secondNumb = 2;        //Declare all of the variables
            long thirdNumb = 0;

            long sum = 0; // equals 2 bc its even

            

            List<long> fib = new List<long>();

            while (thirdNumb < 10000000000) //this is "flag" to stop the loop once it reaches 11 digits
            {
                // if (thirdNumb % 2 == 0) //any  number devided by 2 that equals 0,  we will know that its even.
                //{
                //sum = thirdNumb + sum; //since "thirdNumb" is the most recent even number we use that and add the sum.

                //}//end if

                fib.Add(thirdNumb);
                thirdNumb = firstNumb + secondNumb;
                firstNumb = secondNumb; //changing the variables to move up in the Fibonacci sequence
                secondNumb = thirdNumb;

                //while (n > 0)
                //{
                //    if (n % 10 == digit)
                    
                //        count++;
                //        n = n / 10;
                    
                //}//end while

            }//end while



            int indexNumb = fib.FindIndex(v => v.ToString().Length == 10);
          //creating a variable ; Going into the loop and finding the index of the first entry that when converting to a string it = 10 

            Console.WriteLine("Index of # with 10 digits is " + indexNumb );


            Console.WriteLine($"This is the Fibonacci Sequence that contains 10 digits: " + fib[fib.FindIndex(v => v.ToString().Length == 10)]);

            // Console.WriteLine(String.Join(" ", fib)); //converting the List into a string. The first param will go between the first index
            




        }//end main
    }//end class

}//end namespace
