using NHibernate;
using NHibernate.Cfg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRUD_App.Models
{
    public class OpenSessionNHibernate
    {
        public static ISession OpenSession()
        {
            var configuration = new Configuration();

            var configurationPath = HttpContext.Current.Server.MapPath(@"~\DAL\nh.configuration.xml");

            configuration.Configure(configurationPath);

            var employeeConfigurationFile = HttpContext.Current.Server.MapPath(@"~\DAL\Employee.mapping.xml");

            configuration.AddFile(employeeConfigurationFile);

            ISessionFactory sessionFactory = configuration.BuildSessionFactory();

            return sessionFactory.OpenSession();
        }
    }
}