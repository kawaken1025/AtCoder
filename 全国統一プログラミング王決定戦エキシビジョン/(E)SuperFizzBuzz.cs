using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Calc(int.Parse(Console.ReadLine()));

        }

        public static void Calc(int num)
        {
            for(int i = 1; i <= num; i++)
            {
                string output = "";
                if(i%2 == 0)
                {
                    output += "a";
                }

                if(i%3 == 0)
                {
                    output += "b";
                }

                if(i%4 == 0)
                {
                    output += "c";
                }

                if (i % 5 == 0)
                {
                    output += "d";
                }

                if(i%6 == 0)
                {
                    output += "e";
                }

                if (output.Equals(""))
                {
                    output = i.ToString();
                }

                Console.WriteLine(output);
            }
        }
    }
}
