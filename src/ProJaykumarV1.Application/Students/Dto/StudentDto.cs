using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProJaykumarV1.Students.Dto
{
    internal class StudentDto : IEntityDto<int>
    {
        int IEntityDto<int>.Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
