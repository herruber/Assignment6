using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Assignment6.Models
{
    public class Teacher
    {


        [Key]
        public int TeacherID { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Class> Classes { get; set; }

    }
}