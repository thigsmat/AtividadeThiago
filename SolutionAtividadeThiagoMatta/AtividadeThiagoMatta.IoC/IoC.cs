using Ninject;
using AtividadeThiagoMatta.Aplicacao;
using AtividadeThiagoMatta.Aplicacao.Interface;
using AtividadeThiagoMatta.Dominio.Interfaces.Repositories;
using AtividadeThiagoMatta.Dominio.Interfaces.Services;
using AtividadeThiagoMatta.Dominio.Services;
using AtividadeThiagoMatta.Infra.Dados.Repositorio;

namespace AtividadeThiagoMatta.IoC
{
    public class IoC
    {
        public static void RegisterServices(IKernel kernel)
        {
            kernel.Bind(typeof(IAppServiceBase<>)).To(typeof(AppServiceBase<>));
            kernel.Bind<ILivroAppService>().To<LivroAppService>();

            kernel.Bind(typeof(IServiceBase<>)).To(typeof(ServiceBase<>));
            kernel.Bind<ILivroService>().To<LivroService>();

            kernel.Bind(typeof(IRepositoryBase<>)).To(typeof(RepositoryBase<>));
            kernel.Bind<ILivroRepository>().To<LivroRepository>();
        }
    }
}
