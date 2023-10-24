using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Process process = new Process();
            process.StartInfo = new ProcessStartInfo("notepad.exe");
            process.Start();

            Console.WriteLine("Запущен процесс: " + process.ProcessName);

            process.WaitForExit();

            Console.WriteLine("Процесс завершился с кодом: " +  process.ExitCode);
        }
    }
}
