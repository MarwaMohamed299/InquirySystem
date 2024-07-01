using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InquerySystem.Infrastructure.Identity.Models
{
    public class Role :IdentityRole<Guid>
    {
        public Role(string roleName) : base(roleName) { }
        public Role() : base() { }
    }
}
