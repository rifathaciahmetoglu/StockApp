using Core.Entities;
using Entities.Concrete;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class UserDetailDto:IDto
    {
        public string? Username { get; set; }
        public string? Password { get; set; }
    }
}
