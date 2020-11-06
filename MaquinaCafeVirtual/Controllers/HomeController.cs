using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MaquinaCafeVirtual.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using MaquinaCafeVirtual.Data;
using Microsoft.EntityFrameworkCore;

namespace MaquinaCafeVirtual.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;


        private readonly Context _context;

        public HomeController(ILogger<HomeController> logger, Context context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {

            List<SelectListItem> items = new SelectList(_context.Produto, "Id", "Nome").ToList();
            items.Insert(0, (new SelectListItem { Text = "-- Selecione uma opção --", Value = "0" }));
            ViewData["ProdutoId"] = items;


            //ViewData["ProdutoId"] = new SelectList(_context.Produto, "Id", "Nome");
            ViewData["Moedas"] = await _context.Moeda.ToListAsync();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpGet]
        public async Task<ActionResult> BuscarValor(int produtoId)
        {
            var produto = await _context.Produto
                .FirstOrDefaultAsync(m => m.Id == produtoId);
            if (produto == null)
            {
                return Json(new { success = false, message = "Erro na busca por preço de produto!" });
            }

            return Json(new { success = true, message = "", valor = produto.Valor });
        }

        [HttpPost]
        public async Task<ActionResult> Comprar(int produtoId, string valorPago, string troco)
        {
            try
            {
                var pedido = new Pedido
                {
                    ProdutoId = produtoId,
                    Troco = (float)Convert.ToDecimal(troco),
                    ValorPago = (float)Convert.ToDecimal(valorPago)
                };

                _context.Add(pedido);
                await _context.SaveChangesAsync();
                return Json(new { success = true, message = "Compra realizada com sucesso!", trocoDevolver = troco });
            }
            catch (Exception ex)
            {
                return Json(new { success = true, message = "Erro: " + ex.Message, trocoDevolver = troco });
            }
        }

        public async Task<IActionResult> Pedidos()
        {
            var context = _context.Pedido.Include(p => p.Produto);
            return View(await context.ToListAsync());
        }
    }
}
