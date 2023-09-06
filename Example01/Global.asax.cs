using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Example01
{
    public class MvcApplication : System.Web.HttpApplication
    {
        //yazsan�zda yazmasan�zda �al��an baz� metodlar var. Gidin ara�t�r�n. 3.�dev.
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            //��phe
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
