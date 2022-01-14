using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SecuritiesDatabase
{
    public partial class Bag
    {
        public Bag()
        {
            BagSecurities = new HashSet<BagSecurities>();
            Request = new HashSet<Request>();
        }

        public int Id { get; set; }
        public string Status { get; set; }
        public decimal? Sum { get; set; }
        public int? ClientId { get; set; }

        public virtual Client Client { get; set; }
        public virtual ICollection<BagSecurities> BagSecurities { get; set; }
        public virtual ICollection<Request> Request { get; set; }
    }
}
