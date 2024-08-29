using Abp.Application.Services.Dto;

namespace ProJaykumarV1.Students.Dto
{
    public class CreateStudentDto : IEntityDto<int>
    {
        int IEntityDto<int>.Id { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
    }
}