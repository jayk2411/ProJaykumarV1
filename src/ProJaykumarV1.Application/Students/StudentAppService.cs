using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using ProJaykumarV1.Models;

namespace ProJaykumarV1.Students
{
    public class StudentAppService : AsyncCrudAppService<Student, StudentDto, int, PagedStudentResultRequesteDto, CreateStudentDto, UpdateStudentDto>
    {

        public StudentAppService(IRepository<Student, int> repository) : base(repository)
        {
        }
    }

    public class UpdateStudentDto : IEntityDto<int>
    {
        int IEntityDto<int>.Id { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
    }

    public class CreateStudentDto : IEntityDto<int>
    {
        int IEntityDto<int>.Id { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
    }

    public class PagedStudentResultRequesteDto : IEntityDto<int>
    {
        int IEntityDto<int>.Id { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
    }

    public class StudentDto : IEntityDto<int>
    {
        int IEntityDto<int>.Id { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
    }
}
