namespace Freebie.Models
{
    using System.Collections.Generic;

    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Promo> Promos { get; set; }

        public Category()
        {
            Promos = new List<Promo>();
        }
    }
}
