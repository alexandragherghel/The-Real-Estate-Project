namespace Incercare1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.vanzariToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inchirieriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oferteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deVanzareToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deInchiriatToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.despreNoiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graficToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detaliiConcursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.echipaNoastraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vanzariToolStripMenuItem,
            this.inchirieriToolStripMenuItem,
            this.oferteToolStripMenuItem,
            this.despreNoiToolStripMenuItem,
            this.echipaNoastraToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(753, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // vanzariToolStripMenuItem
            // 
            this.vanzariToolStripMenuItem.Name = "vanzariToolStripMenuItem";
            this.vanzariToolStripMenuItem.Size = new System.Drawing.Size(161, 29);
            this.vanzariToolStripMenuItem.Text = "Tipuri de imobile";
            this.vanzariToolStripMenuItem.Click += new System.EventHandler(this.vanzariToolStripMenuItem_Click);
            // 
            // inchirieriToolStripMenuItem
            // 
            this.inchirieriToolStripMenuItem.Name = "inchirieriToolStripMenuItem";
            this.inchirieriToolStripMenuItem.Size = new System.Drawing.Size(94, 29);
            this.inchirieriToolStripMenuItem.Text = "Inchirieri";
            this.inchirieriToolStripMenuItem.Click += new System.EventHandler(this.inchirieriToolStripMenuItem_Click);
            // 
            // oferteToolStripMenuItem
            // 
            this.oferteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deVanzareToolStripMenuItem1,
            this.deInchiriatToolStripMenuItem1});
            this.oferteToolStripMenuItem.Name = "oferteToolStripMenuItem";
            this.oferteToolStripMenuItem.Size = new System.Drawing.Size(78, 29);
            this.oferteToolStripMenuItem.Text = "Oferte";
            // 
            // deVanzareToolStripMenuItem1
            // 
            this.deVanzareToolStripMenuItem1.Name = "deVanzareToolStripMenuItem1";
            this.deVanzareToolStripMenuItem1.Size = new System.Drawing.Size(202, 34);
            this.deVanzareToolStripMenuItem1.Text = "De Vanzare";
            this.deVanzareToolStripMenuItem1.Click += new System.EventHandler(this.deVanzareToolStripMenuItem1_Click);
            // 
            // deInchiriatToolStripMenuItem1
            // 
            this.deInchiriatToolStripMenuItem1.Name = "deInchiriatToolStripMenuItem1";
            this.deInchiriatToolStripMenuItem1.Size = new System.Drawing.Size(202, 34);
            this.deInchiriatToolStripMenuItem1.Text = "De inchiriat";
            this.deInchiriatToolStripMenuItem1.Click += new System.EventHandler(this.deInchiriatToolStripMenuItem1_Click_1);
            // 
            // despreNoiToolStripMenuItem
            // 
            this.despreNoiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.graficToolStripMenuItem,
            this.detaliiConcursToolStripMenuItem});
            this.despreNoiToolStripMenuItem.Name = "despreNoiToolStripMenuItem";
            this.despreNoiToolStripMenuItem.Size = new System.Drawing.Size(143, 29);
            this.despreNoiToolStripMenuItem.Text = "Informatii utile";
            // 
            // graficToolStripMenuItem
            // 
            this.graficToolStripMenuItem.Name = "graficToolStripMenuItem";
            this.graficToolStripMenuItem.Size = new System.Drawing.Size(284, 34);
            this.graficToolStripMenuItem.Text = "Grafic indice imobiliar";
            this.graficToolStripMenuItem.Click += new System.EventHandler(this.graficToolStripMenuItem_Click);
            // 
            // detaliiConcursToolStripMenuItem
            // 
            this.detaliiConcursToolStripMenuItem.Name = "detaliiConcursToolStripMenuItem";
            this.detaliiConcursToolStripMenuItem.Size = new System.Drawing.Size(284, 34);
            this.detaliiConcursToolStripMenuItem.Text = "Detalii concurs";
            this.detaliiConcursToolStripMenuItem.Click += new System.EventHandler(this.detaliiConcursToolStripMenuItem_Click);
            // 
            // echipaNoastraToolStripMenuItem
            // 
            this.echipaNoastraToolStripMenuItem.Name = "echipaNoastraToolStripMenuItem";
            this.echipaNoastraToolStripMenuItem.Size = new System.Drawing.Size(143, 29);
            this.echipaNoastraToolStripMenuItem.Text = "Echipa noastra";
            this.echipaNoastraToolStripMenuItem.Click += new System.EventHandler(this.echipaNoastraToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(29, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(673, 66);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cumparati un imobil completand o cerere aici";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.linkLabel1.Location = new System.Drawing.Point(3, 34);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(249, 20);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "CURSUL DE SCHIMB VALUTAR";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Location = new System.Drawing.Point(29, 206);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(249, 93);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.linkLabel2);
            this.panel2.Location = new System.Drawing.Point(441, 206);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(231, 79);
            this.panel2.TabIndex = 5;
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.linkLabel2.Location = new System.Drawing.Point(89, 34);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(97, 20);
            this.linkLabel2.TabIndex = 4;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "CALENDAR";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.linkLabel3);
            this.panel3.Location = new System.Drawing.Point(32, 343);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(249, 93);
            this.panel3.TabIndex = 6;
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.linkLabel3.Location = new System.Drawing.Point(3, 34);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(195, 20);
            this.linkLabel3.TabIndex = 3;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "PROGRAM PRIMA CASA\r\n";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(547, 348);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 54);
            this.button2.TabIndex = 7;
            this.button2.Text = "CONCURS";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(753, 478);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MaximumSize = new System.Drawing.Size(800, 800);
            this.MinimumSize = new System.Drawing.Size(715, 505);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem vanzariToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inchirieriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oferteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem despreNoiToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.ToolStripMenuItem echipaNoastraToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripMenuItem deVanzareToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deInchiriatToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem graficToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detaliiConcursToolStripMenuItem;
    }
}

