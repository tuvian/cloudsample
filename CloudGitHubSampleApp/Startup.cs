using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CloudGitHubSampleApp.Startup))]
namespace CloudGitHubSampleApp
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
