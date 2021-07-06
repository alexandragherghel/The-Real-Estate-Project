namespace Incercare1
{
    partial class Form3
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.btnSerializare = new System.Windows.Forms.Button();
            this.btnDeserializare = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 311);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 76);
            this.button1.TabIndex = 0;
            this.button1.Text = "Afisare    (CTR+A)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(154, 312);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 76);
            this.button2.TabIndex = 1;
            this.button2.Text = "Salvare  (CTR+S)";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 13);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(775, 266);
            this.textBox1.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(287, 312);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(126, 76);
            this.button3.TabIndex = 3;
            this.button3.Text = "Citire din fisier(CTR+C)";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnSerializare
            // 
            this.btnSerializare.Location = new System.Drawing.Point(456, 312);
            this.btnSerializare.Name = "btnSerializare";
            this.btnSerializare.Size = new System.Drawing.Size(128, 75);
            this.btnSerializare.TabIndex = 4;
            this.btnSerializare.Text = "Serializeaza";
            this.btnSerializare.UseVisualStyleBackColor = true;
            this.btnSerializare.Click += new System.EventHandler(this.btnSerializare_Click);
            // 
            // btnDeserializare
            // 
            this.btnDeserializare.Location = new System.Drawing.Point(637, 312);
            this.btnDeserializare.Name = "btnDeserializare";
            this.btnDeserializare.Size = new System.Drawing.Size(124, 75);
            this.btnDeserializare.TabIndex = 5;
            this.btnDeserializare.Text = "Deserializeaza(CTR+D)";
            this.btnDeserializare.UseVisualStyleBackColor = true;
            this.btnDeserializare.Click += new System.EventHandler(this.btnDeserializare_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 36);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDeserializare);
            this.Controls.Add(this.btnSerializare);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form3_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnSerializare;
        private System.Windows.Forms.Button btnDeserializare;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}