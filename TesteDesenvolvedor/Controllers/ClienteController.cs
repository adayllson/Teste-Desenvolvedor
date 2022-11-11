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

        public IActionResult Editar(int id)
        {
            var cliente = _context.Clientes.Find(id);

            if (cliente == null)
                return RedirectToAction(nameof(Index));

            return View(cliente);
        }

        [HttpPost]
        public IActionResult Editar(Cliente cliente)
        {
            var clienteBanco = _context.Clientes.Find(cliente.Id);

            clienteBanco.Nome = cliente.Nome;
            clienteBanco.Email = cliente.Email;
            clienteBanco.CPF = cliente.CPF;

            _context.Clientes.Update(clienteBanco);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Detalhes(int id)
        {
            var cliente = _context.Clientes.Find(id);

            if (cliente == null)
                return RedirectToAction(nameof(Index));

            return View(cliente);
        }

        public IActionResult Deletar(int id)
        {
             var cliente = _context.Clientes.Find(id);

            if (cliente == null)
                return RedirectToAction(nameof(Index));

            return View(cliente);
        }
    }
}