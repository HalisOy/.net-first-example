using FirstExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstExample.Class;
public class User : IBaseUser
{
    public string UserName { get; set; }
    public string Password { get; set; }
    public string IdentityNumber { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public bool IsActive { get; set; }

    public User() { }
    public User(string userName, string password, string identityNumber, string firstName, string lastName, bool isActive)
    {
        UserName = userName;
        Password = password;
        IdentityNumber = identityNumber;
        FirstName = firstName;
        LastName = lastName;
        IsActive = isActive;
    }
}
