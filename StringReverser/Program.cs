using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringReverser
{
    class Program
    {
        static void Main(string[] args)
        {
            string EnteredValue = "";
            string ReturnValue = "";
            bool isPal;

            Console.WriteLine("Welcome to the String Reverser!");
            Console.WriteLine("Please Enter a String to be Reversed");
            EnteredValue = Console.ReadLine();

            int Length = EnteredValue.Length - 1;

            while (Length >= 0)
            {
                ReturnValue = ReturnValue + EnteredValue[Length];
                Length--;
            }
            Console.WriteLine("the reverse of this sctring is" + ReturnValue);
            bool isPalindrome = palindrome(EnteredValue, ReturnValue);
            Console.WriteLine(EnteredValue);
            Console.WriteLine(ReturnValue);
            Console.WriteLine("Is this string a Palindrome? {0}", isPalindrome  );
            Console.ReadKey();

        }

        static bool palindrome(string strEntered, string strReturned)
        {
            if (strEntered == strReturned)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
