
namespace Securities.ClientView
{
    partial class FormBag
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
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.labelSecurities = new System.Windows.Forms.Label();
            this.labelSumma = new System.Windows.Forms.Label();
            this.labelCount = new System.Windows.Forms.Label();
            this.textBoxSumma = new System.Windows.Forms.TextBox();
            this.textBoxCount = new System.Windows.Forms.TextBox();
            this.buttonRef = new System.Windows.Forms.Button();
            this.buttonUpd = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.dataGridViewSecurities = new System.Windows.Forms.DataGridView();
            this.labelNumber = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelSum = new System.Windows.Forms.Label();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.textBoxSum = new System.Windows.Forms.TextBox();
            this.comboBoxSecurities = new System.Windows.Forms.ComboBox();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSecuritiesName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSecurities)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(643, 503);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(133, 33);
            this.buttonSave.TabIndex = 0;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(817, 503);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(133, 33);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Отменить";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.comboBoxSecurities);
            this.groupBox.Controls.Add(this.labelSecurities);
            this.groupBox.Controls.Add(this.labelSumma);
            this.groupBox.Controls.Add(this.labelCount);
            this.groupBox.Controls.Add(this.textBoxSumma);
            this.groupBox.Controls.Add(this.textBoxCount);
            this.groupBox.Controls.Add(this.buttonRef);
            this.groupBox.Controls.Add(this.buttonUpd);
            this.groupBox.Controls.Add(this.buttonDel);
            this.groupBox.Controls.Add(this.buttonAdd);
            this.groupBox.Controls.Add(this.dataGridViewSecurities);
            this.groupBox.Location = new System.Drawing.Point(12, 129);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(938, 366);
            this.groupBox.TabIndex = 2;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Ценные бумаги";
            // 
            // labelSecurities
            // 
            this.labelSecurities.AutoSize = true;
            this.labelSecurities.Location = new System.Drawing.Point(684, 26);
            this.labelSecurities.Name = "labelSecurities";
            this.labelSecurities.Size = new System.Drawing.Size(103, 20);
            this.labelSecurities.TabIndex = 9;
            this.labelSecurities.Text = "Цен. бумага:";
            // 
            // labelSumma
            // 
            this.labelSumma.AutoSize = true;
            this.labelSumma.Location = new System.Drawing.Point(684, 115);
            this.labelSumma.Name = "labelSumma";
            this.labelSumma.Size = new System.Drawing.Size(62, 20);
            this.labelSumma.TabIndex = 10;
            this.labelSumma.Text = "Сумма:";
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(684, 72);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(104, 20);
            this.labelCount.TabIndex = 11;
            this.labelCount.Text = "Количество:";
            // 
            // textBoxSumma
            // 
            this.textBoxSumma.Location = new System.Drawing.Point(793, 112);
            this.textBoxSumma.Name = "textBoxSumma";
            this.textBoxSumma.ReadOnly = true;
            this.textBoxSumma.Size = new System.Drawing.Size(131, 26);
            this.textBoxSumma.TabIndex = 9;
            // 
            // textBoxCount
            // 
            this.textBoxCount.Location = new System.Drawing.Point(793, 69);
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.Size = new System.Drawing.Size(131, 26);
            this.textBoxCount.TabIndex = 10;
            this.textBoxCount.TextChanged += new System.EventHandler(this.textBoxCount_TextChanged);
            // 
            // buttonRef
            // 
            this.buttonRef.Location = new System.Drawing.Point(814, 219);
            this.buttonRef.Name = "buttonRef";
            this.buttonRef.Size = new System.Drawing.Size(110, 33);
            this.buttonRef.TabIndex = 12;
            this.buttonRef.Text = "Обновить";
            this.buttonRef.UseVisualStyleBackColor = true;
            this.buttonRef.Click += new System.EventHandler(this.buttonRef_Click);
            // 
            // buttonUpd
            // 
            this.buttonUpd.Location = new System.Drawing.Point(814, 164);
            this.buttonUpd.Name = "buttonUpd";
            this.buttonUpd.Size = new System.Drawing.Size(110, 33);
            this.buttonUpd.TabIndex = 11;
            this.buttonUpd.Text = "Изменить";
            this.buttonUpd.UseVisualStyleBackColor = true;
            this.buttonUpd.Click += new System.EventHandler(this.buttonUpd_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(684, 219);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(110, 33);
            this.buttonDel.TabIndex = 10;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(684, 164);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(110, 33);
            this.buttonAdd.TabIndex = 9;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // dataGridViewSecurities
            // 
            this.dataGridViewSecurities.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewSecurities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSecurities.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnSecuritiesName,
            this.ColumnCount,
            this.ColumnSum});
            this.dataGridViewSecurities.Location = new System.Drawing.Point(7, 26);
            this.dataGridViewSecurities.Name = "dataGridViewSecurities";
            this.dataGridViewSecurities.RowHeadersWidth = 62;
            this.dataGridViewSecurities.RowTemplate.Height = 28;
            this.dataGridViewSecurities.Size = new System.Drawing.Size(671, 334);
            this.dataGridViewSecurities.TabIndex = 0;
            this.dataGridViewSecurities.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewSecurities_RowHeaderMouseClick);
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Location = new System.Drawing.Point(12, 13);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(63, 20);
            this.labelNumber.TabIndex = 3;
            this.labelNumber.Text = "Номер:";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(12, 53);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(66, 20);
            this.labelStatus.TabIndex = 4;
            this.labelStatus.Text = "Статус:";
            // 
            // labelSum
            // 
            this.labelSum.AutoSize = true;
            this.labelSum.Location = new System.Drawing.Point(15, 90);
            this.labelSum.Name = "labelSum";
            this.labelSum.Size = new System.Drawing.Size(97, 20);
            this.labelSum.TabIndex = 5;
            this.labelSum.Text = "Стоимость:";
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(128, 10);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.ReadOnly = true;
            this.textBoxNumber.Size = new System.Drawing.Size(164, 26);
            this.textBoxNumber.TabIndex = 6;
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Location = new System.Drawing.Point(128, 50);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.ReadOnly = true;
            this.textBoxStatus.Size = new System.Drawing.Size(164, 26);
            this.textBoxStatus.TabIndex = 7;
            // 
            // textBoxSum
            // 
            this.textBoxSum.Location = new System.Drawing.Point(128, 87);
            this.textBoxSum.Name = "textBoxSum";
            this.textBoxSum.ReadOnly = true;
            this.textBoxSum.Size = new System.Drawing.Size(164, 26);
            this.textBoxSum.TabIndex = 8;
            // 
            // comboBoxSecurities
            // 
            this.comboBoxSecurities.FormattingEnabled = true;
            this.comboBoxSecurities.Location = new System.Drawing.Point(793, 23);
            this.comboBoxSecurities.Name = "comboBoxSecurities";
            this.comboBoxSecurities.Size = new System.Drawing.Size(131, 28);
            this.comboBoxSecurities.TabIndex = 13;
            this.comboBoxSecurities.SelectedIndexChanged += new System.EventHandler(this.comboBoxSecurities_SelectedIndexChanged);
            // 
            // ColumnId
            // 
            this.ColumnId.HeaderText = "Id";
            this.ColumnId.MinimumWidth = 8;
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.ReadOnly = true;
            this.ColumnId.Visible = false;
            this.ColumnId.Width = 150;
            // 
            // ColumnSecuritiesName
            // 
            this.ColumnSecuritiesName.HeaderText = "Ценная бумага";
            this.ColumnSecuritiesName.MinimumWidth = 8;
            this.ColumnSecuritiesName.Name = "ColumnSecuritiesName";
            this.ColumnSecuritiesName.Width = 150;
            // 
            // ColumnCount
            // 
            this.ColumnCount.HeaderText = "Количество";
            this.ColumnCount.MinimumWidth = 8;
            this.ColumnCount.Name = "ColumnCount";
            this.ColumnCount.Width = 150;
            // 
            // ColumnSum
            // 
            this.ColumnSum.HeaderText = "Сумма";
            this.ColumnSum.MinimumWidth = 8;
            this.ColumnSum.Name = "ColumnSum";
            this.ColumnSum.Width = 150;
            // 
            // FormBag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 548);
            this.Controls.Add(this.textBoxSum);
            this.Controls.Add(this.textBoxStatus);
            this.Controls.Add(this.textBoxNumber);
            this.Controls.Add(this.labelSum);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelNumber);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Name = "FormBag";
            this.Text = "Портфель";
            this.Load += new System.EventHandler(this.FormBag_Load);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSecurities)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.DataGridView dataGridViewSecurities;
        private System.Windows.Forms.Button buttonRef;
        private System.Windows.Forms.Button buttonUpd;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelSum;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.TextBox textBoxSum;
        private System.Windows.Forms.Label labelSecurities;
        private System.Windows.Forms.Label labelSumma;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.TextBox textBoxSumma;
        private System.Windows.Forms.TextBox textBoxCount;
        private System.Windows.Forms.ComboBox comboBoxSecurities;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSecuritiesName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSum;
    }
}