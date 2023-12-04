namespace ProjectNet
{
    partial class tambahedit_peserta
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtnamapeserta = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtnohanphone = new System.Windows.Forms.TextBox();
            this.btnsimpan = new System.Windows.Forms.Button();
            this.btnbatal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "TAMBAH/EDIT PESERTA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nama Peserta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "No. Handphone";
            // 
            // txtnamapeserta
            // 
            this.txtnamapeserta.Location = new System.Drawing.Point(119, 51);
            this.txtnamapeserta.Name = "txtnamapeserta";
            this.txtnamapeserta.Size = new System.Drawing.Size(175, 20);
            this.txtnamapeserta.TabIndex = 5;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(119, 79);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(175, 20);
            this.txtemail.TabIndex = 6;
            // 
            // txtnohanphone
            // 
            this.txtnohanphone.Location = new System.Drawing.Point(119, 109);
            this.txtnohanphone.Name = "txtnohanphone";
            this.txtnohanphone.Size = new System.Drawing.Size(175, 20);
            this.txtnohanphone.TabIndex = 7;
            // 
            // btnsimpan
            // 
            this.btnsimpan.Location = new System.Drawing.Point(119, 150);
            this.btnsimpan.Name = "btnsimpan";
            this.btnsimpan.Size = new System.Drawing.Size(75, 23);
            this.btnsimpan.TabIndex = 8;
            this.btnsimpan.Text = "Simpan";
            this.btnsimpan.UseVisualStyleBackColor = true;
            // 
            // btnbatal
            // 
            this.btnbatal.Location = new System.Drawing.Point(200, 150);
            this.btnbatal.Name = "btnbatal";
            this.btnbatal.Size = new System.Drawing.Size(75, 23);
            this.btnbatal.TabIndex = 9;
            this.btnbatal.Text = "Batal";
            this.btnbatal.UseVisualStyleBackColor = true;
            // 
            // tambahedit_peserta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 192);
            this.Controls.Add(this.btnbatal);
            this.Controls.Add(this.btnsimpan);
            this.Controls.Add(this.txtnohanphone);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtnamapeserta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "tambahedit_peserta";
            this.Text = "tambahedit_peserta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtnamapeserta;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtnohanphone;
        private System.Windows.Forms.Button btnsimpan;
        private System.Windows.Forms.Button btnbatal;
    }
}