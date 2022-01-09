using System;
using System.Collections.Generic;
using System.Text;

namespace SecuritiesBisinessLogic.BindingModels
{
    public class PaymentContractBuyBindingModel
    {
        public int? Id { get; set; }
        public DateTime PaymentDate { get; set; }
        public decimal PaymentSum { get; set; }
        public int ContractBuyId { get; set; }
    }
}
