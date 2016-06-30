using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace MesterLogika
{
    class Program
    {
        private static List<string> AllCombination = GetAll();
        public static bool GetEquals(string word, string input)
        {
            if (word == input) return true;
            if (word.Length != input.Length) return false;

            char[] inputCharArray = input.ToCharArray();
            char[] wordCharArray = word.ToCharArray();
            List<int> localCount = new List<int>();

            for (int i = 0; i < word.Length; i++)
            {
                if (inputCharArray[i] == wordCharArray[i])
                {
                    localCount.Add(i + 1);
                }
            }
            List<char> localChars = inputCharArray.Where(word.Contains).Distinct().ToList();
            string local = localChars.Aggregate<char, string>(null, (current, i) => current + (i));
            string intlocal = localCount.Aggregate<int, string>(null, (current, i) => current + (i));
            WriteLine(local.Length + "\tbetűt tartalmaza\t" + intlocal.Length + "\tpozició helyes(ek)");
            return false;
        }

        public static List<string> FirsList = new List<string>();
        public static bool GetEqualsMachine()
        {
            bool Finish = false;
            string Combination = "AABB";
            WriteLine(Combination);
            int letternumber = int.Parse(ReadLine());
            int Position = int.Parse(ReadLine());
            Finish = bool.Parse(ReadLine());
            if (letternumber == 4)
            {
                if (Position == 4)
                {
                    WriteLine("BBAA");
                }
                else
                {
                    WriteLine("ABBA");
                    letternumber = int.Parse(ReadLine());
                    Position = int.Parse(ReadLine());
                    Finish = bool.Parse(ReadLine());
                    if (Finish == false)
                    {
                        WriteLine("BAAB");
                    }
                }
            }
            if (letternumber == 3)
            {

            }
            foreach (var VARIABLE in AllCombination)
            {
                WriteLine(VARIABLE);
            }



            Finish = bool.Parse(ReadLine());
            if (Finish) return true;

            return false;
        }

        public static List<string> GetAll()
        {
            char[] localChar = new[] { 'A', 'B', 'C', 'D', 'E', 'F' };
            List<string> all = new List<string>();
            string valami = null;
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    for (int k = 0; k < 6; k++)
                    {
                        for (int l = 0; l < 6; l++)
                        {
                            valami =
                                string.Format(localChar[i].ToString() + localChar[j].ToString() +
                                              localChar[k].ToString() + localChar[l].ToString());
                            all.Add(valami);
                        }
                    }
                }
            }
            return all;

        }

        public static string GetRandomString(char[] localChar)
        {
            Random rnd = new Random();

            string local = null;
            for (int i = 0; i < 4; i++)
            {
                local += localChar[rnd.Next(0, localChar.Length)];
            }
            return local;

        }

        static void Main(string[] args)
        {
            bool mainbool = false;
            while (!mainbool)
            {
                if (GetEqualsMachine())
                {
                    mainbool = true;
                }
            }
            //var generatestring = GetRandomString(new[] {'A', 'B', 'C', 'D', 'E', 'F'});
            //WriteLine(generatestring);
            //bool mainbool = false;
            //while (!mainbool)
            //{
            //    var readLine = Console.ReadLine();
            //    if (readLine != null && GetEquals(generatestring, readLine.ToUpper()))
            //        mainbool = true;
            //}
            //WriteLine("Correct!");

            ReadKey();
        }
    }
}
