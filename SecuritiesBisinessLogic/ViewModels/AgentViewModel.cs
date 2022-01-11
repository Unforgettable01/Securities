using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace SecuritiesBisinessLogic.ViewModels
{
    public class AgentViewModel
    {
        public int Id { get; set; }
        [DisplayName("ФИО")]
        public string AgentName { get; set; }
        [DisplayName("Логин")]
        public string AgentLogin { get; set; }
        [DisplayName("Пароль")]
        public string AgentPassword { get; set; }
    }
}
