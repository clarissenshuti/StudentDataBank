﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StudentService.Models.Entity;

namespace StudentService.Models
{
    public class StudentViewModel
    {
        public UniversityStudent Student { get; set; }
        public IQueryable<StudentCourseTaken> Courses { get; set; }
        public IQueryable<StudentProgramEnrollment> Programs { get; set; }
        public IQueryable<StudentLinkToOtherUniversity> Links { get; set; }
    }
}