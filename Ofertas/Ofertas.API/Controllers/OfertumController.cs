using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Ofertas.API.Entities;

namespace Ofertas.API.Controllers
{
    public class OfertumController : Controller
    {
        private readonly OfertasContext OfertasContext;
        public OfertumController(OfertasContext OfertasContext)
        {
            this.OfertasContext = OfertasContext;
        }


        public IActionResult Index()
        {
            return View();
        }
    }
}
