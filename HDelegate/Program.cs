using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDelegate
{
    public delegate void myFunc(string str);

    class MyClass
    {
        public void Space(string str)
        {
            var builder = new StringBuilder();
            int count = 0;
            foreach (var item in str)
            {
                builder.Append(item);

                if ((++count % 1) == 0)
                {
                    builder.Append('_');

                }
            }
            Console.WriteLine("Before: {0}", str);
            str = builder.ToString();
            Console.WriteLine("After: {0}", str);

        }
        public void Reverse(string str)
        {

            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);

            string str2 = new string(charArray);
            Console.WriteLine($"Before - {str}");
            Console.WriteLine($"After - {str2}");

        }
    }

        class Run
        {
          public void runFunc(string argument)
            {
            MyClass instance = new MyClass();

            myFunc mydelegate1 = new myFunc(instance.Space);
            mydelegate1.Invoke(argument);

            Console.WriteLine();
            Console.WriteLine();

            myFunc mydelegate2 = new myFunc(instance.Reverse);
            mydelegate2.Invoke(argument);

            Console.WriteLine();
          }
        }




    
    class Program
    {
        static void Main(string[] args)
        {
            Run ob = new Run();

            Console.WriteLine();
            Console.WriteLine("Please enter the word to operate on it");
            Console.WriteLine();
            string arg = Console.ReadLine();
            ob.runFunc(arg);

        }
    }
}
