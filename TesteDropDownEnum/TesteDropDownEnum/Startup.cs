using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TesteDropDownEnum.Startup))]
namespace TesteDropDownEnum
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
