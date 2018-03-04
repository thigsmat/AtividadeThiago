
using AtividadeThiagoMatta.Api.Apresentacao.ViewModels;
using AtividadeThiagoMatta.Dominio.Entities;
using AutoMapper;
using System.Collections.Generic;

namespace AtividadeThiagoMatta.Api.Apresentacao.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<Livro, LivroViewModel>();
        }
    }
}