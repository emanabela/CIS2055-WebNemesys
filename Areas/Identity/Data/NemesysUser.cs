using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Nemesys.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the NemesysUser class
    public class NemesysUser : IdentityUser
    {
        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string FirstName { get; set; }

        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string LastName { get; set; }

        //[PersonalData]
        //[Column(TypeName = "nvarchar(100)")]
        //public string UserRole { get; set; }


    }
}
