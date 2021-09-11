using LeakGas.Api.Wrapper;
using LeakGas.Business.Interfaces;
using LeakGas.Business.Interfaces.Data;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.Threading.Tasks;

namespace LeakGas.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CondominioController : MainController
    {
        private readonly ICondominioRepository _condominioRepository;
        public CondominioController(INotificador notificador, ICondominioRepository condominioRepository) : base(notificador)
        {
            _condominioRepository = condominioRepository;
        }

        [HttpGet]
        [SwaggerResponse(200, type: typeof(Response))]
        public async Task<ActionResult> ListaCondominiosByIdUsuario(int idUsuario)
        {
            try
            {
                if (!ModelState.IsValid) return CustomResponse(ModelState);

                return CustomResponse();
            }
            catch (System.Exception e)
            {

                NotificarErro(e.Message);
            }
            return CustomResponse();
        }
    }
}