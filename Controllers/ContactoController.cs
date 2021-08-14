using Microsoft.AspNetCore.Mvc;
using demomvc.Models;

namespace demomvc.Controllers
{
    public class ContactoController:Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            ViewData["Message"] = "El contacto ya esta registrado";
            return View("Index");
        }

    }
}