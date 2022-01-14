
namespace Securities.ClientView
{
    partial class FormRequest
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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonRef = new System.Windows.Forms.Button();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelBag = new System.Windows.Forms.Label();
            this.labelSum = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.comboBoxBag = new System.Windows.Forms.ComboBox();
            this.textBoxSum = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRequest)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewRequest
            // 
            this.dataGridViewRequest.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewRequest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRequest.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewRequest.Name = "dataGridViewRequest";
            this.dataGridViewRequest.RowHeadersWidth = 62;
            this.dataGridViewRequest.RowTemplate.Height = 28;
            this.dataGridViewRequest.Size = new System.Drawing.Size(793, 520);
            this.dataGridViewRequest.TabIndex = 0;
            this.dataGridViewRequest.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewRequest_RowHeaderMouseClick);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(840, 159);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(138, 33);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(1014, 159);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(138, 33);
            this.buttonDel.TabIndex = 3;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonRef
            // 
            this.buttonRef.Location = new System.Drawing.Point(1014, 493);
            this.buttonRef.Name = "buttonRef";
            this.buttonRef.Size = new System.Drawing.Size(138, 39);
            this.buttonRef.TabIndex = 4;
            this.buttonRef.Text = "Обновить";
            this.buttonRef.UseVisualStyleBackColor = true;
            this.buttonRef.Click += new System.EventHandler(this.buttonRef_Click);
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(836, 12);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(52, 20);
            this.labelDate.TabIndex = 5;
            this.labelDate.Text = "Дата:";
            // 
            // labelBag
            // 
            this.labelBag.AutoSize = true;
            this.labelBag.Location = new System.Drawing.Point(836, 60);
            this.labelBag.Name = "labelBag";
            this.labelBag.Size = new System.Drawing.Size(95, 20);
            this.labelBag.TabIndex = 6;
            this.labelBag.Text = "Портфель:";
            // 
            // labelSum
            // 
            this.labelSum.AutoSize = true;
            this.labelSum.Location = new System.Drawing.Point(836, 112);
            this.labelSum.Name = "labelSum";
            this.labelSum.Size = new System.Drawing.Size(62, 20);
            this.labelSum.TabIndex = 7;
            this.labelSum.Text = "Сумма:";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(952, 7);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker.TabIndex = 8;
            // 
            // comboBoxBag
            // 
            this.comboBoxBag.FormattingEnabled = true;
            this.comboBoxBag.Location = new System.Drawing.Point(952, 57);
            this.comboBoxBag.Name = "comboBoxBag";
            this.comboBoxBag.Size = new System.Drawing.Size(200, 28);
            this.comboBoxBag.TabIndex = 9;
            this.comboBoxBag.SelectedIndexChanged += new System.EventHandler(this.comboBoxBag_SelectedIndexChanged);
            // 
            // textBoxSum
            // 
            this.textBoxSum.Location = new System.Drawing.Point(952, 109);
            this.textBoxSum.Name = "textBoxSum";
            this.textBoxSum.ReadOnly = true;
            this.textBoxSum.Size = new System.Drawing.Size(200, 26);
            this.textBoxSum.TabIndex = 10;
            // 
            // FormRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 544);
            this.Controls.Add(this.textBoxSum);
            this.Controls.Add(this.comboBoxBag);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.labelSum);
            this.Controls.Add(this.labelBag);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.buttonRef);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridViewRequest);
            this.Name = "FormRequest";
            this.Text = "Заявки";
            this.Load += new System.EventHandler(this.FormRequest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRequest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewRequest;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonRef;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelBag;
        private System.Windows.Forms.Label labelSum;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ComboBox comboBoxBag;
        private System.Windows.Forms.TextBox textBoxSum;
    }
}