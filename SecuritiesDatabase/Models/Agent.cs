using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SecuritiesDatabase
{
    public partial class Agent
    {
        public Agent()
        {
            Request = new HashSet<Request>();
        }

        public int Id { get; set; }
        public string Fio { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public virtual ICollection<Request> Request { get; set; }
    }
}
