﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Headway.Core.Model
{
    public class Role
    {
        public Role()
        {
            Permissions = new List<Permission>();
        }

        public int RoleId { get; set; }
        public List<Permission> Permissions { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        [StringLength(10, ErrorMessage = "Name must be between 1 and 10 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Description is required.")]
        [StringLength(20, ErrorMessage = "Description must be between 1 and 20 characters")]
        public string Description { get; set; }
    }
}
