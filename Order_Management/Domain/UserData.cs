using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class UserData : Common
    {
        public int Id { get; set; }
        public string? UserName { get; set; }
        public string? EmailAddress { get; set; }
        public string? Password { get; set; }
        public int RoleId { get; set; }
        public int CompanyId { get; set; }
        public string? RoleName { get; set; }
        public string? CompanyName { get; set; }
    }
}
