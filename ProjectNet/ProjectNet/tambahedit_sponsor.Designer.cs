namespace ProjectNet
{
    partial class tambahedit_sponsor
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
            this.btnbatal = new System.Windows.Forms.Button();
            this.btnsimpan = new System.Windows.Forms.Button();
            this.txtdeskripsi = new System.Windows.Forms.TextBox();
            this.txtnamasponsor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnbatal
            // 
            this.btnbatal.Location = new System.Drawing.Point(197, 126);
            this.btnbatal.Name = "btnbatal";
            this.btnbatal.Size = new System.Drawing.Size(75, 23);
            this.btnbatal.TabIndex = 18;
            this.btnbatal.Text = "Batal";
            this.btnbatal.UseVisualStyleBackColor = true;
            // 
            // btnsimpan
            // 
            this.btnsimpan.Location = new System.Drawing.Point(116, 126);
            this.btnsimpan.Name = "btnsimpan";
            this.btnsimpan.Size = new System.Drawing.Size(75, 23);
            this.btnsimpan.TabIndex = 17;
            this.btnsimpan.Text = "Simpan";
            this.btnsimpan.UseVisualStyleBackColor = true;
            // 
            // txtdeskripsi
            // 
            this.txtdeskripsi.Location = new System.Drawing.Point(116, 93);
            this.txtdeskripsi.Name = "txtdeskripsi";
            this.txtdeskripsi.Size = new System.Drawing.Size(175, 20);
            this.txtdeskripsi.TabIndex = 15;
            // 
            // txtnamasponsor
            // 
            this.txtnamasponsor.Location = new System.Drawing.Point(116, 65);
            this.txtnamasponsor.Name = "txtnamasponsor";
            this.txtnamasponsor.Size = new System.Drawing.Size(175, 20);
            this.txtnamasponsor.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Deskripsi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nama Sponsor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "TAMBAH/EDIT SPONSOR";
            // 
            // tambahedit_sponsor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 183);
            this.Controls.Add(this.btnbatal);
            this.Controls.Add(this.btnsimpan);
            this.Controls.Add(this.txtdeskripsi);
            this.Controls.Add(this.txtnamasponsor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "tambahedit_sponsor";
            this.Text = "tambahedit_sponsor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnbatal;
        private System.Windows.Forms.Button btnsimpan;
        private System.Windows.Forms.TextBox txtdeskripsi;
        private System.Windows.Forms.TextBox txtnamasponsor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}