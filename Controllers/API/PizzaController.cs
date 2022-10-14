using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace la_mia_pizzeria_crud_webapi.Controllers.API
{
    [Route("Guest/api/[controller]")]
    //[Route("[Page]/api/[controller]")]
    [ApiController]
    public class PizzaController : ControllerBase
    {
        PizzaContext db;

        public PizzaController()
        {
            db = new PizzaContext();
        }

        [HttpGet]
        public IActionResult Get()
        {
            List<Pizza> pizzas = db.Pizzas.ToList();

            return Ok(pizzas);
        }
    }
}
