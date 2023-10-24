using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_4_app
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str;
            string[] words;

            using (FileStream fs = new FileStream(args[0], FileMode.Open))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    str = sr.ReadToEnd();
                }
            }

            char[] chars = { ' ', ',', '.', '-' };
            words = str.Split(chars);

            int countWords = 0;

            foreach (string word in words)
            {
                if (word == args[1])
                {
                    countWords++;
                }
            }

            Console.WriteLine(countWords);
        }
    }
}
