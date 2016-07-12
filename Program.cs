using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cheers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("What's your name?");
            Console.Write("> ");
            String user_name = Console.ReadLine(); //Read from terminal save to a variable

            for (int i = 0; i < user_name.Length; i++)
            {
                Console.WriteLine("Give me a..." + user_name[i]);
            }

            //user_name.ToUpper() is turning the user's name to uppercase
            //ToUpper() is functionality specific to strings.
            //ToUpper() accepts no arguments

            Console.WriteLine(user_name.ToUpper() + " is.. GRAND!");
        }
    }
}
