using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Diagnostics;
using teste.Data;
using teste.Models;
using teste.Repositorio;
//
namespace teste.Controllers
{
    public class RelatoriosController : Controller
    {
        private readonly BancoContext _db;
        public RelatoriosController(BancoContext db) 
        {
            _db = db;
        }    
        public IActionResult Index()
        {
            IEnumerable<RelatorioModel> Relatorios = _db.Relatorios;
            return View(Relatorios);
        }
        public IActionResult ApagarConfirmacao()
        {
            return View();
        }
        public IActionResult Editar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar()
        {
            
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
    }
}
