
namespace Securities.ClientView
{
    partial class FormBagCheck
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
            this.labelNumber = new System.Windows.Forms.Label();
            this.textBoxSum = new System.Windows.Forms.TextBox();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.labelSum = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.dataGridViewSecurities = new System.Windows.Forms.DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSecuritiesName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSecurities)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Location = new System.Drawing.Point(12, 9);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(63, 20);
            this.labelNumber.TabIndex = 4;
            this.labelNumber.Text = "Номер:";
            // 
            // textBoxSum
            // 
            this.textBoxSum.Location = new System.Drawing.Point(121, 83);
            this.textBoxSum.Name = "textBoxSum";
            this.textBoxSum.ReadOnly = true;
            this.textBoxSum.Size = new System.Drawing.Size(164, 26);
            this.textBoxSum.TabIndex = 13;
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Location = new System.Drawing.Point(121, 46);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.ReadOnly = true;
            this.textBoxStatus.Size = new System.Drawing.Size(164, 26);
            this.textBoxStatus.TabIndex = 12;
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(121, 6);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.ReadOnly = true;
            this.textBoxNumber.Size = new System.Drawing.Size(164, 26);
            this.textBoxNumber.TabIndex = 11;
            // 
            // labelSum
            // 
            this.labelSum.AutoSize = true;
            this.labelSum.Location = new System.Drawing.Point(12, 86);
            this.labelSum.Name = "labelSum";
            this.labelSum.Size = new System.Drawing.Size(97, 20);
            this.labelSum.TabIndex = 10;
            this.labelSum.Text = "Стоимость:";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(12, 49);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(66, 20);
            this.labelStatus.TabIndex = 9;
            this.labelStatus.Text = "Статус:";
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.dataGridViewSecurities);
            this.groupBox.Location = new System.Drawing.Point(16, 134);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(687, 366);
            this.groupBox.TabIndex = 14;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Ценные бумаги";
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
            // FormBagCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 510);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.textBoxSum);
            this.Controls.Add(this.textBoxStatus);
            this.Controls.Add(this.textBoxNumber);
            this.Controls.Add(this.labelSum);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelNumber);
            this.Name = "FormBagCheck";
            this.Text = "Портфель";
            this.Load += new System.EventHandler(this.FormBagCheck_Load);
            this.groupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSecurities)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.TextBox textBoxSum;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.Label labelSum;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.DataGridView dataGridViewSecurities;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSecuritiesName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSum;
    }
}