using Microsoft.AspNetCore.Mvc;
using formulariomatalu.Models;

namespace formulariomatalu.Controllers
{
    public class CarrerasController: Controller
    {
       public IActionResult Index()
        {
            return View();
        } 
    }
}