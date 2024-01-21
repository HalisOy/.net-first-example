using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstExample.Models;
public interface IJobber
{
    string WorkArea { get; set; }
    string VehiclePlate { get; set; }
}