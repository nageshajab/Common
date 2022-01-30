using System;
namespace CSharp.CommonUtilities
{
    public class Console
    {
        public static void ListMenus(string[] arr)
        {            
            System.Console.WriteLine("Enter your choince");
            int i = 0;
            foreach (string str in arr)
            {
                i += 1;
                System.Console.WriteLine($"{i} {str}");
            }
        }
        public static int ReadInt(string msg)
        {
            System.Console.WriteLine(msg);
            string input = System.Console.ReadLine();
            int output = 0;
            int.TryParse(input, out output);
            return output;
        }
        public static string ReadString(string msg)
        {
            System.Console.WriteLine(msg);
            string input = System.Console.ReadLine();
            return input;
        }
    }
}