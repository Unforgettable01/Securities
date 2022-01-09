using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace SecuritiesBisinessLogic.ViewLogics
{
    public class SecurityViewModel
    {
        public int Id { get; set; }
        [DisplayName("Цена закупки")]
        public decimal BuyPrice { get; set; }
        [DisplayName("Цена продажи")]
        public decimal SalePrice { get; set; }
        [DisplayName("Эмитент")]
        public string EmitentId { get; set; }

    }
}
