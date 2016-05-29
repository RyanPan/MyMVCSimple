using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyMVCSimple.Startup))]
namespace MyMVCSimple
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
