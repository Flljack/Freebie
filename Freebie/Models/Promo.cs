namespace Freebie.Models
{
    using System;

    public class Promo : IEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public uint Popularity { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public bool Visabled { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
