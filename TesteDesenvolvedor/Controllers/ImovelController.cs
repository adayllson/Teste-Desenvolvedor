using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TesteDesenvolvedor.Context;

namespace TesteDesenvolvedor.Controllers
{
        public class ImovelController : Controller
    {
        private readonly ImobiliariaContext _context;

        public ImovelController(ImobiliariaContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var imoveis = _context.Imoveis.ToList();
            return View(imoveis);
        }

        public IActionResult Criar()
        {
            return View();
        }
    }
}