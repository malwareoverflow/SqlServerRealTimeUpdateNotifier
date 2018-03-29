using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace SIGNALRDB
{
    public class MessageSender : Hub
    {
        public void DispatchToClient(IEnumerable<string> messages)
        {
            foreach (string message in messages)
                Clients.All.broadcastMessage(message);
        }
        public MessageSender()
        {
            Action<IEnumerable<string>> dispatcher = (messages) => { DispatchToClient(messages); };
            //We create a singleton instance of PushMessaging
            PushMessaging.GetInstance(dispatcher);
        }

    }
}