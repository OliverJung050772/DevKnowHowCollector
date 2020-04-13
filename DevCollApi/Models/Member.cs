using System.ComponentModel.DataAnnotations;

namespace DevCollApi.Models
{
    public class Member
    {
        [Key]
        public int MembId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
