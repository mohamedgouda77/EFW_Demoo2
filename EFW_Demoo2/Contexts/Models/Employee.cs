using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFW_Demoo2.Contexts.Models
{
    public class Employee
    {
        public int Id { get; set; } // PK by convention

        [Column(TypeName = "varchar")] // Change column type to varchar
        [MaxLength(10)]
        [MinLength(5)]
        [StringLength(10, MinimumLength = 5, ErrorMessage = "")]
        [Length(5, 10)]
        public string? Name { get; set; } // nvarchar(max)
        [Required] // Not Accept null
        [DefaultValue(5000)] // Default value 5000
        public decimal Salary { get; set; } // decimal(18,2)

        [Range(18, 60)]
        [AllowedValues(24, 25, 26)]
        [DeniedValues(29, 30)]
        public int Age { get; set; }

        [NotMapped] // Ignore this property
        public int Test { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }

        public string Address { get; set; } // nvarchar(max)

        public int? DepartmentId { get; set; } 
        public virtual Department Department { get; set; } 

    }
}
