using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Caching;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Contacts
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            Application["Contacts"] = new List<Contact>()
            {
                new Contact(){Id=1, FName="Yuvraj", LName="Dalvi", DOB=new DateTime(2005, 4, 3), Gender=Gender.Male, Hobbies= new List<Hobby>(){Hobby.Cricket, Hobby.Tennis}},
                new Contact(){Id=2, FName="Laxmi", LName="Dalvi", DOB=new DateTime(1978, 6, 30), Gender=Gender.Female, Hobbies= new List<Hobby>(){Hobby.Cooking, Hobby.Movies}}
            };
        }
    }
}
