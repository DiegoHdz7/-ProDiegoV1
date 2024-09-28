using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using ProDiegoV1.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProDiegoV1.Colleges.Dto
{
    [AutoMapTo(typeof(College))]
    public class CreateCollegeDto : EntityDto<int>
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public string GPS { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string Email { get; set; }
        public string DiegoString { get; set; }
        public bool IsActive { get; set; }

    }
}
