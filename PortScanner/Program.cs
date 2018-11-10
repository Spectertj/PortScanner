using System;
using ScanLib;
using UtilLib;

namespace PortScanner
{
    class Program
    {
        private static String IPAdrress;
        private static String StartPort;
        private static String EndPort;
        private static Utils util = new Utils();
        private static Scanner scanner = new Scanner();
        static void Main(string[] args)
        {
            Console.WriteLine("Insert IP Address");
            IPAdrress = Console.ReadLine();
            ValidateIP(IPAdrress);
            Console.WriteLine("Insert start Port");
            StartPort = Console.ReadLine();
            ValidatePort(StartPort);
            Console.WriteLine("Insert end Port");
            EndPort = Console.ReadLine();
            ValidatePort(EndPort);

            scanner.Scan(IPAdrress, StartPort, EndPort);
        }
        private static void ValidateIP(String ip)
        {
            if (!util.IpValidator(IPAdrress))
            {
                Console.WriteLine("Error with ip write it again");
            }
        }
        private static void ValidatePort(String port)
        {
            if (!util.PortValidator(port))
            {
                Console.WriteLine("Error with port write it again");
            }
        }
    }
}
