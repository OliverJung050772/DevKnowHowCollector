using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DevCollApi.Models
{
    public class Note
    {
        [Key]
        public int NoteId { get; set; }
        public string Date { get; set; }
        [ForeignKey("Member")]
        public int MembId { get; set; }
        [ForeignKey("Topic")]
        public int TopId { get; set; }
        [ForeignKey("Collection")]
        public int CollId { get; set; }
        public bool IsPublic { get; set; }
        public string Discription { get; set; }
        public string TextContent { get; set; }
    }
}
