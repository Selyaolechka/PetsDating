using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PetsDating.Startup))]
namespace PetsDating
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
