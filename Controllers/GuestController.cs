using Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Diagnostics;
using Microsoft.AspNetCore.Authorization;

namespace la_mia_pizzeria_crud_webapi.Controllers
{
    public class GuestController : Controller
    {
        PizzaContext db;

        public GuestController()
        {
            db = new();
        }

        public IActionResult Index() { return View(); }
        public IActionResult PizzasList() { return View(); }
        public IActionResult Show() { return View(); }

    }
}