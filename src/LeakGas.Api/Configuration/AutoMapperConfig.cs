using AutoMapper;
using LeakGas.Api.DTO;
using LeakGas.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeakGas.Api.Configuration
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {

            CreateMap<UsuarioApartamento, CondominioDTO>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Apartamento.Id))
                .ForMember(dest => dest.Nome, opt => opt.MapFrom(src => src.Apartamento.Nome))
                .ForMember(dest => dest.NumeroEndereco, opt => opt.MapFrom(src => src.Apartamento.NumeroEndereco))
                .ForMember(dest => dest.Cep, opt => opt.MapFrom(src => src.Apartamento.Cep))
                .ForMember(dest => dest.Endereco, opt => opt.MapFrom(src => src.Apartamento.Endereco));

            CreateMap<ViewAlarme, OcorrenciasDTO>().ForMember(dest => dest.Ativo, opt => opt.MapFrom(src => src.DescricaoStatus != null && src.DescricaoStatus != "FECHADO" ? true : false)).ReverseMap();
        }
    }
}
