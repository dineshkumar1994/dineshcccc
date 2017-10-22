using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "";
            using (StreamReader reader = new StreamReader("file.txt"))
                while (!reader.EndOfStream)
                {
                    
                    line = reader.ReadLine();
                    char[] alphabets = new char[10] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j' };
                    string str1 = line;
                    StringBuilder sb = new StringBuilder();
                    foreach (char c in str1)
                    {
                        if (c >= 'a' && c <= 'j')
                        {
                            sb.Append(Array.IndexOf(alphabets, c));
                        }
                        else if (c >= '0' && c <= '9')
                        {
                            sb.Append(c);
                        }

                        else
                        {
                            Console.Write("");
                        }
                    }
                    if (sb.Length == 0)
                    {
                        Console.WriteLine("none");
                    }
                    else
                    {
                        Console.WriteLine(sb.ToString());
                       
                    }
                    Console.ReadLine();  
                }
        }
      
    }
}
