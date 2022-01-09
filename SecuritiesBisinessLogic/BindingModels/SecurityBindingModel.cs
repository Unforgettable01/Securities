using System;
using System.Collections.Generic;
using System.Text;

namespace SecuritiesBisinessLogic.BindingModels
{
    public class Securities
    {
        public int? Id { get; set; }
        public decimal BuyPrice { get; set; }
        public decimal SalePrice { get; set; }
        public int EmitentId { get; set; }
    }
}
