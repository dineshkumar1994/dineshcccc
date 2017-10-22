using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CodeEvalSolutions.MixedContent
{
    class MixedContentSolution
    {
        static void Main(string[] args)
        {
            string line = "";
            using (StreamReader reader = new StreamReader("file1.txt"))

                while (!reader.EndOfStream)
                {

                    line = reader.ReadLine();
                    var individualWords = line.Split(',');
                    var strings = new List<string>();
                    var numbers = new List<string>();

                    for (int i = 0; i < individualWords.Length; i++)
                    {
                        if (IsDigit(individualWords[i]))
                        {
                            numbers.Add(individualWords[i]);
                        }
                        else
                        {
                            strings.Add(individualWords[i]);
                        }
                    }
                }
        }
                    //if (strings.Any() && numbers.Any())
                    //{
                    //    Console.WriteLine();
                    //    String.Join(",", strings) + "|" +  String.Join(",", numbers);
                    //}
                    //if (strings.Any() && !numbers.Any()) return String.Join(",", strings);
                    //return String.Join(",", numbers);

        private static bool IsDigit(string individualWord)
                            {
            int n;
            return int.TryParse(individualWord, out n);
        }
                }

        }
    
