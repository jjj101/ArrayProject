using System;

namespace ArrayProject
{
    class Program
    {
        private static int pop_array;

        static void Main(string[] args)
        {
            Console.WriteLine("Array of 25 integers");

            
                int[] numbersArray = new int[25];

                for (int counter=0;counter<25;counter++)
                {
                    numbersArray[counter] = counter;
                }

                for (int i=0; i<25; i++)
                 {
                    numbersArray[i] = pop_array;
                    Console.Write( i + "");
                 }
            
                
            




            
            }
        }
    }

