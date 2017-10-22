using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = "B12";
            Regex rx = new Regex(@"[A-Za-z](\\d+)");
            MatchCollection matches = rx.Matches(myString);
            if (matches.Count > 0)
            {
                Match match = matches[0]; // only one match in this case
                GroupCollection groupCollection = match.Groups;
                Console.WriteLine("serial " + groupCollection[1].ToString());
            }
        }
    }
}
