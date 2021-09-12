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
    public class OcorrenciaController : MainController
    {
        private readonly IOcorrenciaRepository _ocorrenciaRepository;
        public OcorrenciaController(INotificador notificador, IOcorrenciaRepository ocorrenciaRepository) : base(notificador)
        {
            _ocorrenciaRepository = ocorrenciaRepository;
        }

        [HttpPost("vazamento")]
        [SwaggerResponse(200, type: typeof(Response))]
        public async Task<ActionResult> RegistrarVazamento(int idApartamento, bool status)
        {
            try
            {
                if (!ModelState.IsValid) return CustomResponse(ModelState);


                var listaOcorrencias = await _ocorrenciaRepository.Buscar(o => o.IdApartamento == idApartamento);

                if (listaOcorrencias?.Count > 0)
                {
                    foreach (var item in listaOcorrencias)
                    {
                        item.IdStatus = status ? 1 : 3;
                        item.DataOcorrencia = DateTime.Now;
                        await _ocorrenciaRepository.Atualizar(item);
                    }
                }
                else
                {

                    await _ocorrenciaRepository.Adicionar(new Business.Models.Ocorrencia { DataOcorrencia = DateTime.Now, IdApartamento = idApartamento, IdStatus = status ? 1 : 3, TipoOcorrencia = 1, IdNotificacao = 1 });
                }
                if (idApartamento <= 0)
                {
                    NotificarErro("Id inválido.");
                    return CustomResponse();
                }
            }
            catch (Exception e)
            {

                NotificarErro(e.Message);
            }
            return CustomResponse();
        }
    }
}