﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFW_Demoo2.Contexts.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }

        public UserProfile UserProfile { get; set; }    

    }
}
