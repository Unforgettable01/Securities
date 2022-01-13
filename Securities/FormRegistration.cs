using SecuritiesBusinessLogic.BindingModels;
using SecuritiesBusinessLogic.BusinessLogics;
using SecuritiesBusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;

namespace Securities
{
    public partial class FormRegistration : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly ClientBusinessLogic _clientBusinesslogic;
        ClientViewModel view;
        public FormRegistration(ClientBusinessLogic clientBusinesslogic)
        {
            InitializeComponent();
            _clientBusinesslogic = clientBusinesslogic;
        }

        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxName.Text))
            {
                MessageBox.Show("Заполните ФИО", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Regex.IsMatch(textBoxName.Text, @"[А-Я][а-я]+\s[А-Я]+[.]+[А-Я]+[.]"))
            {
                MessageBox.Show("Необходимо проверить правильность ФИО", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxLogin.Text))
            {
                MessageBox.Show("Заполните логин", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxPassword.Text))
            {
                MessageBox.Show("Заполните пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           
            if (string.IsNullOrEmpty(textBoxPassportNumber.Text))
            {
                MessageBox.Show("Заполните номер паспорта", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Regex.IsMatch(textBoxPassportNumber.Text, @"[0-9]{10}"))
            {
                MessageBox.Show("Необходимо проверить правильность вводимого номера паспорта (должны быть только цифры)", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                _clientBusinesslogic.Create(new ClientBindingModel
                {
                    ClientName = textBoxName.Text,
                    ClientLogin = textBoxLogin.Text,
                    ClientPassword = textBoxPassword.Text,
                    PassportNumber = textBoxPassportNumber.Text
                }); ;
                MessageBox.Show("Сохранение прошло успешно", "Сообщение",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
            Close();
            //var form = Container.Resolve<FormaAuthorization>();
            //form.ShowDialog();
            //form.Close();
        }
    }
}
