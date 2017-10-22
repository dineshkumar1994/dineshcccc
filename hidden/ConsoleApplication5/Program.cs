//using System.IO;
//spusing System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApplication5
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            string line = "";
//            using (StreamReader reader = new StreamReader("file1.txt"))

//                while (!reader.EndOfStream)
//                {
//                    line = reader.ReadLine();
//                    string str = line;
                  
//                    //string[] splitLine = line.Split(' ');


//             if(str.Contains("+"))
//            {
//                splitPattern = str.Split(new char[] { '+' }, StringSplitOptions.RemoveEmptyEntries);
//                firstSidePattern = splitPattern[0];
//                secondSidePattern = splitPattern[1];
//                symbol = "+";
//            }
//            else
//            {
//                splitPattern = pattern.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
//                firstSidePattern = splitPattern[0];
//                secondSidePattern = splitPattern[1];
//                symbol = "-";
//            }
 
//        }
//    }
//}
//}
