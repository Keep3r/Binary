using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("----Number to binary converter----\n\nBy: X x/li3r\n\n(it only converts numbers between 1 and 15)\n\nSay a number:");

            int num = Convert.ToInt32(Console.ReadLine());//Get the input.

            string output = ConvertToBinarie(num);//Convert to binary code.

            //Write and read the binary code.
            Console.WriteLine(output);
            Console.ReadLine();
        }

        static string ConvertToBinarie(int number)
        {

            string result = "";//Result.

            Dictionary<int, string> binary = new Dictionary<int, string>(){
                //Numbers 1 to 15 (8 bit numbers)
                { 0, "0000"},
			    { 1, "0001"},
                { 2, "0010"},
                { 3, "0011"},
                { 4, "0100"},
                { 5, "0101"},
                { 6, "0110"},
                { 7, "0111"},
                { 8, "1000"},
                { 9, "1001"},
                { 10, "1010"},
                { 11, "1011"},
                { 12, "1100"},
                { 13, "1101"},
                { 14, "1110"},
                { 15, "1111"},
            };

            //Check of the dictionary "binary" contains number.

            foreach (var k in binary)
            {
                try
                {
                    if (k.Key == number)
                    {
                        result += k.Value + "\n";
                    }
                    if (!binary.ContainsKey(number))
                    {
                        Console.WriteLine("Only NUMBERS there are between 1 and 15");//If the number isn't between 1 and 15, that happens.
                    }
                }

                //Exception handling
                #region ExceptionsThatMightBeThrowed
                catch (IndexOutOfRangeException ex)
                {
                    Console.WriteLine("Only NUMBERS there are between 1 and 15\n{0}", ex.Message);
                }

                catch (FormatException ex)
                {
                    Console.WriteLine("Only NUMBERS there are between 1 and 15\n{0}", ex.Message);
                }
                #endregion
            }

            return result;//Returns the result.

        }
    }
}

