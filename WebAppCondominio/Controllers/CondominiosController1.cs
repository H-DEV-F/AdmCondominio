using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAppCondominio.Models;

namespace WebAppCondominio.Controllers
{
    public class CondominiosController1 : Controller
    {
        public IActionResult Index()
        {
            List<Condominio> list = new List<Condominio>();
            list.Add(new Condominio { Id = 1, Nome = "Mar Azul", Bairro = "Parque Grajau" });
            list.Add(new Condominio { Id = 1, Nome = "Onda Qubrada", Bairro = "Jd Nakamura" });
            return View();
        }
    }
}
