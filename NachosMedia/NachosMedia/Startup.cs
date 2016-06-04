using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NachosMedia.Startup))]
namespace NachosMedia
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
