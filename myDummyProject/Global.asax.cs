using System.Web.Http;

namespace myDummyProject
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            // Register Web API routes
            GlobalConfiguration.Configure(WebApiConfig.Register);

            // Log to confirm application startup
            System.Diagnostics.Debug.WriteLine("Application_Start invoked.");
        }
    }
}
