using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DevCollApi.Models
{
    public class Collection
    {
        [Key]
        public int CollId { get; set; }
        public string Date { get; set; }
        public string Name { get; set; }
        [ForeignKey("Member")]
        public int MembId { get; set; }
        public bool IsPublic { get; set; }
    }
}
