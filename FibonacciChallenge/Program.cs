using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciChallenge
{
    class Program
    {
        //public static long Fib(long num)
        //{
        //    long a = 1;
        //    long b = 2;

        //    for (long i = 1; i < num; i++)
        //    {
        //        long tempNum = a;
        //        a = b;
        //        b = tempNum + b;
        //    }//end for

        //}

        //static void Main(string[] args)
        //{
        //    for (long i = 0; i < 4000000; i++)
        //    {
        //        Console.WriteLine(Fib(i));
        //    }
        //    Console.Read();


        //}//end main

        //static void Main(string[] args)
        //{
        //    int a = 1;
        //    int b = 2;
        //    int counter = 15;

        //    for (int i = 0; i < counter; i++)
        //    {
        //        int temp = a;
        //        a = b;
        //        b = temp + b;
        //        Console.Write(a + " ");
        //    }
        //    Console.WriteLine();
        //    Console.ReadLine();


        //}//


        static void Main(string[] args)
        {
            //long numb1 = 1; //define the variables
            //long numb2 = 2;
            //long outcome = numb1 + numb2; //initialize the result of newely calculated fibonacci variable
            //long added = 0; //same for the summing variable

            //while (outcome < 4000000 ) // loop until the "outcome" reaches 4million
            //{
            //    if ((outcome % 2) == 0 ) //the actual result
            //    {
            //        added += outcome;
            //    }//end if

            //    outcome = numb1 + numb2;
            //    numb2 = numb1;
            //    numb1 = outcome;

            //    Console.ReadLine();

            //}//end while

            long firstNumb = 1;
            long secondNumb = 2;        //Declare all of the variables
            long thirdNumb = 3;

            long sum = 2; // equals 2 bc its even

            while (thirdNumb < 4000000) //this is "flag" to stop the loop once it reaches 4mill
            {
                if (thirdNumb % 2 == 0) //anything devided by 2 is going to have a remainder of 0. So we will know that its even.
                {
                    sum = thirdNumb + sum; //since "thirdNumb" is the most recent even number we use that and add the sum.

                }//end if

                firstNumb = secondNumb; //changing the variables to move up in the Fibonacci sequence
                secondNumb = thirdNumb;

                thirdNumb = firstNumb + secondNumb;


            }//end while
            Console.WriteLine($"This is the sum of all even numbers in the Fibonacci Sequend under 4 Million: " + sum);

        }//end main

    }//end class 
}//end namespace
