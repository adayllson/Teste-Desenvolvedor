using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TesteDesenvolvedor.Context;
using TesteDesenvolvedor.Models;

namespace TesteDesenvolvedor.Controllers
{
    
    public class ClienteController : Controller
    {
        private readonly ImobiliariaContext _context;

        public ClienteController(ImobiliariaContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var clientes = _context.Clientes.ToList();
            return View(clientes);
        }

        public IActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                _context.Clientes.Add(cliente);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(cliente);
        }
    }
}