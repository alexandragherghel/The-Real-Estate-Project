namespace Incercare1
{
    partial class Cereri2
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
            this.gv = new System.Windows.Forms.DataGridView();
            this.insertbtn = new System.Windows.Forms.Button();
            this.tbNume = new System.Windows.Forms.TextBox();
            this.tbImobil = new System.Windows.Forms.TextBox();
            this.tbCartier = new System.Windows.Forms.TextBox();
            this.tbNrCamere = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.codImobil1 = new Incercare1.CodImobil();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gv
            // 
            this.gv.AllowUserToAddRows = false;
            this.gv.AllowUserToDeleteRows = false;
            this.gv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv.Location = new System.Drawing.Point(12, 279);
            this.gv.Name = "gv";
            this.gv.ReadOnly = true;
            this.gv.RowHeadersWidth = 62;
            this.gv.RowTemplate.Height = 28;
            this.gv.Size = new System.Drawing.Size(776, 299);
            this.gv.TabIndex = 0;
            // 
            // insertbtn
            // 
            this.insertbtn.Location = new System.Drawing.Point(637, 99);
            this.insertbtn.Name = "insertbtn";
            this.insertbtn.Size = new System.Drawing.Size(110, 56);
            this.insertbtn.TabIndex = 1;
            this.insertbtn.Text = "insert";
            this.insertbtn.UseVisualStyleBackColor = true;
            this.insertbtn.Click += new System.EventHandler(this.insertbtn_Click);
            // 
            // tbNume
            // 
            this.tbNume.Location = new System.Drawing.Point(309, 24);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(251, 26);
            this.tbNume.TabIndex = 2;
            // 
            // tbImobil
            // 
            this.tbImobil.Location = new System.Drawing.Point(309, 77);
            this.tbImobil.Name = "tbImobil";
            this.tbImobil.Size = new System.Drawing.Size(251, 26);
            this.tbImobil.TabIndex = 3;
            // 
            // tbCartier
            // 
            this.tbCartier.Location = new System.Drawing.Point(309, 129);
            this.tbCartier.Name = "tbCartier";
            this.tbCartier.Size = new System.Drawing.Size(251, 26);
            this.tbCartier.TabIndex = 4;
            // 
            // tbNrCamere
            // 
            this.tbNrCamere.Location = new System.Drawing.Point(309, 180);
            this.tbNrCamere.Name = "tbNrCamere";
            this.tbNrCamere.Size = new System.Drawing.Size(251, 26);
            this.tbNrCamere.TabIndex = 5;
            this.tbNrCamere.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNrCamere_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(212, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nume";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Imobil";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(212, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cartier";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(187, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "NrCamere";
            // 
            // codImobil1
            // 
            this.codImobil1.Location = new System.Drawing.Point(142, 217);
            this.codImobil1.Name = "codImobil1";
            this.codImobil1.Size = new System.Drawing.Size(440, 56);
            this.codImobil1.TabIndex = 10;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Cereri2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 590);
            this.Controls.Add(this.codImobil1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNrCamere);
            this.Controls.Add(this.tbCartier);
            this.Controls.Add(this.tbImobil);
            this.Controls.Add(this.tbNume);
            this.Controls.Add(this.insertbtn);
            this.Controls.Add(this.gv);
            this.Name = "Cereri2";
            this.Text = "Cereri2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Cereri2_FormClosing);
            this.Load += new System.EventHandler(this.Cereri2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gv;
        private System.Windows.Forms.Button insertbtn;
        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.TextBox tbImobil;
        private System.Windows.Forms.TextBox tbCartier;
        private System.Windows.Forms.TextBox tbNrCamere;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private CodImobil codImobil1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}