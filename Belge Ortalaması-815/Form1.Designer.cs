namespace Belge_Ortalaması_815
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
            this.txtNot = new System.Windows.Forms.TextBox();
            this.txtDevamsizlik = new System.Windows.Forms.TextBox();
            this.txtZayif = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDurum = new System.Windows.Forms.Label();
            this.btnBelgehesapla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNot
            // 
            this.txtNot.Location = new System.Drawing.Point(132, 67);
            this.txtNot.Name = "txtNot";
            this.txtNot.Size = new System.Drawing.Size(100, 20);
            this.txtNot.TabIndex = 0;
            // 
            // txtDevamsizlik
            // 
            this.txtDevamsizlik.Location = new System.Drawing.Point(132, 93);
            this.txtDevamsizlik.Name = "txtDevamsizlik";
            this.txtDevamsizlik.Size = new System.Drawing.Size(100, 20);
            this.txtDevamsizlik.TabIndex = 1;
            // 
            // txtZayif
            // 
            this.txtZayif.Location = new System.Drawing.Point(132, 115);
            this.txtZayif.Name = "txtZayif";
            this.txtZayif.Size = new System.Drawing.Size(100, 20);
            this.txtZayif.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Not Ortalama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Devamsızlık Sayısı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Zayıf Sayısı";
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDurum.Location = new System.Drawing.Point(32, 207);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(57, 20);
            this.lblDurum.TabIndex = 6;
            this.lblDurum.Text = "Durum";
            // 
            // btnBelgehesapla
            // 
            this.btnBelgehesapla.Location = new System.Drawing.Point(35, 151);
            this.btnBelgehesapla.Name = "btnBelgehesapla";
            this.btnBelgehesapla.Size = new System.Drawing.Size(158, 33);
            this.btnBelgehesapla.TabIndex = 7;
            this.btnBelgehesapla.Text = "Belge Durum Hesapla";
            this.btnBelgehesapla.UseVisualStyleBackColor = true;
            this.btnBelgehesapla.Click += new System.EventHandler(this.btnBelgehesapla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBelgehesapla);
            this.Controls.Add(this.lblDurum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtZayif);
            this.Controls.Add(this.txtDevamsizlik);
            this.Controls.Add(this.txtNot);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNot;
        private System.Windows.Forms.TextBox txtDevamsizlik;
        private System.Windows.Forms.TextBox txtZayif;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.Button btnBelgehesapla;
    }
}

