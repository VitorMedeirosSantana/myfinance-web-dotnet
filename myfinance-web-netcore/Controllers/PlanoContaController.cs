using Microsoft.AspNetCore.Mvc;
using myfinance_web_netcore.infrastructure;
using myfinance_web_netcore.Models;
using myfinance_web_netcore.Services;
using System.Diagnostics;

namespace myfinance_web_netcore.Controllers
{

    [Route("[Controller]")]
    public class PlanoContaController : Controller
    {
        private readonly IPlanoContaService _planoContaService;

        public PlanoContaController(IPlanoContaService planoContaService)
        {
            _planoContaService = planoContaService;
        }

        [Route("Index")]
        
        public IActionResult Index()
        {
            ViewBag.Lista = _planoContaService.ListarRegistros();
            return View();
        }

        [HttpGet]
        [HttpPost]
        [Route("Cadastro")]

        public IActionResult Cadastro(PlanoContaModel model)
        {
            return View();
        }

    }
}
