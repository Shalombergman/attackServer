using System;
using System.Collections.Concurrent;
using System.Reflection;
using System.Text.Json;
using WebSocketSharp;
using WebSocketSharp.Server;

namespace attackServer.ServerBeckend
{
    internal class MissileHandler
    {
        private readonly WebSocketServer _wss;
        public MissileHandler(WebSocketServer wss)
        {
            _wss = wss;
        }
        protected override void OnMessage(MessageEventArgs e)
        {
            Console.WriteLine("data got is: " + e.Data);
        }
    }
}
