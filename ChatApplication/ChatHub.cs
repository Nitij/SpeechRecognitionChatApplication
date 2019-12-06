using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace ChatApplication
{
    public class ChatHub : Hub
    {
        public void Send(string name, string message)
        {
            Clients.All.sendMessage(name, message);
        }
    }
}