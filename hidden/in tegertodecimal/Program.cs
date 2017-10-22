using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace in_tegertodecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "";
            using (StreamReader reader = new StreamReader("file1.txt"))
                while (!reader.EndOfStream)
                {
                   
                    line = reader.ReadLine();
                    string str = line;
                    if (str != " " && str != "")
                    {
                        int number = int.Parse(line);
                        string binary = Convert.ToString(number, 2);
                        Console.WriteLine(binary);
                    }
                }
            Console.ReadLine();
        }
    }
}
