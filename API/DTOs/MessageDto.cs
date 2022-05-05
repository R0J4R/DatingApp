using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.DTOs
{
    public class MessageDto
    {
        public int Id { get; set; }
        public int SenderId { get; set; }
        public String SenderUsername { get; set; }
        public String SenderPhotoUrl { get; set; }
        public int RecipientId { get; set; }
        public String RecipientUsername { get; set; }
        public String RecipientPhotoUrl { get; set; }

        public string Content { get; set; }
        public DateTime? DateRead { get; set; }
        public DateTime MessageSent { get; set; }

    }
}