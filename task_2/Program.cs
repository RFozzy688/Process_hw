using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Process process = new Process();
            process.StartInfo = new ProcessStartInfo("notepad.exe");
            process.Start();

            Console.WriteLine("Запущен процесс: " + process.ProcessName);
            Console.Write("1 - ждать\n2 - завершить процесс\n > ");
            string str = Console.ReadLine();

            if (str == "1")
            {
                Console.WriteLine("Процесс ждет закрытия");
                process.WaitForExit();
            }
            else
            {
                Console.WriteLine("Процесс завершен");
                process.Kill();
            }

            Console.WriteLine("Процесс завершился с кодом: " + process.ExitCode);
        }
    }
}
