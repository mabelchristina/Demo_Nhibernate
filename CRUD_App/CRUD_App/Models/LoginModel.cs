using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRUD_App.Models
{
    public class LoginModel
    {
        public virtual string Email { get; set; }
        public virtual string Password { get; set; }
    }
}