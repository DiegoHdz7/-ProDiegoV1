using Abp.Application.Services;
using ProDiegoV1.Students.Dto;

namespace ProDiegoV1.Students
{
    public interface IStudentAppService : IAsyncCrudAppService<StudentDto, int, PagedStudentResultRequestDto, CreateStudentDto, UpdateStudentDto>
    {
      
    }
}

