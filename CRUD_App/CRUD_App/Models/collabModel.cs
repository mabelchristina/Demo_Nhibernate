using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CRUD_App.Models
{
    public class collabModel
    {
        public virtual int? collabID
        {
            get;
            set;
        }
        public virtual string collabEmail
        {
            get;
            set;
        }

        public virtual int NoteID
        {
            get;
            set;
        }
        //[JsonIgnore]
        //public virtual NotesModel NotesModel { get; set; }
    }
}