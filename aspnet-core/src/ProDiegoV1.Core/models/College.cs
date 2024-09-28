using Abp.Domain.Entities.Auditing;
using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Abp.AutoMapper;

namespace ProDiegoV1.models
{
    [AutoMapFrom(typeof(College))]
    public class College : FullAuditedEntity<int>, IPassivable
    {
        public College()
        {
            this.CreationTime = DateTime.Now;
            this.IsActive = true;
        }

        public string Name { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public string GPS { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string Email { get; set; }
        public string DiegoString { get; set; }
        public bool IsActive { get; set; }

        //Navigation Property
       
        public ICollection<Student>? Students { get; set; } = new List<Student>();

    }
}
