using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            string s = "India is Great";
            string m = "country";
            int count = s.GetWordCount();
            int read = s.Read();
            Console.WriteLine(s +" "+ m);
            Console.WriteLine("count: " + count);
            Console.WriteLine("Length: " + read);
        }
    }

    public static class extension
    {
        public static int GetWordCount(this string inputstring)
        {
            if (!string.IsNullOrEmpty(inputstring))
            {
                //Split the string by a space
                string[] strArray = inputstring.Split(' ');
                return strArray.Count();
            }
            else
            {
                return 0;
            }
        }
        public static int Read(this string inputstring)
        {
            if (!string.IsNullOrEmpty(inputstring))
            {
                string[] strArray = inputstring.Split(' ');
                return strArray.Length;
            }
            else { return 0; }
        }
        

        
    }
}

