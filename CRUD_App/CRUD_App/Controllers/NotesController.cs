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
    public class NotesController : ApiController
    {
        //NHibernate Session  

        ISession session = OpenSessionNHibernateforNote.OpenSession();
        //Get all Notes
        public List<NotesModel> GetListNotes()
        {
            List<NotesModel> Note = session.Query<NotesModel>().ToList();
            return Note;
        }
        //Add New Note  
        [Authorize]
        [HttpPost]
        public HttpResponseMessage AddNewNote(NotesModel Note)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (ITransaction transaction = session.BeginTransaction())
                    {
                        session.Save(Note);
                        transaction.Commit();
                    }
                    return Request.CreateResponse(HttpStatusCode.OK, Note);
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
        //Add New Note
        [Route("xlogin")]
        [HttpPost]
        public HttpResponseMessage AddNew(NotesModel Note)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (ITransaction transaction = session.BeginTransaction())
                    {
                        session.Save(Note);
                        transaction.Commit();
                    }
                    return Request.CreateResponse(HttpStatusCode.OK, Note);
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
        //Get Note using Id 
        [HttpGet]
        public NotesModel DetailsOfNote(int id)
        {
            var Note = session.Get<NotesModel>(id);
            return Note;
        }
        //UpdateNote  
        [HttpPut]
        public HttpResponseMessage UpdateEmployee(NotesModel Note)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var emp = session.Get<NotesModel>(Note.NoteID);
                    emp.Title = Note.Title;
                    emp.Description = Note.Description;
                    emp.Reminder = DateTime.Now; ;
                    emp.Color = Note.Color;
                    emp.Image = Note.Image;
                    using (ITransaction transaction = session.BeginTransaction())
                    {
                        session.Save(emp);
                        transaction.Commit();
                    }
                    return Request.CreateResponse(HttpStatusCode.OK, emp);
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
        //Delete Note  
        [HttpDelete]
        public HttpResponseMessage DeleteNote(int id)
        {
            try
            {
                var Note = session.Get<NotesModel>(id);
                if (Note != null)
                {
                    using (ITransaction transaction = session.BeginTransaction())
                    {
                        session.Delete(Note);
                        transaction.Commit();
                    }
                    return Request.CreateResponse(HttpStatusCode.OK, "Success");
                }
                else
                {
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Error !");
                }
            }
            catch (Exception ex)
            {

                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }
    }
}
