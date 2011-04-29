using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace RunInBackground
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.Error.WriteLine("Usage: RunInBackground fileName [arguments]");
                return;
            }
            var fileName = args[0];
            var arguments = string.Join(" ", args.Skip(1).Select((arg) => arg.Contains(' ') ? "\"" + arg + "\"" : arg).ToArray());
            ProcessStartInfo psi = new ProcessStartInfo(fileName, arguments);
            psi.WindowStyle = ProcessWindowStyle.Hidden;
            Process process = Process.Start(psi);
        }
    }
}
