using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LeakGas.Api.Wrapper;
using LeakGas.Business.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace LeakGas.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OcorrenciaController : MainController
    {
        public OcorrenciaController(INotificador notificador) : base(notificador)
        {
        }

        [HttpPost("vazamento")]
        [SwaggerResponse(200, type: typeof(Response))]
        public async Task<ActionResult> RegistrarVazamento(int idApartamento)
        {
            if (!ModelState.IsValid) return CustomResponse(ModelState);

            if (idApartamento == 0)
            {
                NotificarErro("Id incorreto.");
                return CustomResponse();
            }
            return CustomResponse();
        }
    }
}