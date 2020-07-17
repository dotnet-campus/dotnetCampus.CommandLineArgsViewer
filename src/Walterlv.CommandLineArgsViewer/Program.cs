using dotnetCampus.Cli;

using Walterlv.CommandLineArgsViewer;

namespace Walterlv.CommandLineViewer
{
    class Program
    {
        static void Main(string[] args)
        {
            CommandLine.Parse(args)
                .AddHandler<Options>(x => x.Run(args))
                .Run();
        }
    }
}
