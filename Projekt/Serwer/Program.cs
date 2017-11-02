using System;


namespace Projekt
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpServer TCP = new TcpServer();
            TCP.Listen();
        }
    }
}
