using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jollsjump
{
    class Program
    {
        static void Main(string[] args)
        {
            //string line = "";
            using (StreamReader reader = new StreamReader("file1.txt"))
                while (!reader.EndOfStream)
                {
                    
                   string line = reader.ReadLine();
                   
                    string str = line;
                    if (str != " " && str != "")
                    {
                    string[] tokens = line.Split(' ');
                   

                    int[] convertedItems = Array.ConvertAll<string, int>(tokens, int.Parse);
                    
                    //Console.WriteLine(tokens.Length - 1);
                    int count = 0;
                    //Console.WriteLine("size of array:{0}", str.Length);
                    List<int> b = new List<int>();
                    for (int i = 0; i < convertedItems.Length - 1; i++)
                    {

                        int d = Math.Abs(convertedItems[i] - convertedItems[i + 1]);
                        b.Add(d);
                            

                    }


                    for (int i = 0; i <= b.Count - 1; i++)
                    {
                        //if (b[i] == 0 || b[i] > b.Count || b.GroupBy(n => n).Any(g => g.Count() > 1))
                        if (b[i] == 0 || b[i] > b.Count)
                        {
                            count++;
                        }
                    }
                    if (count != 0)
                        Console.WriteLine("not a jolly");
                    else
                        Console.WriteLine("Jolyy");
                    Console.ReadLine();

                
                    }
        }
    }
    }
}
        