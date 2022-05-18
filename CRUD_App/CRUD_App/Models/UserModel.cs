using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRUD_App.Models
{
    public class UserModel
    {
        public virtual int UserID { get; set; }
        public virtual string Email { get; set; }
        public virtual string Password { get; set; }
    }
}