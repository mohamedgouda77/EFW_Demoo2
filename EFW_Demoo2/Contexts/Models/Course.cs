using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFW_Demoo2.Contexts.Models
{
    public class Course
    {
       public int Id { get; set; }
       public string Name { get; set; }    
       public virtual ICollection<Course> Courses { get; set;}





    }
}
