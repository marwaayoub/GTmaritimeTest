using System;

namespace GTmaritimeTest.Models
{
    public class MaritimeMessage
    {
        public int Id { get; set; }
        public string Sender { get; set; }
        public int VesselId { get; set; }
        public string Content { get; set; }
        public DateTime SentTime { get; set; }
    }
} 