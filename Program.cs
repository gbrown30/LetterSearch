using System;
using System.Collections.Generic;
using System.Linq;

namespace LetterSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            //wait for user input    
            string userInput = Console.ReadLine();
            
            //take input as char array -- make letters the same case
            var chars = userInput.ToLower().ToCharArray();

            //get unique array elements in array
            var distinct = chars.Distinct();

            //create a list to hold character counts
            var elementCount = new List<int>();

            //create variable to build final output
            var output = "";

            //iterate through array
            foreach (var c in distinct ) {
                //add character to output
                output += c + " | ";

                //use linq to count instances of char in the array
                elementCount.Add(chars.Count(n => n == c)); 
            }

            //line break for the ouput format
            output += "\n";
            
            //iterate through count array add into output
            foreach(var e in elementCount)
            {
                output += e.ToString() + " | ";
            }

            //write output
            Console.WriteLine(output);
            
            //line breaks
            Console.WriteLine("\n\n");

            //write final message
            Console.WriteLine(String.Format("The text has been processed.Total letters counted: {0} where {0} is the total number of letters counted inside the text submitted.", chars.Length) );


        }
    }
}
