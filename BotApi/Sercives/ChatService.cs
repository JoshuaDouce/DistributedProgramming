using BotApi.Interfaces;

namespace BotApi.Sercives
{
    public class ChatService : IChatService
    {
        public string GetResponse(string message)
        {
            return message switch
            {
                "Hello" => $"Hi, How can I help?",
                "Bye" => $"Goodbye",
                _ => "Sorry I don't understand, try something else.",
            };
        }
    }
}
