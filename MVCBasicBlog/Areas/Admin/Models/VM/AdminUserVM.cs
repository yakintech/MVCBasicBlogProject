using MVCBasicBlog.Areas.Admin.Models.Types.Messages;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCBasicBlog.Areas.Admin.Models.VM
{
    public class AdminUserVM
    {
        [EmailAddress(ErrorMessage="Lütfen email adresi giriniz")]
        [Required(ErrorMessage = "Bu alan boş geçilemez")]
        [Display(Name="EMail Adresi")]
        public string EMail { get; set; }

        [Required(ErrorMessage = "Bu alan boş geçilemez")]
        [Display(Name="Parola")]
        public string Password { get; set; }

        [Display(Name="Parola Tekrar")]
        [Compare("Password", ErrorMessage = "Şifreler uyuşmuyor")]
        public string ConfirmPassword { get; set; }
    }
}