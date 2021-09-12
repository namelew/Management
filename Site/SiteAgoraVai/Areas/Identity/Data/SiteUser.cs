using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace SiteAgoraVai.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the SiteUser class
    public class SiteUser : IdentityUser
    {
        [PersonalData]
        [Column(TypeName="nvarchar(25)")]
        public string nome { get; set; }
        [PersonalData]
        [Column(TypeName = "nvarchar(25)")]
        public string sobrenome { get; set; }
    }
}
