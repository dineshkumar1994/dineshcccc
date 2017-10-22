using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mincount
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
                        string[] tokens = line.Split(' ');

                        int[] a = Array.ConvertAll<string, int>(tokens, int.Parse);
                        List<int> b = new List<int>();
                        for (int i = 0; i < a.Length - 1; i++)
                        
                        {
                            b.Add(a[i]);
                        }


                        
                        var uniq = b.GroupBy(x => x).Where(g => g.Count() == 1).Select(g => g.Key).DefaultIfEmpty().Min();
                     

                        //int index = b.IndexOf(
                        //    uniq);


                        Console.WriteLine(uniq);

                        Console.ReadLine();
                    }
                }
        }
    }

}