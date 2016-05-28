using Microsoft.AspNet.SignalR;

namespace SignalR_Chat_SelfHost_Server
{
    public class ChatHub : Hub
    {
        public void SendMessage(string name, string message)
        {
            Clients.All.broadcastMessage(name, message);
            Program.LogReceivedMessages(name, message);
        }
    }
}
