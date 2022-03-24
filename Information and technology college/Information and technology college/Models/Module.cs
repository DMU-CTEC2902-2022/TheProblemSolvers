using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Information_and_technology_college.Models
{
    public class Module
    {
        public virtual int moduleid { get; set; }
        public virtual int Courseid { get; set; }
        public virtual string moduleTitle { get; set; }
        public virtual string moduledescription { get; set; }
    }
}
