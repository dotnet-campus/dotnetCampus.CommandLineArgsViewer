using System;
using System.Runtime.InteropServices;

using dotnetCampus.Cli;

using Lsj.Util.Win32;

using Walterlv.CommandLineArgsViewer.Properties;

namespace Walterlv.CommandLineArgsViewer
{
    public class Options
    {
        [Option(nameof(NoExit))]
        public bool NoExit { get; set; }

        internal void Run(string[] args)
        {
            var kernel32CommandLine = Kernel32.GetCommandLine();
            var dotnetCommandLine = Environment.CommandLine;
            var shell32ArgsPtr = Shell32.CommandLineToArgvW(kernel32CommandLine, out var pNumArgs);
            var shell32Args = IntPtrToStringArray(shell32ArgsPtr, pNumArgs);
            var dotnetMainArgs = args;

            if (string.Equals(kernel32CommandLine.ToString(), dotnetCommandLine, StringComparison.Ordinal))
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine(LocalizableStrings.CommandLineHeader);
                Console.ResetColor();
                Console.WriteLine($"  {kernel32CommandLine}");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine(LocalizableStrings.CommandLineKernel32Header);
                Console.ResetColor();
                Console.WriteLine($"  {kernel32CommandLine}");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine(LocalizableStrings.CommandLineDotNetHeader);
                Console.ResetColor();
                Console.WriteLine($"  {dotnetCommandLine}");
            }

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(LocalizableStrings.CommandLineArgsHeader);
            Console.ResetColor();
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine($"[{i}] {args[i]}");
            }

            if (NoExit)
            {
                Console.WriteLine(LocalizableStrings.PressAnyKeyToExit);
                Console.ReadKey();
            }
        }

        private static string[] IntPtrToStringArray(IntPtr ptr, int length)
        {
            var values = new string[length];
            for (var i = 0; i < length; i++, ptr+=IntPtr.Size)
            {
                var stringPtr = Marshal.ReadIntPtr(ptr);
                var value = Marshal.PtrToStringUni(stringPtr);
                values[i] = value;
            }
            return values;
        }
    }
}
