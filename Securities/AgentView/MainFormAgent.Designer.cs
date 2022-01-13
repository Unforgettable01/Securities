
namespace Securities
{
    partial class MainFormAgent
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.справочникиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.клиентыToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.агентыToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.эмитентыToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ценныеБумагиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заявкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.договораToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оплатыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справочникиToolStripMenuItem1,
            this.заявкиToolStripMenuItem,
            this.договораToolStripMenuItem,
            this.оплатыToolStripMenuItem,
            this.отчетыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1764, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // справочникиToolStripMenuItem1
            // 
            this.справочникиToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.клиентыToolStripMenuItem1,
            this.агентыToolStripMenuItem1,
            this.эмитентыToolStripMenuItem1,
            this.ценныеБумагиToolStripMenuItem});
            this.справочникиToolStripMenuItem1.Name = "справочникиToolStripMenuItem1";
            this.справочникиToolStripMenuItem1.Size = new System.Drawing.Size(139, 29);
            this.справочникиToolStripMenuItem1.Text = "Справочники";
            // 
            // клиентыToolStripMenuItem1
            // 
            this.клиентыToolStripMenuItem1.Name = "клиентыToolStripMenuItem1";
            this.клиентыToolStripMenuItem1.Size = new System.Drawing.Size(270, 34);
            this.клиентыToolStripMenuItem1.Text = "Клиенты";
            this.клиентыToolStripMenuItem1.Click += new System.EventHandler(this.клиентыToolStripMenuItem1_Click);
            // 
            // агентыToolStripMenuItem1
            // 
            this.агентыToolStripMenuItem1.Name = "агентыToolStripMenuItem1";
            this.агентыToolStripMenuItem1.Size = new System.Drawing.Size(270, 34);
            this.агентыToolStripMenuItem1.Text = "Агенты";
            // 
            // эмитентыToolStripMenuItem1
            // 
            this.эмитентыToolStripMenuItem1.Name = "эмитентыToolStripMenuItem1";
            this.эмитентыToolStripMenuItem1.Size = new System.Drawing.Size(270, 34);
            this.эмитентыToolStripMenuItem1.Text = "Эмитенты";
            this.эмитентыToolStripMenuItem1.Click += new System.EventHandler(this.эмитентыToolStripMenuItem1_Click);
            // 
            // ценныеБумагиToolStripMenuItem
            // 
            this.ценныеБумагиToolStripMenuItem.Name = "ценныеБумагиToolStripMenuItem";
            this.ценныеБумагиToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.ценныеБумагиToolStripMenuItem.Text = "Ценные бумаги";
            this.ценныеБумагиToolStripMenuItem.Click += new System.EventHandler(this.ценныеБумагиToolStripMenuItem_Click);
            // 
            // заявкиToolStripMenuItem
            // 
            this.заявкиToolStripMenuItem.Name = "заявкиToolStripMenuItem";
            this.заявкиToolStripMenuItem.Size = new System.Drawing.Size(85, 29);
            this.заявкиToolStripMenuItem.Text = "Заявки";
            // 
            // договораToolStripMenuItem
            // 
            this.договораToolStripMenuItem.Name = "договораToolStripMenuItem";
            this.договораToolStripMenuItem.Size = new System.Drawing.Size(110, 29);
            this.договораToolStripMenuItem.Text = "Договора";
            // 
            // оплатыToolStripMenuItem
            // 
            this.оплатыToolStripMenuItem.Name = "оплатыToolStripMenuItem";
            this.оплатыToolStripMenuItem.Size = new System.Drawing.Size(90, 29);
            this.оплатыToolStripMenuItem.Text = "Оплаты";
            // 
            // отчетыToolStripMenuItem
            // 
            this.отчетыToolStripMenuItem.Name = "отчетыToolStripMenuItem";
            this.отчетыToolStripMenuItem.Size = new System.Drawing.Size(88, 29);
            this.отчетыToolStripMenuItem.Text = "Отчеты";
            // 
            // MainFormAgent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1764, 845);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainFormAgent";
            this.Text = "Главная форма агента";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem заявкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem договораToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оплатыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справочникиToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem клиентыToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem агентыToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem эмитентыToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ценныеБумагиToolStripMenuItem;
    }
}