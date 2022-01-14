using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SecuritiesDatabase
{
    public partial class Client
    {
        public Client()
        {
            Bag = new HashSet<Bag>();
        }

        public int Id { get; set; }
        public string PassportNumber { get; set; }
        public string Fio { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public virtual ICollection<Bag> Bag { get; set; }
    }
}
