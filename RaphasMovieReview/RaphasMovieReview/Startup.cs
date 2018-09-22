using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RaphasMovieReview.Startup))]
namespace RaphasMovieReview
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
