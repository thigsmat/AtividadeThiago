
using AtividadeThiagoMatta.Api.Apresentacao.ViewModels;
using AtividadeThiagoMatta.Dominio.Entities;
using AutoMapper;
using System.Collections.Generic;

namespace AtividadeThiagoMatta.Api.Apresentacao.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<LivroViewModel, Livro>();
        }
    }
}