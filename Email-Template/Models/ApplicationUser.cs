using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace DemoApp.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        //[MaxLength(256)]
        //public string FullName { get; set; }

        //[MaxLength(128)]
        //public string Thumbnail { get; set; }

       

    }
}
