using Abp.AutoMapper;
using ProJaykumarV1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProJaykumarV1.Students.Dto
{
    [AutoMapTo(typeof(Student))]
    public class CreateStudentDto
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string ProgramName { get; set; }
        public string DoB { get; set; }
        public bool IsActive { get; set; }
        ///CreateDto.cs.fields1///

    }
}
