using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DevCollApi.Models
{
    public class Message
    {
        [Key]
        public int MessId { get; set; }
        [ForeignKey("Member")]
        public int SenderId { get; set; }
        [ForeignKey("Member")]
        public int ReceiverId { get; set; }
        public string SendDate { get; set; }
        public string Subject { get; set; }
        public string MessageText { get; set; }
        public bool IsRead { get; set; }
    }
}
