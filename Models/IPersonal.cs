using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstExample.Models;

public interface IPersonal : IBaseUser
{
    string SSN { get; set; }
    decimal Salary { get; set; }
    void CalculateSalary(short workingHours);
}
