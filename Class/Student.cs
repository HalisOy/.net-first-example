using FirstExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstExample.Class;
public class Student : User, IStudent
{
    public int Absenteeism { get; set; }
    public byte Marks { get; set; }
    public string StudentNumber { get; set; }
    public Student() { }
    public Student(string userName, string password, string identityNumber, string firstName, string lastName, bool isActive,int absenteeism,byte marks,string studentNumber):base(userName, password, identityNumber, firstName, lastName, isActive)
    {
        Absenteeism = absenteeism;
        Marks = marks;
        StudentNumber = studentNumber;
    }
}
