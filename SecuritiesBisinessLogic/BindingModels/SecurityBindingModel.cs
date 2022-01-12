using System;
using System.Collections.Generic;
using System.Text;

namespace SecuritiesBusinessLogic.BindingModels
{
    public class SecurityBindingModel
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public decimal BuyPrice { get; set; }
        public decimal SalePrice { get; set; }
        public int EmitentId { get; set; }
    }
}
