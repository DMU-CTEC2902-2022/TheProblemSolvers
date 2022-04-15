using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Information_and_technology_college.Models
{
    public class course
    {
        public virtual int Coursecode  { get; set; }
        public virtual string CourseTitle { get; set; }
        public virtual string CourseDescription { get; set; }
    }
}