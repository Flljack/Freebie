namespace Freebie.Models
{
    using System;
    using System.Collections.Generic;

    public class User
    {
        public int Id { get; set; }
        public int Role_id { get; set; }
        public Role Role { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string About { get; set; }
        public string Passoword { get; set; }
        public DateTime CreatedAt { get; set; }
        public List<Promo> Promos { get; set; }

        public User()
        {
            Promos = new List<Promo>();
        }
    }
}
