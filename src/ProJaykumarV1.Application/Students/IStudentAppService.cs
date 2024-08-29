using Abp.Application.Services;
using ProJaykumarV1.Students.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProJaykumarV1.Students
{
    public interface IStudentAppService : IAsyncCrudAppService<StudentDto, int, PagedStudentResultRequestDto, CreateStudentDto, UpdateStudentDto>
    {

    }
}
