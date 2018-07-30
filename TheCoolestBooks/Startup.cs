using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TheCoolestBooks.Startup))]
namespace TheCoolestBooks
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
