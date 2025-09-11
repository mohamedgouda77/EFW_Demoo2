using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFW_Demoo2.Contexts.Models
{
    public class UserProfile
    {
        public int UserProfileId { get; set; }
        public string Bio { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; }




    }
}
