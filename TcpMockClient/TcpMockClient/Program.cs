using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace TcpMockClient
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpClient clientSocket = new TcpClient("127.0.0.1", 7000);
            Console.WriteLine("Client ready");

            Stream ns = clientSocket.GetStream(); 
            StreamReader sr = new StreamReader(ns);
            StreamWriter sw = new StreamWriter(ns);
            sw.AutoFlush = true; 

            string message = Console.ReadLine();
            sw.WriteLine(message);
            string serverAnswer = sr.ReadLine();

            Console.WriteLine("Server: " + serverAnswer);

            Console.WriteLine("No more from server. Press Enter");
            Console.ReadLine();

            ns.Close();

            clientSocket.Close();

        }}
    }
