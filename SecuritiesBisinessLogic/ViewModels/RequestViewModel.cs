using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace SecuritiesBisinessLogic.ViewLogics
{
    public class RequestViewModel
    {
        public int Id { get; set; }
        [DisplayName("Дата")]
        public DateTime RequestDate { get; set; }
        [DisplayName("Сумма")]
        public decimal RequestSum { get; set; }
        [DisplayName("Имя клиента")]
        public string ClientId { get; set; }
        [DisplayName("Имя агента")]
        public string AgentId { get; set; }
    }
}
