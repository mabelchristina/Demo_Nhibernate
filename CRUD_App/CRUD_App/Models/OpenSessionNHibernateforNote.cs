using NHibernate;
using NHibernate.Cfg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRUD_App.Models
{
    public class OpenSessionNHibernateforNote
    {
        public static ISession OpenSession()
        {
            var configuration = new Configuration();

            var configurationPath = HttpContext.Current.Server.MapPath(@"~\DAL\nh.configuration.xml");

            configuration.Configure(configurationPath);

            var NoteConfigurationFile = HttpContext.Current.Server.MapPath(@"~\DAL\Notes.mapping.xml");

            configuration.AddFile(NoteConfigurationFile);

            ISessionFactory sessionFactory = configuration.BuildSessionFactory();

            return sessionFactory.OpenSession();
        }
    }
}