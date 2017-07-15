using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcGuestbook.Models
{
    public class Guestbook
    {
       
        public int Id { get; set; }
        public string 姓名 { get; set; }
        public string Email { get; set; }
        public string 内容 { get; set; }
    }
}