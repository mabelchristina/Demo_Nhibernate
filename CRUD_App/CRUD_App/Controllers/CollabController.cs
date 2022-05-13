using CRUD_App.Models;
using NHibernate;
using NHibernate.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CRUD_App.Controllers
{
    public class CollabController : ApiController
    {

        ISession session = OpenSessionNHibernateforNote.OpenSession();
        //Get all Notes
        public List<collabModel> GetListCollab()
        {
            List<collabModel> Collab = session.Query<collabModel>().ToList();
            return Collab;
        }
        //Add New Note  
        [HttpPost]
        public HttpResponseMessage AddNewCollab(collabModel Collab)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (ITransaction transaction = session.BeginTransaction())
                    {
                        session.Save(Collab);
                        transaction.Commit();
                    }
                    return Request.CreateResponse(HttpStatusCode.OK, Collab);
                }
                else
                {
                    return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Error !");
                }
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }
    }
}
