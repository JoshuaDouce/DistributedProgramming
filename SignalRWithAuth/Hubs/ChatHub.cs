using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace SignalRWithAuth.Hubs
{
    public class ChatHub : Hub
    {
        static readonly HttpClient client = new HttpClient();

        public async Task SendMessageToBot(string user, string message)
        {
            var url = $"https://localhost:44306/api/randomresponse/{message}";

            var response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();

            await Clients.Caller.SendAsync("ReceiveMessage", user, message);
            await Clients.Caller.SendAsync("ReceiveMessage", "Bot", responseBody);
        }

        public async Task SendMessageToUser(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}
