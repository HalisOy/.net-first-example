using FirstExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstExample.Class;
public class Jobber : User, IJobber
{
    public string WorkArea { get; set; }
    public string VehiclePlate { get; set; }
    public Jobber() { }
    public Jobber (string userName, string password, string identityNumber, string firstName, string lastName, bool isActive,string workArea,string vehiclePlate):base(userName, password, identityNumber, firstName, lastName, isActive)
    {
        WorkArea = workArea;
    }
}
