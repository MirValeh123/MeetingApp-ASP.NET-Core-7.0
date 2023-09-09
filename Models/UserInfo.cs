using System.ComponentModel.DataAnnotations;

namespace MeetingApp.Models
{
    public class UserInfo
    {
        public int Id {get;set;}

        [Required(ErrorMessage ="Ad alanı zorunlu")]
        public string?  Name { get; set; }
        [Required]

        public string?  Phone { get; set; }
        [Required]
        [EmailAddress(ErrorMessage ="Hatalı Email")]
        public string?  Email { get; set; }
        [Required]

        public bool?  WillAttend { get; set; }

    }
}