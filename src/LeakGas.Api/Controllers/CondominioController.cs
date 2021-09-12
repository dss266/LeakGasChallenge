using AutoMapper;
using LeakGas.Api.DTO;
using LeakGas.Api.Wrapper;
using LeakGas.Business.Interfaces;
using LeakGas.Business.Interfaces.Data;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LeakGas.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CondominioController : MainController
    {
        private readonly ICondominioRepository _condominioRepository;
        private readonly IUsuarioCondominioRepository _usuarioCondominioRepository;
        private readonly IMapper _mapper;
        public CondominioController(INotificador notificador, ICondominioRepository condominioRepository, IUsuarioCondominioRepository usuarioCondominioRepository, IMapper mapper) : base(notificador)
        {
            _condominioRepository = condominioRepository;
            _usuarioCondominioRepository = usuarioCondominioRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [SwaggerResponse(200, type: typeof(Response<CondominioDTO>))]
        public async Task<ActionResult> ListaCondominiosByIdUsuario(int idUsuario)
        {
            try
            {
                var listaUsuCondo =  await _usuarioCondominioRepository.BuscarListaCondominioPorIdUsuario(idUsuario);

                var response = _mapper.Map<IEnumerable<CondominioDTO>>(listaUsuCondo);

                return CustomResponse(response);
            }
            catch (System.Exception e)
            {

                NotificarErro(e.Message);
            }
            return CustomResponse();
        }

        ///TODO: Fazer método que trás occorrências abertas por condominio
    }
}