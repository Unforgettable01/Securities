using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace SecuritiesBisinessLogic.ViewLogics
{
    public class AgentViewModel
    {
        public int Id { get; set; }
        [DisplayName("ФИО агента")]
        public string AgentName { get; set; }
        [DisplayName("Логин агента")]
        public string AgentLogin { get; set; }
        [DisplayName("Пароль агента")]
        public string AgentPassword { get; set; }
    }
}
