using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using teste.Data;
using teste.Models;
using teste.Repositorio;

namespace teste.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger; IRelatorioRepositorio _relatorioRepositorio;

        public HomeController(ILogger<HomeController> logger, IRelatorioRepositorio relatorioRepositorio)
        {
            _logger = logger;
            _relatorioRepositorio = relatorioRepositorio;
        }

        public IActionResult Index()
        {
            
            return View();
        }

        public IActionResult Privacy()
        {
            List<RelatorioModel> relatorios = _relatorioRepositorio.BuscarTodos();
            return View(relatorios);
        }

        public IActionResult ApagarConfirmacao()
        {
            return View();
        }

        public IActionResult Editar()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public IActionResult Criar(RelatorioModel relatorio)
        {
            _relatorioRepositorio.Adicionar(relatorio);
            return RedirectToAction("Index");
        }
    }
}