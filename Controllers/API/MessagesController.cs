using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace la_mia_pizzeria_crud_webapi.Controllers.API
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class MessagesController : ControllerBase
    {
        PizzaContext db;

        public MessagesController()
        {
            db = new();
        }

        [HttpPost]
        public IActionResult Send([FromBody] Message message)
        {

            db.Messages.Add(message);
            db.SaveChanges();

            return Ok();
        }
    }
}
