using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SecuritiesDatabase
{
    public partial class PaymentContractBuySale
    {
        public int Id { get; set; }
        public DateTime? Date { get; set; }
        public decimal? Sum { get; set; }
        public int? ContractBuySaleId { get; set; }

        public virtual ContractBuySale ContractBuySale { get; set; }
    }
}
