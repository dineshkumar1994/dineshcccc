using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace armstrong
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "";
            using (StreamReader reader = new StreamReader("file1.txt"))
                while (!reader.EndOfStream)
                {
                    int sum = 0;
                    int remainder;
                    line = reader.ReadLine();
                    string str = line;
                    if (str != " " && str != "")
                    {
                        int number = int.Parse(line);
                        if (number < 10)

                        { Console.WriteLine("TRUE"); }
                        if (number >= 10)
                        {
                            for (int i = number; i > 0; i = i / 10)
                            {
                                remainder = i % 10;
                                sum = sum + remainder * remainder * remainder;

                            }
                            if (sum == number)
                            {
                                Console.WriteLine("TRUE");
                            }
                            else
                                Console.WriteLine("NO");


                        }
                    }
                   

                }
            Console.ReadLine();
        }
    }
}