using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ibta.edu.br.meet.Startup))]
namespace ibta.edu.br.meet
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
