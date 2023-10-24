using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Process process = new Process();
            process.StartInfo = new ProcessStartInfo(@"..\..\..\task_4_app\bin\Debug\task_4_app.exe");
            process.StartInfo.Arguments = @"C:\test.txt bicycle";
            process.Start();
            process.WaitForExit();
        }
    }
}
