using Messages.Data;
using Messages.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Messages.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessagesController : ControllerBase
    {
        private readonly MessageDbContext context;

        public MessagesController(MessageDbContext context)
        {
            this.context = context;
        }

        [HttpGet(Name = "All")]
        [Route("all")]
        public async Task<ActionResult<IEnumerable<Message>>> AllOrderdByCreatedOnAscending()
        {
            return this.context.Messages
                               .OrderBy(message => message.CreatedOn)
                               .ToList();
        }

        [HttpPost(Name = "Create")]
        [Route("create")]
        public async Task<ActionResult> Create(MessageCreatedBindingModel messageCreatedBindingModel)
        {
            Message message = new Message
            {
                Content = messageCreatedBindingModel.Content,
                Username = messageCreatedBindingModel.User,
                CreatedOn = DateTime.UtcNow
            };

            await context.Messages.AddAsync(message);
            await context.SaveChangesAsync();
            return this.Ok();
        }
    }
}