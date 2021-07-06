namespace Incercare1
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.buttonAdauga = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.tb4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb5 = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.codImobil1 = new Incercare1.CodImobil();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAdauga
            // 
            this.buttonAdauga.Location = new System.Drawing.Point(249, 382);
            this.buttonAdauga.Name = "buttonAdauga";
            this.buttonAdauga.Size = new System.Drawing.Size(166, 56);
            this.buttonAdauga.TabIndex = 0;
            this.buttonAdauga.Text = "Adauga";
            this.buttonAdauga.UseVisualStyleBackColor = true;
            this.buttonAdauga.Click += new System.EventHandler(this.buttonAdauga_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(536, 382);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(202, 56);
            this.button2.TabIndex = 1;
            this.button2.Text = "Finalizeaza inchirierea";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(222, 47);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(250, 26);
            this.tb1.TabIndex = 2;
            // 
            // tb2
            // 
            this.tb2.Location = new System.Drawing.Point(222, 111);
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(250, 26);
            this.tb2.TabIndex = 3;
            // 
            // tb4
            // 
            this.tb4.Location = new System.Drawing.Point(222, 248);
            this.tb4.Name = "tb4";
            this.tb4.Size = new System.Drawing.Size(250, 26);
            this.tb4.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nume persoana";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nr telefon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Data inceput";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(90, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Data sfarsit";
            // 
            // tb5
            // 
            this.tb5.Location = new System.Drawing.Point(222, 308);
            this.tb5.Name = "tb5";
            this.tb5.Size = new System.Drawing.Size(250, 26);
            this.tb5.TabIndex = 11;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // codImobil1
            // 
            this.codImobil1.Location = new System.Drawing.Point(54, 167);
            this.codImobil1.Name = "codImobil1";
            this.codImobil1.Size = new System.Drawing.Size(440, 56);
            this.codImobil1.TabIndex = 12;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.codImobil1);
            this.Controls.Add(this.tb5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb4);
            this.Controls.Add(this.tb2);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonAdauga);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdauga;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.TextBox tb4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb5;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private CodImobil codImobil1;
    }
}