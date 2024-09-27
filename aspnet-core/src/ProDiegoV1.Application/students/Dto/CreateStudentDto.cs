﻿using Abp.AutoMapper;
using ProDiegoV1.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProDiegoV1.students.Dto
{
    [AutoMapTo(typeof(Student))]
    public class CreateStudentDto
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string ProgramName { get; set; }
        public string DoB { get; set; }
        public bool IsActive { get; set; }
        ///CreateDto.cs.fields1///

    }
}
