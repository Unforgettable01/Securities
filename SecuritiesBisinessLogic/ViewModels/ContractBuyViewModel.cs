using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace SecuritiesBisinessLogic.ViewModels
{
    public class ContractBuyViewModel
    {
        public int Id { get; set; }
        [DisplayName("Статус")]
        public string Status { get; set; }
        [DisplayName("Номер заявки")]
        public int RequestId { get; set; }
    }
}
