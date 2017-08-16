using Luxfacta.Enquete.Application;
using Luxfacta.Enquete.Application.Interfaces;
using Luxfacta.Enquete.Domain.Interfaces.Repository;
using Luxfacta.Enquete.Domain.Interfaces.Services;
using Luxfacta.Enquete.Domain.Services;
using Luxfacta.Enquete.Infra.Data.Context;
using Luxfacta.Enquete.Infra.Data.Interfaces;
using Luxfacta.Enquete.Infra.Data.Repository;
using Luxfacta.Enquete.Infra.Data.UoW;
using SimpleInjector;



namespace Luxfacta.Enquete.Infra.CrossCutting.IoC
{
    public class BootStrapper
    {
        public static void RegisterServices(Container container)
        {
            // Lifestyle.Transient => Uma instancia para cada solicitacao;
            // Lifestyle.Singleton => Uma instancia unica para a classe
            // Lifestyle.Scoped => Uma instancia unica para o request

            // App
            container.RegisterPerWebRequest<IEnqueteAppService, EnqueteAppService>();

            // Domain
            container.RegisterPerWebRequest<IEnqueteService, EnqueteService>();

            // Infra Dados
            container.RegisterPerWebRequest<IPollRepository, PollRepository>();
            container.RegisterPerWebRequest<IVoteRepository, VoteRepository>();
            container.RegisterPerWebRequest<IStatsRepository, StatsRepository>();
            container.RegisterPerWebRequest<IOptionRepository, OptionRepository>();
                        
            container.RegisterPerWebRequest<IUnitOfWork, UnitOfWork>();
            container.RegisterPerWebRequest<EnqueteContext>();

            //container.Register(typeof (IRepository<>), typeof (Repository<>));
        }
    }
}
