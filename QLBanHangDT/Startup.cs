using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(QLBanHangDT.Startup))]
namespace QLBanHangDT
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
