using Abp.Application.Services;
using Abp.Authorization;
using Abp.Domain.Repositories;
using ProDiegoV1.Authorization;
using ProDiegoV1.models;
using ProDiegoV1.Students.Dto;


namespace ProDiegoV1.Students
{

    [AbpAuthorize(PermissionNames.Pages_Students)]
    public class StudentAppService : AsyncCrudAppService<Student, StudentDto, int, PagedStudentResultRequestDto, CreateStudentDto, UpdateStudentDto>, IStudentAppService
    {
        public StudentAppService
        (
            IRepository<Student, int> repository
        )
        : base(repository)
        {

        }

    }
}
