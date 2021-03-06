using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SecuritiesDatabase
{
    public partial class Request
    {
        public Request()
        {
            ContractBuy = new HashSet<ContractBuy>();
            ContractBuySale = new HashSet<ContractBuySale>();
        }

        public int Id { get; set; }
        public DateTime? Date { get; set; }
        public decimal? Sum { get; set; }
        public int? AgentId { get; set; }
        public int? BagId { get; set; }

        public virtual Agent Agent { get; set; }
        public virtual Bag Bag { get; set; }
        public virtual ICollection<ContractBuy> ContractBuy { get; set; }
        public virtual ICollection<ContractBuySale> ContractBuySale { get; set; }
    }
}
