using System.ComponentModel.DataAnnotations;

namespace GTmaritimeTest.Models
{
    public class Ship
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
} 