using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Data.Entity;
using AspNetMVC_iisTest.Models;

namespace AspNetMVC_iisTest {
  public class MvcApplication : HttpApplication {
    protected void Application_Start() {
      Database.SetInitializer(new AspTestInitialiser());
      AreaRegistration.RegisterAllAreas();
      FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
      RouteConfig.RegisterRoutes(RouteTable.Routes);
      BundleConfig.RegisterBundles(BundleTable.Bundles);
    }
  }
}
