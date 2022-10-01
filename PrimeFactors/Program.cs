using System;
using static System.Console;



   class Program
  {
    //Program prints all prime factors of a user input number
    static void Main(string[] args)
    {
          


              Console.WriteLine("Enter a number to find its Prime Factors: ");
              int num = Convert.ToInt32(Console.ReadLine());
              
              try
              {            
                 while(num < 2)
              {
                Console.Write("Please enter a correct number which is greater than 2");
                num = Convert.ToInt32(Console.ReadLine());
              }
                              
               Console.Write("The Prime factors of " + (num) + " are: "); primeFactors(num);

              }
                catch(Exception ex)
                {
                  Console.Write("Please check your input" +
                               ex.Message);   //error message if there is no prime factor
                }

            }

        private static void primeFactors(int num)
        { 
          //print the number of 2s that divide num
            while (num % 2 == 0)
           { Console.Write(2 + " X ");
            num /= 2;
        }

        for (int i = 3; i <= Math.Sqrt(num); i += 2)
        { //While i divides the num, print i and divide num
          while (num % i == 0)
          {
            Console.Write(i + " X ");
            num /= i;
          }
        }

        //This condition will handle the case if 
        //num is a prime number greater than 2

        if (num > 2)
        Console.WriteLine(num);


    }
    }