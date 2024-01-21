using FirstExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstExample.Class;
public class Personal : User, IPersonal
{
    public string SSN { get; set; }
    public decimal Salary { get; set; }
    public Personal() { }
    public Personal(string userName, string password, string identityNumber, string firstName, string lastName, bool isActive, string ssn, decimal salary) : base(userName, password, identityNumber, firstName, lastName, isActive)
    {
        SSN = ssn;
        Salary = salary;
    }
    public void CalculateSalary(short workingHours)
    {
        Console.WriteLine(@$"Calculated salary: {Salary * workingHours} ₺");
    }
}