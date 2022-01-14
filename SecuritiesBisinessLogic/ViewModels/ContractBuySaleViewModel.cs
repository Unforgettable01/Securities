using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace SecuritiesBusinessLogic.ViewModels
{
    public class ContractBuySaleViewModel
    {
        public int Id { get; set; }
        [DisplayName("Статус")]
        public string Status { get; set; }
        [DisplayName("Сумма")]
        public decimal? ContractSum { get; set; }
        [DisplayName("Номер заявки")]
        public int RequestId { get; set; }
        [DisplayName("Дата")]
        public DateTime Date { get; set; }
    }
}
