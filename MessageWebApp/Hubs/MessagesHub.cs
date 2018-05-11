﻿using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace MessageWebApp.Hubs
{
    public class MessagesHub:Hub
    {
        private static string conString = ConfigurationManager.ConnectionStrings["Default1Connection"].ToString();

        public void Hello()
        {
            Clients.All.hello();
        }
        [HubMethodName("sendMessages")]
        public static void SendMessages()
        {
            IHubContext context = GlobalHost.ConnectionManager.GetHubContext<MessagesHub>();
            context.Clients.All.updateMessages();
        }
    }

}