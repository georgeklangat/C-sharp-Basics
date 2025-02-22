using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Intoduction_To_C_
{
    internal class accessString
    {
        static void Main(string[] args)
        {
            string myString = "     Hello  ";
            Console.WriteLine(myString[0]);

            // index
            Console.WriteLine(myString.IndexOf("e"));

            //Trimming whitespace-Remove the whitespace from the begining and the end of a string
            Console.WriteLine(myString.Trim());
            Console.WriteLine(myString.TrimStart());
            Console.WriteLine(myString.TrimEnd());

            //string Length
            Console.WriteLine("The length of the string is:" + myString.Length);

            //string concatenation
            string txt = "Divine mercy";
            string name = "my dear lord ";
            string concatenated = string.Concat(name, txt);
            Console.WriteLine(concatenated);

            //string Interpolatioin
            //example 1 
            string name1 = $"{name} {txt}";

            //example 2
            string passionOfCoding = "i love coding";
            string interpolated = $"{passionOfCoding} so much!";
            Console.WriteLine(interpolated);


        }
    }

}
