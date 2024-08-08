using System;
using System.Collections.Concurrent;
using System.Reflection;
using System.Threading;
using attackServer.ServerBeckend;
using WebSocketSharp.Server;

namespace attackServer.ServerBeckend
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WebSocketServer wss = new WebSocketServer("ws://localhost:3108");
            wss.AddWebSocketService<MissileHandler>("/MissileHandler", () => new MissileHandler(wss));
            wss.Start();

            Console.WriteLine("Backend server is running. Press Enter to exit...");
            Console.ReadLine();
            wss.Stop();

        }
    }
}
