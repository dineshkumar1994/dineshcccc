using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string line = "";
            string spattern = ("\"id\": (\\d+), \"label\"");
            using (StreamReader reader = new StreamReader("file1.txt"))
                while (!reader.EndOfStream)
                {

                    line = reader.ReadLine();
                    string str = line;
                    MatchCollection matches = Regex.Matches(str, spattern);
                    List<int> ExtractedIds = new List<int>();
                    foreach (Match match in matches)
                    {
                        int theid = int.Parse(match.Groups[1].Value);
                        ExtractedIds.Add(theid);
                    }
                    Console.WriteLine(ExtractedIds.Sum());

                }
            Console.ReadLine();
        
        }
    }
}