using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Log:IEntity
    {
        public int LogId { get; set; }
        public string Username { get; set; }
        public string Description { get; set; }
        public string Date { get; set; }

    }
}
