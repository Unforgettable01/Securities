using System;
using System.Collections.Generic;
using System.Text;

namespace SecuritiesBusinessLogic.BindingModels
{
    public class ContractBuySaleBindingModel
    {
        public int? Id { get; set; }
        public string Status { get; set; }
        public decimal ContractSum { get; set; }
        public int RequestId { get; set; }
        public DateTime Date { get; set; }
    }
}
