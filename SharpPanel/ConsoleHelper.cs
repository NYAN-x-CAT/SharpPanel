using System;

namespace SharpPanel
{
    public static class ConsoleHelper
    {
        public static void Info()
        {
            Console.WriteLine("[#]SharpPanel v1.0 - Admin Control Panel Finder");
            Console.WriteLine("[#]Developed       - NYAN CAT@hf");
            Console.WriteLine("[#]Website         - GitHub.com/NYAN-x-CAT");
            Console.WriteLine("\n");
        }

        public static void Banner()
        {
            Console.WriteLine(@"
███████╗██╗  ██╗ █████╗ ██████╗ ██████╗   ██████╗  █████╗ ███╗   ██╗███████╗██╗     
██╔════╝██║  ██║██╔══██╗██╔══██╗██╔══██╗  ██╔══██╗██╔══██╗████╗  ██║██╔════╝██║     
███████╗███████║███████║██████╔╝██████╔╝  ██████╔╝███████║██╔██╗ ██║█████╗  ██║     
╚════██║██╔══██║██╔══██║██╔══██╗██╔═══╝   ██╔═══╝ ██╔══██║██║╚██╗██║██╔══╝  ██║     
███████║██║  ██║██║  ██║██║  ██║██║       ██║     ██║  ██║██║ ╚████║███████╗███████╗
╚══════╝╚═╝  ╚═╝╚═╝  ╚═╝╚═╝  ╚═╝╚═╝       ╚═╝     ╚═╝  ╚═╝╚═╝  ╚═══╝╚══════╝╚══════╝
                                                                                 ");
        }
    }
}
