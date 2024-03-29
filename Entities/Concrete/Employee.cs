﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Employee:IEntity
    {
        public int EmployeeId { get; set; }
        public int PersonId { get; set; }
        public int UserId { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
    }
}
