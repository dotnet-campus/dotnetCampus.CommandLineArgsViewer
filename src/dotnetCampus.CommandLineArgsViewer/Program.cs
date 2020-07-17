using dotnetCampus.Cli;

using dotnetCampus.CommandLineArgsViewer;

namespace dotnetCampus.CommandLineViewer
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
