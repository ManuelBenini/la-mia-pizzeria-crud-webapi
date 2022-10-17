using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Models;

namespace la_mia_pizzeria_crud_webapi.Controllers.API
{
    //[Route("api/[controller]/[Action]")]
    [Route("api/[controller]/[Action]")]
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
        [HttpGet]
        public IActionResult SearchPizzas(string userSearch)
        {
            List<Pizza> pizzas = db.Pizzas.Where(p => p.Name.ToLower().Contains(userSearch.ToLower() )).ToList();

            return Ok(pizzas);
        }
        [HttpGet]
        public IActionResult Show(int id)
        {
            Pizza pizza = db.Pizzas.Where(p => p.PizzaId == id).FirstOrDefault();

            return Ok(pizza);
        }
    }
}
