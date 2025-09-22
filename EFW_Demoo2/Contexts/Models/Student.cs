using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFW_Demoo2.Contexts.Models
{
    public class Student
    {
       public int Id { get; set; }
       public string Name { get; set; }
       public virtual ICollection<Course> Courses { get; set; }

    }
}
