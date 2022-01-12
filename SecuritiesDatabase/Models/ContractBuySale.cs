using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SecuritiesDatabase.Models
{
    public partial class ContractBuySale
    {
        public ContractBuySale()
        {
            PaymentContractBuySale = new HashSet<PaymentContractBuySale>();
        }

        public int Id { get; set; }
        public string Status { get; set; }
        public decimal? Sum { get; set; }
        public int? RequestId { get; set; }

        public virtual Request Request { get; set; }
        public virtual ICollection<PaymentContractBuySale> PaymentContractBuySale { get; set; }
    }
}
