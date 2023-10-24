using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Process process = new Process();
            process.StartInfo = new ProcessStartInfo(@"..\..\..\task_3_app\bin\Debug\task_3_app.exe");
            process.StartInfo.Arguments = "10 5 /";
            process.Start();
            process.WaitForExit();
        }
    }
}
