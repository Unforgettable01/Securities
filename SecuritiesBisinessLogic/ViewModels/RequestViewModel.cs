using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Text;

namespace SecuritiesBusinessLogic.ViewModels
{
    public class RequestViewModel
    {
        [DisplayName("Номер")]
        public int Id { get; set; }
        [DisplayName("Дата")]
        public DateTime RequestDate { get; set; }
        [DisplayName("Сумма")]
        public decimal RequestSum { get; set; }
       
        [DisplayName("ФИО агента")]
        public string AgentName { get; set; }
        [DisplayName("Номер портфеля")]
        public int BagId { get; set; }
        [DisplayName("ФИО клиента")]
        public string ClientName { get; set; }
    }
}
