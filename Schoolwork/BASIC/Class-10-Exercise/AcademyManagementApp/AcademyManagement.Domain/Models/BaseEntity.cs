﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyManagement.Domain.Models
{
    public class BaseEntity
    {
        public int Id { get; set; }
        
        public DateTime DateCreated { get; set; }
    }
    
}
