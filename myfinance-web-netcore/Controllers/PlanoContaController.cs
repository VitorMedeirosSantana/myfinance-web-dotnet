using Microsoft.AspNetCore.Mvc;
using myfinance_web_netcore.infrastructure;
using myfinance_web_netcore.Models;
using myfinance_web_netcore.Services;
using System.Diagnostics;

namespace myfinance_web_netcore.Controllers
{
    public class PlanoContaController : Controller
    {
        private readonly IPlanoContaService _planoContaService;

        public PlanoContaController(IPlanoContaService planoContaService) 
        { 
            _planoContaService = planoContaService;
        }


        public IActionResult Index()
        {
            ViewBag.Lista = _planoContaService.ListarRegistros();
            return View();
        }

    }
}
