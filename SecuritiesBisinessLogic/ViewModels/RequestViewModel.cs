using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Text;

namespace SecuritiesBusinessLogic.ViewModels
{
    public class RequestViewModel
    {
        public int Id { get; set; }
        [DisplayName("Дата")]
        public DateTime RequestDate { get; set; }
        [DisplayName("Сумма")]
        public decimal RequestSum { get; set; }
        [DisplayName("ФИО клиента")]
        public string ClientName { get; set; }
        [DisplayName("ФИО агента")]
        public string AgentName { get; set; }
        [DataMember]
        public Dictionary<int?, (string, decimal?)> RequestSecurity { get; set; }
    }
}
