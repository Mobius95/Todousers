using System.Collections.Generic;

namespace TodoApi.Models
{
    public class User
    {
        public long id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public virtual ICollection<Todoitem> Todoitem { get; set; }

    }
}
