using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace MesterLogika
{

    class Combination
    {
        public string Line { get; set; }
        public int Letternumber { get; set; }
        public string Position { get; set; }

        public Combination(string line, int number, string posi)
        {
            this.Line = line;
            this.Letternumber = number;
            this.Position = posi;
        }

        public static List<Combination> Combinations = new List<Combination>();
    }

    class Program
    {

        public static bool FirstGenerate = true;
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
            string intlocal = localCount.Aggregate<int, string>(null, (current, i) => current + (i + ", "));
            WriteLine(local.Length + "\tbetűt tartalmaza\t" + intlocal + "\tpoziciók helyesek");
            return false;
        }

        public static bool GetEqualsMachine()
        {
            Random rnd =new Random();
            string FirstCombination;
            if (FirstGenerate) FirstCombination = GetAll()[rnd.Next(GetAll().Count)];

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
