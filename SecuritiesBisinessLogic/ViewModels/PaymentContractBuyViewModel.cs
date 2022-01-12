using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace SecuritiesBusinessLogic.ViewModels
{
    public class PaymentContractBuyViewModel
    {
        public int Id { get; set; }
        [DisplayName("Дата")]
        public DateTime PaymentDate { get; set; }
        [DisplayName("Сумма")]
        public decimal PaymentSum { get; set; }
        [DisplayName("Номер договора")]
        public int ContractBuyId { get; set; }

    }
}
