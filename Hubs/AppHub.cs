using Microsoft.AspNetCore.SignalR;

namespace IFrameSignalR.Hubs
{
	public class AppHub : Hub
	{
		public Task SendMessage(string connectionId, string message)
		{
			return Clients.Client(connectionId).SendAsync("ReceiveMessage", message);
		}
	}
}
