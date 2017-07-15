using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MvcGuestBook.Models
{
    public class GuestBook
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string 姓名 { get; set; }
        [DisplayName("电子邮件")]
        [Required]
        public string Email { get; set; }
        public string 内容 { get; set; }
    }
}