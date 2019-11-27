using BotApi.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BotApi.Controllers
{
    [ApiController]
    public class RandomResponseController : ControllerBase
    {
        private static IChatService ChatService;

        public RandomResponseController(IChatService chatService)
        {
            ChatService = chatService;
        }

        // GET: api/RandomResponse
        [HttpGet]
        [Route("api/randomresponse/{message}")]
        public string Get(string message)
        {
            return ChatService.GetResponse(message);
        }
    }
}
