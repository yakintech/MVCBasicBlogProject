using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCBasicBlog.Areas.Admin.Models.Types.Messages
{
    public class ValidationMessages
    {
        public static string success = "İşlem başarılı!";

        public static string generalrequiredmessage = "Bu alan boş geçilemez";

        public static string confirmpasswordmessage = "Şifreler uyuşmuyor";

        public static string adminemailerrormessage = "Böyle bir email adresi mevcut";
    }
}