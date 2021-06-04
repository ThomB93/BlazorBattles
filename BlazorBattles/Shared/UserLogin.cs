using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace BlazorBattles.Shared
{
    public class UserLogin
    {
        [Required(ErrorMessage ="Please enter a username")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Please enter a password")]
        public string Password { get; set; }
    }
}
