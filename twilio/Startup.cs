using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(twilio.Startup))]
namespace twilio
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
