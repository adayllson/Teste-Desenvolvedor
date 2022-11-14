using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TesteDesenvolvedor.Context;
using TesteDesenvolvedor.Models;

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

        [HttpPost]
        public IActionResult Criar(Imovel imovel)
        {
            if (ModelState.IsValid)
            {
                _context.Imoveis.Add(imovel);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(imovel);
        }
        public IActionResult Editar(int id)
        {
            var imovel = _context.Imoveis.Find(id);

            if (imovel == null)
                return RedirectToAction(nameof(Index));

            return View(imovel);
        }
        
        
        
        // public IActionResult Criar(Imovel imovel)
        // {
        //     if (ModelState.IsValid)
        //     {
        //         _context.Clientes.Add(cliente);
        //         _context.SaveChanges();
        //         return RedirectToAction(nameof(Index));
        //     }
        //     return View(cliente);
        // }
    }
}