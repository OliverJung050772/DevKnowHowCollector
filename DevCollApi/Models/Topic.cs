using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DevCollApi.Models
{
    public class Topic
    {
        [Key]
        public int TopId { get; set; }
        public string Date { get; set; }
        public string Name { get; set; }
        [ForeignKey("Member")]
        public int MembId { get; set; }
        [ForeignKey("Collection")]
        public int CollId { get; set; }
        public bool IsPublic { get; set; }
    }
}
