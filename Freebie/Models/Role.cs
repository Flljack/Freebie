namespace Freebie.Models
{
    using System.Collections.Generic;

    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public byte Level { get; set; }

        public List<User> Users { get; set; }

        public Role()
        {
            Users = new List<User>();
        }
    }
}
