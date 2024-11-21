using System.Web.Http;

public class WebApiApplication : System.Web.HttpApplication
{
    protected void Application_Start()
    {
        // Configure Web API
        GlobalConfiguration.Configure(WebApiConfig.Register);
    }
}
