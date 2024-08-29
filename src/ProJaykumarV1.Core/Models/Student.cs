﻿using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProJaykumarV1.Models
{
    public class Student : FullAuditedEntity<int>, IPassivable 
    {
        public Student()
        {
            this.IsActive = true;
            this.CreationTime = DateTime.Now;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string ProgramName { get; set; }
        public string Dob { get; set; }
        public bool IsActive { get; set; }
    }
}
