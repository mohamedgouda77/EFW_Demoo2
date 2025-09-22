using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFW_Demoo2.Contexts.Models
{
    public class Department
    {
        public int DeptId { get; set; }
        public string Name { get; set; }
        public DateTime DateofCreation { get; set; }
        public int serial { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }


    }
}
