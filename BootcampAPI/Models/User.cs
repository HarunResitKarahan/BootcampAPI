using System.ComponentModel.DataAnnotations;

namespace BootcampAPI.Models
{
    public class User
    {
        [Key]
        public string UserLoginName { get; set; }

        public string UserName { get; set; }

        public string UserPassword { get; set; }

        public string UserMail { get; set; }
    }
}
