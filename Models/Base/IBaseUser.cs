using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstExample.Models;
public interface IBaseUser
{
    string UserName { get; set; }
    string Password { get; set; }
    string IdentityNumber { get; set; }
    string FirstName { get; set; }
    string LastName { get; set; }
    bool IsActive { get; set; }
}
