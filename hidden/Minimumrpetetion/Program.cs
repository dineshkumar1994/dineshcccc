using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minimumrpetetion
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
                        char[] tokens = line.ToCharArray();

                        
                        List<int> b = new List<int>();
                        for (int i = 0; i < tokens.Length - 1; i++)
                        {
                            b.Add(tokens[i]);
                        }
                        var distinctList1 = b.Distinct();
                        foreach(int m in distinctList1)
                        { Console.WriteLine(m); }
                        int kount = distinctList1.Count();
                        Console.WriteLine(kount);
                    }
                }
            Console.ReadLine();
        }
    }
}
