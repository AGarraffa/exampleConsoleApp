using System;

namespace exampleConsoleApp
{
    class Program
    {
        public static void Main(String[] args)
        {
            /* int x = 5;
            int y = -4;
            float z = 3.0f;
            float w = 0.003f;
            string string1 = "This is a string";
            string string2 = "a";
            char char1 = 'a';
            char char2 = 'b';
            bool bool1 = true;
            bool bool2 = false;
            */

            // printing to the console
            Console.WriteLine("Hello World");

            // simple conditional statement
            bool trueBool = false;

            if (trueBool)
            {
                Console.WriteLine("This was true");
            }
            else
            {
                Console.WriteLine("This was false");
            }


            // iterating over a for loop
            List<string> collection = new List<string>() { "a", "b", "c" };

            for(int i=0; i<collection.Count; i++)
            {
                // prints to the output window
                System.Diagnostics.Debug.WriteLine(collection[i]);
            }

            // while loop. notice that without i-- at the end of the loop, this would continue endlessly.
            int j = 3;
            while (j>0)
            {
                System.Diagnostics.Debug.WriteLine("Loading");
                j--;
            }

            System.Diagnostics.Debug.WriteLine("Complete");

        }
    }
}