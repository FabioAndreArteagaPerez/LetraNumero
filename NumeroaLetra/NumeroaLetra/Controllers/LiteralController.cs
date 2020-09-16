using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NumeroaLetra.Helpers;

namespace NumeroaLetra.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LiteralController : ControllerBase
    {
        [HttpGet]
        public string literalget(int numero)
        {
            return Conversores.NumeroALetras(numero);
        }
        [HttpPost]
        public string literalpost([FromHeader]int numero)
        {
            return Conversores.NumeroALetras(numero);
        }
    }
}
