using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRUD_App.Models
{
    public class EmployeeModel
    {
        public virtual int? EmployeeID
        {
            get;
            set;
        }
        public virtual string FirstName
        {
            get;
            set;
        }
        public virtual string LastName
        {
            get;
            set;
        }
        public virtual string Gender
        {
            get;
            set;
        }
        public virtual string Designation
        {
            get;
            set;
        }
        public virtual int Salary
        {
            get;
            set;
        }
        public virtual string City
        {
            get;
            set;
        }
        public virtual string Country
        {
            get;
            set;
        }
    }
}