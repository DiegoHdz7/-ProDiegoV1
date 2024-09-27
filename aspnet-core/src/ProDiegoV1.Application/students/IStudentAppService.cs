using Abp.Application.Services;
using ProDiegoV1.students.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProDiegoV1.students
{
    public interface IStudentAppService : IAsyncCrudAppService<StudentDto, int, PagedStudentResultRequestDto, CreateStudentDto, UpdateStudentDto>
    {

    }
}
