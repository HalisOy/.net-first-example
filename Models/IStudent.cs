using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstExample.Models
{
    public interface IStudent : IBaseUser
    {
        int Absenteeism { get; set; }
        byte Marks { get; set; }
        string StudentNumber { get; set; }
    }
}
