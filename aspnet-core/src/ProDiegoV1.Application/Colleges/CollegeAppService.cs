using Abp.Application.Services;
using ProDiegoV1.models;
using ProDiegoV1.Students.Dto;
using ProDiegoV1.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProDiegoV1.Colleges.Dto;
using Abp.Domain.Repositories;
using Abp.Authorization;
using ProDiegoV1.Authorization;
using Abp.ObjectMapping;
using ProDiegoV1.Authorization.Users;
using Abp.AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace ProDiegoV1.Colleges
{
    [AbpAuthorize(PermissionNames.Pages_Colleges)]
    public class CollegeAppService : AsyncCrudAppService<College, CollegeDto, int, PagedCollegeResultRequestDto, CreateCollegeDto, UpdateCollegeDto>, ICollegeAppService
    {

        private readonly IRepository<College, int> _collegeRepository;
        private readonly IRepository<Student, int> _studentRepository;
        private readonly IObjectMapper _objectMapper;

        public CollegeAppService(IRepository<College, int> collegeRepository, IObjectMapper objectMapper, IRepository<Student, int> studentRepository)
      : base(collegeRepository)
        {
            _collegeRepository = collegeRepository;
            _studentRepository = studentRepository;
            _objectMapper = objectMapper;

        }

        public async  Task<List<CollegeDto>> GetAllColleges()
        {

            try
            {
                Logger.Info($"GetAllColleges");
                var colleges = await _collegeRepository.GetAllListAsync();
                var response = _objectMapper.Map<List<CollegeDto>>(colleges);

              
                var allStudents = await _studentRepository.GetAllIncluding().ToListAsync();

                foreach (var college in response)
                {
                   
                    var students = allStudents.Where(student => student.CollegeId == college.Id).ToList();
                    college.Students = _objectMapper.Map<ICollection<StudentDto>>(students);
                }

               
                return response;
            }
            catch (Exception ex)
            {
              
                Logger.Error("Error creating college", ex);
                throw; 
            }
        }




        public async Task<College> CreateCollege(CreateCollegeDto college)
        {
            var mappedCollege = _objectMapper.Map<College>(college);
           return  _collegeRepository.Insert(mappedCollege);
        }



        public void UpdateCollege(UpdateCollegeDto college)
        {
            var mappedCollege = _objectMapper.Map<College>(college);
            _collegeRepository.Update(mappedCollege);
        }

        public void DeleteCollege(int id)
        {
           
            _collegeRepository.Delete(college => college.Id == id);
        }






    }
}
