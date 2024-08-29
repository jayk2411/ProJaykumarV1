using Abp.Application.Services;
using Abp.Domain.Repositories;
using ProJaykumarV1.Models;
using ProJaykumarV1.Students.Dto;

namespace ProJaykumarV1.Students
{
    public class StudentAppService : AsyncCrudAppService<Student, StudentDto, int, PagedStudentResultRequesteDto, CreateStudentDto, UpdateStudentDto>
    {

        public StudentAppService(IRepository<Student, int> repository) : base(repository)
        {
        }
    }
}
