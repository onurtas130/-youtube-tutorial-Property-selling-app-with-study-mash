﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class User : BaseEntity
    {
        [Required]
        public string UserName { get; set; }
        public string Email{ get; set; }
        public int Mobile { get; set; }
        [Required]
        public byte[] Password { get; set; }
    
        public byte[] PasswordKey { get; set; }
    }
}
