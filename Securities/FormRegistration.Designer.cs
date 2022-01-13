
namespace Securities
{
    partial class FormRegistration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.buttonRegistration = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxPassportNumber = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelPassportNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(226, 216);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(318, 26);
            this.textBoxPassword.TabIndex = 9;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(226, 159);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(318, 26);
            this.textBoxLogin.TabIndex = 8;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(143, 216);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(67, 20);
            this.labelPassword.TabIndex = 7;
            this.labelPassword.Text = "Пароль";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(143, 159);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(55, 20);
            this.labelLogin.TabIndex = 6;
            this.labelLogin.Text = "Логин";
            // 
            // buttonRegistration
            // 
            this.buttonRegistration.Location = new System.Drawing.Point(283, 263);
            this.buttonRegistration.Name = "buttonRegistration";
            this.buttonRegistration.Size = new System.Drawing.Size(206, 51);
            this.buttonRegistration.TabIndex = 5;
            this.buttonRegistration.Text = "Зарегистрироваться";
            this.buttonRegistration.UseVisualStyleBackColor = true;
            this.buttonRegistration.Click += new System.EventHandler(this.buttonRegistration_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(226, 113);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(318, 26);
            this.textBoxName.TabIndex = 13;
            // 
            // textBoxPassportNumber
            // 
            this.textBoxPassportNumber.Location = new System.Drawing.Point(226, 56);
            this.textBoxPassportNumber.Name = "textBoxPassportNumber";
            this.textBoxPassportNumber.Size = new System.Drawing.Size(318, 26);
            this.textBoxPassportNumber.TabIndex = 12;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(143, 113);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(47, 20);
            this.labelName.TabIndex = 11;
            this.labelName.Text = "ФИО";
            // 
            // labelPassportNumber
            // 
            this.labelPassportNumber.AutoSize = true;
            this.labelPassportNumber.Location = new System.Drawing.Point(86, 56);
            this.labelPassportNumber.Name = "labelPassportNumber";
            this.labelPassportNumber.Size = new System.Drawing.Size(134, 20);
            this.labelPassportNumber.TabIndex = 10;
            this.labelPassportNumber.Text = "Номер паспорта";
            // 
            // FormRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxPassportNumber);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelPassportNumber);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.buttonRegistration);
            this.Name = "FormRegistration";
            this.Text = "Форма регистрации";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Button buttonRegistration;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxPassportNumber;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelPassportNumber;
    }
}