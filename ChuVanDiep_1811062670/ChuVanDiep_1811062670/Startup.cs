using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ChuVanDiep_1811062670.Startup))]
namespace ChuVanDiep_1811062670
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
