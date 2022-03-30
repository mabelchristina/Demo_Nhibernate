using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRUD_App.Models
{
    public class NotesModel
    {
            public virtual int? NoteID
            {
                get;
                set;
            }
            public virtual string Title
            {
                get;
                set;
            }
            public virtual string Description
            {
                get;
                set;
            }
            public virtual DateTime Reminder
            {
                get;
                set;
            }
            public virtual string Color
            {
                get;
                set;
            }
            public virtual string Image
            {
                get;
                set;
            }
    }
}