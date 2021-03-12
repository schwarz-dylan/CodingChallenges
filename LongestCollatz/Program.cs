using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestCollatz
{
    class Program
    {
        static void Main(string[] args)
        {
            //The following iterative sequence is defined for the set of positive integers:

            //n → n / 2(n is even)
            //n → 3n + 1(n is odd)

            //Using the rule above and starting with 13, we generate the following sequence:
            //13 → 40 → 20 → 10 → 5 → 16 → 8 → 4 → 2 → 1

            //It can be seen that this sequence(starting at 13 and finishing at 1) contains 10 terms.Although it has not been proven yet, it is thought that all starting numbers finish at 1.

            //Which starting number, under one thousand, produces the longest chain ?

            //NOTE : Once the chain starts the terms are allowed to go above one thousand.


            //------------------------------------------------------------------------------------------------//


            //int n = 0;
            //int nLength = 0;
            //int seq;

            //for (int i = 2; i < length; i++)
            //{

            //}

            long sLength = 0;
            long startNumber = 0;                        
            int n;
            

            for (int i = 2; i <= 1000; i++) //starting a loop that goes to 1000 --start with 2
            {
                int length = 1; //the end result
                n = i;
                while (n != 1)
                {


                    if ((n % 2) == 0)
                    {                           //this if statment finds out if the number is even or else run to see if its odd
                        n = n / 2;
                    }//end if



                    else
                    {
                        n = n * 3 + 1;          //if statment finds out if the number is odd
                    }//else
                    length++;  //this is a increment operator (increments up by one each time)



                }//end while

                
                if (length > sLength)
                {
                    sLength = length;

                    startNumber = i;

                }//end if

                
            }//for

            

            Console.WriteLine($"Longest chain : {sLength}\nStarting number: {startNumber}");
            



        }//end main
    }//end class
}//end namespace
