using LoginHW.Filters;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoginHW.Models.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        [RegularExpression(@"\w+[@]\w+.\w+", ErrorMessage = "Email格式錯誤")]
        [BanWord("skilltree,demo,twMVC", ErrorMessage = "{0} 欄位不得輸入包含skilltree,demo,twMVC的文字 ")]
        public string Account { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "{0} 欄位最少 {2} 個字，最多 {1} 個字", MinimumLength = 4)]
        public string Password { get; set; }

        public string Message { get; set; }

    }
}