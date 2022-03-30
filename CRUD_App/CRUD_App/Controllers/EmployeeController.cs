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
    public class EmployeeController : ApiController
    {
        //NHibernate Session  
        ISession session = OpenSessionNHibernate.OpenSession();
        //Get All Employee  
        public List<EmployeeModel> GetListEmployee()
        {
            List<EmployeeModel> employee = session.Query<EmployeeModel>().ToList();
            return employee;
        }
        //GetEmployeeData  
        [HttpGet]
        public EmployeeModel DetailsEmployee(int id)
        {
            var employee = session.Get<EmployeeModel>(id);
            return employee;
        }
    }
}
