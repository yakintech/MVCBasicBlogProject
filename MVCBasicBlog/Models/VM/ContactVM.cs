using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCBasicBlog.Models.VM
{
    public class ContactVM : SiteBaseVM
    {
        [Required]
        [Display(Name="Ad")]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name="EMail")]
        public string EMail { get; set; }

        [Display(Name="Telefon")]
        public string Phone { get; set; }

        [Display(Name="Mesaj"),Required]
        public string Message { get; set; }
    }
}