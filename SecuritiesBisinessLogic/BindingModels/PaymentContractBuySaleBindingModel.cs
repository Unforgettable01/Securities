using System;
using System.Collections.Generic;
using System.Text;

namespace SecuritiesBusinessLogic.BindingModels
{
    public class PaymentContractBuySaleBindingModel
    {
        public int? Id { get; set; }
        public DateTime PaymentDate { get; set; }
        public decimal PaymentSum { get; set; }
        public int ContractBuySaleId { get; set; }
    }
}
