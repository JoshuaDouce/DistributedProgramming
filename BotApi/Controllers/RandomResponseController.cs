using BotApi.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BotApi.Controllers
{
    [Route("api/[controller]")]
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
        public string Get()
        {
            return ChatService.GetResponse("Message");
        }
    }
}
