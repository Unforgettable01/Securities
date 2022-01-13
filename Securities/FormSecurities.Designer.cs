
namespace Securities
{
    partial class FormSecurities
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
            this.dataGridViewSecurities = new System.Windows.Forms.DataGridView();
            this.labelName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSalePrice = new System.Windows.Forms.TextBox();
            this.textBoxBuyPrice = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.labelEmitent = new System.Windows.Forms.Label();
            this.comboBoxEmitents = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSecurities)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSecurities
            // 
            this.dataGridViewSecurities.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewSecurities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSecurities.Location = new System.Drawing.Point(13, 13);
            this.dataGridViewSecurities.Name = "dataGridViewSecurities";
            this.dataGridViewSecurities.RowHeadersWidth = 62;
            this.dataGridViewSecurities.RowTemplate.Height = 28;
            this.dataGridViewSecurities.Size = new System.Drawing.Size(1055, 589);
            this.dataGridViewSecurities.TabIndex = 0;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(1074, 31);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(122, 20);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Наименование";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1074, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Цена закупки";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1074, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Цена продажи";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(1216, 31);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(250, 26);
            this.textBoxName.TabIndex = 4;
            // 
            // textBoxSalePrice
            // 
            this.textBoxSalePrice.Location = new System.Drawing.Point(1216, 111);
            this.textBoxSalePrice.Name = "textBoxSalePrice";
            this.textBoxSalePrice.Size = new System.Drawing.Size(250, 26);
            this.textBoxSalePrice.TabIndex = 5;
            // 
            // textBoxBuyPrice
            // 
            this.textBoxBuyPrice.Location = new System.Drawing.Point(1216, 69);
            this.textBoxBuyPrice.Name = "textBoxBuyPrice";
            this.textBoxBuyPrice.Size = new System.Drawing.Size(250, 26);
            this.textBoxBuyPrice.TabIndex = 6;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(1216, 239);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(132, 54);
            this.buttonSave.TabIndex = 7;
            this.buttonSave.Text = "Добавить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(1216, 305);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(132, 54);
            this.buttonUpdate.TabIndex = 8;
            this.buttonUpdate.Text = "Изменить";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(1216, 381);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(132, 54);
            this.buttonRefresh.TabIndex = 9;
            this.buttonRefresh.Text = "Обновить";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(1216, 458);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(132, 54);
            this.buttonDelete.TabIndex = 10;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // labelEmitent
            // 
            this.labelEmitent.AutoSize = true;
            this.labelEmitent.Location = new System.Drawing.Point(1077, 161);
            this.labelEmitent.Name = "labelEmitent";
            this.labelEmitent.Size = new System.Drawing.Size(77, 20);
            this.labelEmitent.TabIndex = 11;
            this.labelEmitent.Text = "Эмитент";
            // 
            // comboBoxEmitents
            // 
            this.comboBoxEmitents.FormattingEnabled = true;
            this.comboBoxEmitents.Location = new System.Drawing.Point(1216, 161);
            this.comboBoxEmitents.Name = "comboBoxEmitents";
            this.comboBoxEmitents.Size = new System.Drawing.Size(250, 28);
            this.comboBoxEmitents.TabIndex = 12;
            // 
            // FormSecurities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1503, 627);
            this.Controls.Add(this.comboBoxEmitents);
            this.Controls.Add(this.labelEmitent);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxBuyPrice);
            this.Controls.Add(this.textBoxSalePrice);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.dataGridViewSecurities);
            this.Name = "FormSecurities";
            this.Text = "Ценные бумаги";
            this.Load += new System.EventHandler(this.FormSecuritiess_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSecurities)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSecurities;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSalePrice;
        private System.Windows.Forms.TextBox textBoxBuyPrice;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label labelEmitent;
        private System.Windows.Forms.ComboBox comboBoxEmitents;
    }
}