using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace stackImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Write a program which implements a stack interface for integers. The interface should have ‘push’ and ‘pop’ functions. 
            Your task is to ‘push’ a series of integers and then ‘pop’ and print every alternate integer.
            Print to stdout every alternate space delimited integer, one per line.
            */
            string line = "";
            using (StreamReader reader = new StreamReader("file1.txt"))

                while (!reader.EndOfStream)
                {
                    line = reader.ReadLine();
                    string str = line;
                    //line.Trim();
                    string[] splitLine = line.Split(' ');

                    Stack<string> nums = new Stack<string>();
                    foreach (string x in splitLine)
                    {
                        nums.Push(x);
                    }

                    while (nums.Count() > 0)
                    {
                        Console.Write(nums.Pop() + " ");
                        

                        if (nums.Count != 0)
                        {
                            nums.Pop();
                        }
                       


                    }
                    Console.ReadLine();


                } 

        }
    }
}