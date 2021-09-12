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
        private readonly ILoginRepository _loginRepository;
        public UsuarioController(INotificador notificador, IUsuarioRepository usuarioRepository, ILoginRepository loginRepository) : base(notificador)
        {
            _usuarioRepository = usuarioRepository;
            _loginRepository = loginRepository;
        }

        [HttpDelete]
        [SwaggerResponse(200, type: typeof(Response))]
        public async Task<ActionResult> DeletarUsuario(int idUsuario)
        {
            try
            {
                if (!ModelState.IsValid) return CustomResponse(ModelState);
                var usuario = await _usuarioRepository.ObterPorId(idUsuario);
                if(usuario == null)
                {
                    NotificarErro($"Usuário com id {idUsuario} não encontrado no sistema.");
                    return CustomResponse();
                }
                var loginUsu =  _loginRepository.BuscarLoginPorIdUsuario(idUsuario);

                await _loginRepository.Remover(loginUsu);

                //await _usuarioRepository.Remover(usuario);
            }
            catch (System.Exception e)
            {

                NotificarErro(e.Message);
            }
            return CustomResponse();
        }


    }
}