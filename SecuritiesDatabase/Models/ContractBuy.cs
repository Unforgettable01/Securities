using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SecuritiesDatabase
{
    public partial class ContractBuy
    {
        public ContractBuy()
        {
            PaymentContractBuy = new HashSet<PaymentContractBuy>();
        }

        public int Id { get; set; }
        public string Status { get; set; }
        public decimal? Sum { get; set; }
        public int? RequestId { get; set; }
        public DateTime? Date { get; set; }

        public virtual Request Request { get; set; }
        public virtual ICollection<PaymentContractBuy> PaymentContractBuy { get; set; }
    }
}
