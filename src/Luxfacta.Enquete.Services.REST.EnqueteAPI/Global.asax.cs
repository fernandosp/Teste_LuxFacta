using System.Web.Http;
using Luxfacta.Enquete.Application.AutoMapper;


namespace Luxfacta.Enquete.Services.REST.EnqueteAPI
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            AutoMapperConfig.RegisterMappings();
        }
    }
}
