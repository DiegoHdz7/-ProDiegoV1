using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using ProDiegoV1.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProDiegoV1.students.Dto
{
    [AutoMapFrom(typeof(Student))]
    public class StudentDto : EntityDto<int>
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string ProgramName { get; set; }
        public string DoB { get; set; }
        public bool IsActive { get; set; }
        ///Dto.cs.fields1///

        public DateTime CreationTime { get; set; }

        public long? CreatorUserId { get; set; }

    }
}
