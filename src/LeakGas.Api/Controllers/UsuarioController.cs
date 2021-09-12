using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LeakGas.Api.Wrapper;
using LeakGas.Business.Interfaces;
using LeakGas.Business.Interfaces.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace LeakGas.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : MainController
    {
        private readonly IUsuarioRepository _usuarioRepository;
        public UsuarioController(INotificador notificador, IUsuarioRepository usuarioRepository) : base(notificador)
        {
            _usuarioRepository = usuarioRepository;
        }

        [HttpDelete]
        [SwaggerResponse(200, type: typeof(Response))]
        public async Task<ActionResult> DeletarUsuario()
        {
            try
            {
                if (!ModelState.IsValid) return CustomResponse(ModelState);

               
            }
            catch (System.Exception e)
            {

                NotificarErro(e.Message);
            }
            return CustomResponse();
        }


    }
}