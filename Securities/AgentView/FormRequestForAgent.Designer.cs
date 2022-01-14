
namespace Securities.AgentView
{
    partial class FormRequestForAgent
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
            this.dataGridViewRequest = new System.Windows.Forms.DataGridView();
            this.dataGridViewSecuritiesInBag = new System.Windows.Forms.DataGridView();
            this.buttonContractWithEmitents = new System.Windows.Forms.Button();
            this.buttonContractsWithClients = new System.Windows.Forms.Button();
            this.buttonPaymentContractWithEmitents = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRequest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSecuritiesInBag)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewRequest
            // 
            this.dataGridViewRequest.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewRequest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRequest.Location = new System.Drawing.Point(12, 70);
            this.dataGridViewRequest.Name = "dataGridViewRequest";
            this.dataGridViewRequest.RowHeadersWidth = 62;
            this.dataGridViewRequest.RowTemplate.Height = 28;
            this.dataGridViewRequest.Size = new System.Drawing.Size(762, 115);
            this.dataGridViewRequest.TabIndex = 0;
            // 
            // dataGridViewSecuritiesInBag
            // 
            this.dataGridViewSecuritiesInBag.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewSecuritiesInBag.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSecuritiesInBag.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridViewSecuritiesInBag.Location = new System.Drawing.Point(12, 225);
            this.dataGridViewSecuritiesInBag.Name = "dataGridViewSecuritiesInBag";
            this.dataGridViewSecuritiesInBag.RowHeadersWidth = 62;
            this.dataGridViewSecuritiesInBag.RowTemplate.Height = 28;
            this.dataGridViewSecuritiesInBag.Size = new System.Drawing.Size(762, 429);
            this.dataGridViewSecuritiesInBag.TabIndex = 1;
            // 
            // buttonContractWithEmitents
            // 
            this.buttonContractWithEmitents.Location = new System.Drawing.Point(802, 29);
            this.buttonContractWithEmitents.Name = "buttonContractWithEmitents";
            this.buttonContractWithEmitents.Size = new System.Drawing.Size(247, 98);
            this.buttonContractWithEmitents.TabIndex = 3;
            this.buttonContractWithEmitents.Text = "Оформить договора с эмитентами";
            this.buttonContractWithEmitents.UseVisualStyleBackColor = true;
            this.buttonContractWithEmitents.Click += new System.EventHandler(this.buttonContractWithEmitents_Click);
            // 
            // buttonContractsWithClients
            // 
            this.buttonContractsWithClients.Location = new System.Drawing.Point(802, 153);
            this.buttonContractsWithClients.Name = "buttonContractsWithClients";
            this.buttonContractsWithClients.Size = new System.Drawing.Size(247, 98);
            this.buttonContractsWithClients.TabIndex = 4;
            this.buttonContractsWithClients.Text = "Оформить договр с клиентом";
            this.buttonContractsWithClients.UseVisualStyleBackColor = true;
            // 
            // buttonPaymentContractWithEmitents
            // 
            this.buttonPaymentContractWithEmitents.Location = new System.Drawing.Point(802, 272);
            this.buttonPaymentContractWithEmitents.Name = "buttonPaymentContractWithEmitents";
            this.buttonPaymentContractWithEmitents.Size = new System.Drawing.Size(247, 98);
            this.buttonPaymentContractWithEmitents.TabIndex = 5;
            this.buttonPaymentContractWithEmitents.Text = "Оплатить договра с эмитентами";
            this.buttonPaymentContractWithEmitents.UseVisualStyleBackColor = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Информация о заявке";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(396, 30);
            this.label2.TabIndex = 7;
            this.label2.Text = "Список ценных бумаг в портфеле";
            // 
            // FormRequestForAgent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonPaymentContractWithEmitents);
            this.Controls.Add(this.buttonContractsWithClients);
            this.Controls.Add(this.buttonContractWithEmitents);
            this.Controls.Add(this.dataGridViewSecuritiesInBag);
            this.Controls.Add(this.dataGridViewRequest);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormRequestForAgent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Обрабатываемая заявка";
            this.Load += new System.EventHandler(this.FormRequestsForAgent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRequest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSecuritiesInBag)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewRequest;
        private System.Windows.Forms.DataGridView dataGridViewSecuritiesInBag;
        private System.Windows.Forms.Button buttonContractWithEmitents;
        private System.Windows.Forms.Button buttonContractsWithClients;
        private System.Windows.Forms.Button buttonPaymentContractWithEmitents;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}