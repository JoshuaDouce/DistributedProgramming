using System;
using BotApi.Interfaces;

namespace BotApi.Sercives
{
    public class ChatService : IChatService
    {
        public string GetResponse(string message)
        {
            var random = new Random();

            var x = random.Next(0, 5);

            switch (x)
            {
                case 0:
                    return "Ranom message 1";
                case 1:
                    return "Ranom message 2";
                case 2:
                    return "Ranom message 3";
                case 3:
                    return "Ranom message 4";
                case 4:
                    return "Ranom message 5";
                default:
                    return "Ranom message 6";
            }
        }
    }
}
