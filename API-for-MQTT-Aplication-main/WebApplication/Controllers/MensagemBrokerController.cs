using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication.Data;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    [ApiController]
    [Route("Mensagem")]
    public class MensagemBrokerController : ControllerBase
    {
        [HttpGet]
        [Route("")]

        public async Task<ActionResult<List<Msg>>> Get([FromServices] DataContext context)
        {
            var mensagens = await context.MensagemBrokers.ToListAsync();
            return mensagens;
        }

        [HttpPost]
        [Route("")]

        public async Task<ActionResult<Msg>> Post ([FromServices] DataContext context, [FromBody] MensagemBroker model)
        {
            if(ModelState.IsValid)
            {
                context.MensagemBrokers.Add(model);
                await context.SaveChangesAsync();
                return model;
                
            }
            else
            {
                return BadRequest(ModelState);
            }
        }
    }
}
