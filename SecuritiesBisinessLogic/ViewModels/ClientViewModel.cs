using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace SecuritiesBisinessLogic.ViewLogics
{
    public class ClientViewModel
    {
        public int Id { get; set; }
        [DisplayName("Номер паспорта")]
        public string PassportNumber { get; set; }
        [DisplayName("ФИО")]
        public string ClientName { get; set; }
        [DisplayName("Логин")]
        public string ClientLogin { get; set; }
        [DisplayName("Пароль")]
        public string ClientPassword { get; set; }


    }
}
