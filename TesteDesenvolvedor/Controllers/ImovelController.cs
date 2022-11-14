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

         [HttpPost]
        public IActionResult Editar(Imovel imovel)
        {
            var imovelBanco = _context.Imoveis.Find(imovel.Id);

            imovelBanco.TipoNegocio = imovel.TipoNegocio;
            imovelBanco.Cliente = imovel.Cliente;
            imovelBanco.ValorImovel = imovel.ValorImovel;
            imovelBanco.DataPublicacao = imovel.DataPublicacao;
            imovelBanco.Endereco = imovel.Endereco;
            imovelBanco.Descricao = imovel.Descricao;

            _context.Imoveis.Update(imovelBanco);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Detalhes(int id)
        {
            var imovel = _context.Imoveis.Find(id);

            if (imovel == null)
                return RedirectToAction(nameof(Index));

            return View(imovel);
        }

        public IActionResult Deletar(int id)
        {
             var imovel = _context.Imoveis.Find(id);

            if (imovel == null)
                return RedirectToAction(nameof(Index));

            return View(imovel);
        }

        [HttpPost]
        public IActionResult Deletar(Imovel imovel)
        {
            var imovelBanco = _context.Imoveis.Find(imovel.Id);

            _context.Imoveis.Remove(imovelBanco);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
        
        
        
        
    }
}