using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Manager:IEntity
    {
        public int ManagerId { get; set; }
        public int EmployeeId { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }

    }
}
