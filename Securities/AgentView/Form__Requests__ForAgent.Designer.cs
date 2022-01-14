
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
            this.buttonCheckRequest = new System.Windows.Forms.Button();
            this.dataGridViewRequestsWithPayments = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRequestsWithOutPayments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRequestsWithPayments)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewRequestsWithOutPayments
            // 
            this.dataGridViewRequestsWithOutPayments.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewRequestsWithOutPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRequestsWithOutPayments.Location = new System.Drawing.Point(20, 20);
            this.dataGridViewRequestsWithOutPayments.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewRequestsWithOutPayments.Name = "dataGridViewRequestsWithOutPayments";
            this.dataGridViewRequestsWithOutPayments.RowHeadersWidth = 62;
            this.dataGridViewRequestsWithOutPayments.Size = new System.Drawing.Size(1323, 428);
            this.dataGridViewRequestsWithOutPayments.TabIndex = 0;
            this.dataGridViewRequestsWithOutPayments.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dataGridViewRequestsWithOutPayments_RowStateChanged);
            // 
            // buttonCheckRequest
            // 
            this.buttonCheckRequest.Location = new System.Drawing.Point(1352, 243);
            this.buttonCheckRequest.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonCheckRequest.Name = "buttonCheckRequest";
            this.buttonCheckRequest.Size = new System.Drawing.Size(134, 35);
            this.buttonCheckRequest.TabIndex = 1;
            this.buttonCheckRequest.Text = "Просмотреть";
            this.buttonCheckRequest.UseVisualStyleBackColor = true;
            this.buttonCheckRequest.Click += new System.EventHandler(this.buttonCheckRequest_Click);
            // 
            // dataGridViewRequestsWithPayments
            // 
            this.dataGridViewRequestsWithPayments.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewRequestsWithPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRequestsWithPayments.Location = new System.Drawing.Point(20, 480);
            this.dataGridViewRequestsWithPayments.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewRequestsWithPayments.Name = "dataGridViewRequestsWithPayments";
            this.dataGridViewRequestsWithPayments.RowHeadersWidth = 62;
            this.dataGridViewRequestsWithPayments.Size = new System.Drawing.Size(1323, 428);
            this.dataGridViewRequestsWithPayments.TabIndex = 2;
            // 
            // Form__Requests__ForAgent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1766, 985);
            this.Controls.Add(this.dataGridViewRequestsWithPayments);
            this.Controls.Add(this.buttonCheckRequest);
            this.Controls.Add(this.dataGridViewRequestsWithOutPayments);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form__Requests__ForAgent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Заявки для обработки";
            this.Load += new System.EventHandler(this.FormRequestsForAgent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRequestsWithOutPayments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRequestsWithPayments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewRequestsWithOutPayments;
        private System.Windows.Forms.Button buttonCheckRequest;
        private System.Windows.Forms.DataGridView dataGridViewRequestsWithPayments;
    }
}