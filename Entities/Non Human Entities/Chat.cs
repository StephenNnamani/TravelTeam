using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class Chat
    {
        public Guid ChatId { get; set; }
        public int SenderId { get; set; }
        public int ReceiverId { get; set; }
        public string? Message { get; set; }
        public DateTime TimeStamp { get; set; }
        public string? MessageType { get; set; }
    }
}
