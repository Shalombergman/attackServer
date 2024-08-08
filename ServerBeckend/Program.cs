using System;
using System.Collections.Concurrent;
using System.Reflection;
using System.Threading;
using attackServer.ServerBeckend;
using WebSocketSharp.Server;
namespace attackServer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WebSocketServer wss = new WebSocketServer("ws://localhost:3108");
            wss.AddWebSocketService<MissileHandler>("C:\\kodcode2\\Core8\\attackServer\\ServerBeckend\\MissileHandler.cs", () => new MissileHandler(wss));
            wss.Start();
            Console.WriteLine("Backend server is running. Press Enter to exit...");
            Console.ReadLine();
            wss.Stop();


        }
    }
}
