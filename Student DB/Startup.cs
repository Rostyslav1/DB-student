using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Student_DB.Startup))]
namespace Student_DB
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
