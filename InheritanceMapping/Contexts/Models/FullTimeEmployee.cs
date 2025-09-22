using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceMapping.Contexts.Models
{
    public class FullTimeEmployee : Employee
    {
        public decimal salary { get; set; }
        public DateTime StartDate { get; set; }



    }
}
