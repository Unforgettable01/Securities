using System;
using System.Collections.Generic;
using System.Text;

namespace SecuritiesBusinessLogic.BindingModels
{
    public class BagBindingModel
    {
        public int? Id { get; set; }
        public decimal Sum { get; set; }
        public string Status { get; set; }
        public Dictionary<int?, (string, decimal?)> BagSecurities { get; set; }
    }
}
