
namespace Securities.AgentView
{
    partial class Form__Requests__ForAgent
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
            this.dataGridViewRequestsWithOutPayments = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewRequestsWithPayments = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRequestsWithOutPayments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRequestsWithPayments)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewRequestsWithOutPayments
            // 
            this.dataGridViewRequestsWithOutPayments.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewRequestsWithOutPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRequestsWithOutPayments.Location = new System.Drawing.Point(13, 13);
            this.dataGridViewRequestsWithOutPayments.Name = "dataGridViewRequestsWithOutPayments";
            this.dataGridViewRequestsWithOutPayments.Size = new System.Drawing.Size(882, 278);
            this.dataGridViewRequestsWithOutPayments.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(901, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewRequestsWithPayments
            // 
            this.dataGridViewRequestsWithPayments.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewRequestsWithPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRequestsWithPayments.Location = new System.Drawing.Point(13, 312);
            this.dataGridViewRequestsWithPayments.Name = "dataGridViewRequestsWithPayments";
            this.dataGridViewRequestsWithPayments.Size = new System.Drawing.Size(882, 278);
            this.dataGridViewRequestsWithPayments.TabIndex = 2;
            // 
            // Form__Requests__ForAgent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 640);
            this.Controls.Add(this.dataGridViewRequestsWithPayments);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewRequestsWithOutPayments);
            this.Name = "Form__Requests__ForAgent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Заявки для обработки";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRequestsWithOutPayments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRequestsWithPayments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewRequestsWithOutPayments;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridViewRequestsWithPayments;
    }
}