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

            CreateMap<UsuarioCondominio, CondominioDTO>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Condominio.Id))
                .ForMember(dest => dest.Nome, opt => opt.MapFrom(src => src.Condominio.Nome))
                .ForMember(dest => dest.NumeroEndereco, opt => opt.MapFrom(src => src.Condominio.NumeroEndereco))
                .ForMember(dest => dest.Endereco, opt => opt.MapFrom(src => src.Condominio.Endereco));


        }
    }
}
