﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace StartupProject.Entities.Models.User
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; } 
        public string LastName { get; set; }
        public string Designation { get; set; }

        [NotMapped]
        public string FullName {
            get {
                return $"{FirstName} {MiddleName} {LastName}";
            }
        }

        public IEnumerable<UserRole> UserRole { get; set; }
    }
}
