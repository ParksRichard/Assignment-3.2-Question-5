using System;

namespace Assignment_3._2_Question_5
{
    internal class Program
    {
        /*
        Create a function that finds the index of a given item
        in the array
        */

        //index = position in array?
        //means need array count thing
       
        static void Main()
        {
            //get size of array
            Console.Write("Please enter how many elements for this Array: ");
            int biggie = Convert.ToInt32(Console.ReadLine());
            //while (!int.TryParse(Console.ReadLine(), out biggie) || biggie <= 0)
            Console.WriteLine();

            //make array
            int[] array = new int[biggie];

            //what's in the array
            Console.WriteLine("Please put some numbers in the Array");
            for (int i = 0; i < biggie; i++)
            {
                //while (!int.TryParse(Console.ReadLine(), out array[i]))
                Console.WriteLine($"Number {i + 1}: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine();
            //needs more spaces
            
            //searching for index
            Console.Write("Please enter the number you are looking for: ");
            int thing = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            //boom
            int index = lookie(array, thing);

            //-1 cause element numbers and whatnot
            if (index != -1)
            {
                Console.WriteLine($"The number you were looking for is in position {index+1}."); 
                //added the +1 for index but it seems like a workaround for something I'm missing. 
            }
            else
            {
                Console.WriteLine($"Number {thing} doesn't live here.");
            }

            //can't seem to find where/why getting -1 result
        }

        //order of code doesn't seem to matter as long as structured soundly
        static int lookie(int[] array, int thing)
        {
            //look for numbers
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == thing)
                { return i; }
            }
            return -1;
            // +1 point for intellisense  
        }
    }
}
