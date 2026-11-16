using Microsoft.AspNetCore.Mvc;

namespace MiPrimerServicioREST.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MonedasController : ControllerBase
    {
        // GET: api/Monedas/USD/EUR/100
        [HttpGet("{de}/{a}/{cantidad}")]
        public ActionResult<double> Get(string de, string a, double cantidad)
        {
            double factor = (de.ToUpper(), a.ToUpper()) switch
            {
                ("USD", "EUR") => 0.92,
                ("EUR", "USD") => 1.09,
                ("USD", "MXN") => 20.10,
                ("MXN", "USD") => 0.050,
                _ => 1.0
            };

            double resultado = Math.Round(cantidad * factor, 2);
            return Ok(resultado);
        }
    }
}