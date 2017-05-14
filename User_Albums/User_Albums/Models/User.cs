using System;
using System.ComponentModel.DataAnnotations;

namespace User_Albums.Models
{
    public class User
    {
        public int Id { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "User Name")]
        public string UserName { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}