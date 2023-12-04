namespace ProjectNet
{
    partial class daftar_peserta
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
            this.cbeventselect = new System.Windows.Forms.ComboBox();
            this.dgvpeserta = new System.Windows.Forms.DataGridView();
            this.colnamapeserta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colemailpeserta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colnomorhandphone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btntambah = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnhapus = new System.Windows.Forms.Button();
            this.btnkembali = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpeserta)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "DAFTAR PESERTA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Event";
            // 
            // cbeventselect
            // 
            this.cbeventselect.FormattingEnabled = true;
            this.cbeventselect.Location = new System.Drawing.Point(77, 63);
            this.cbeventselect.Name = "cbeventselect";
            this.cbeventselect.Size = new System.Drawing.Size(172, 21);
            this.cbeventselect.TabIndex = 2;
            // 
            // dgvpeserta
            // 
            this.dgvpeserta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvpeserta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colnamapeserta,
            this.colemailpeserta,
            this.colnomorhandphone});
            this.dgvpeserta.Location = new System.Drawing.Point(39, 90);
            this.dgvpeserta.Name = "dgvpeserta";
            this.dgvpeserta.Size = new System.Drawing.Size(347, 140);
            this.dgvpeserta.TabIndex = 3;
            // 
            // colnamapeserta
            // 
            this.colnamapeserta.HeaderText = "Nama Peserta";
            this.colnamapeserta.Name = "colnamapeserta";
            // 
            // colemailpeserta
            // 
            this.colemailpeserta.HeaderText = "Email";
            this.colemailpeserta.Name = "colemailpeserta";
            // 
            // colnomorhandphone
            // 
            this.colnomorhandphone.HeaderText = "No. Handphone";
            this.colnomorhandphone.Name = "colnomorhandphone";
            // 
            // btntambah
            // 
            this.btntambah.Location = new System.Drawing.Point(39, 237);
            this.btntambah.Name = "btntambah";
            this.btntambah.Size = new System.Drawing.Size(75, 23);
            this.btntambah.TabIndex = 4;
            this.btntambah.Text = "Tambah";
            this.btntambah.UseVisualStyleBackColor = true;
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(120, 237);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(75, 23);
            this.btnedit.TabIndex = 5;
            this.btnedit.Text = "Edit";
            this.btnedit.UseVisualStyleBackColor = true;
            // 
            // btnhapus
            // 
            this.btnhapus.Location = new System.Drawing.Point(201, 237);
            this.btnhapus.Name = "btnhapus";
            this.btnhapus.Size = new System.Drawing.Size(75, 23);
            this.btnhapus.TabIndex = 6;
            this.btnhapus.Text = "Hapus";
            this.btnhapus.UseVisualStyleBackColor = true;
            // 
            // btnkembali
            // 
            this.btnkembali.Location = new System.Drawing.Point(39, 266);
            this.btnkembali.Name = "btnkembali";
            this.btnkembali.Size = new System.Drawing.Size(75, 23);
            this.btnkembali.TabIndex = 7;
            this.btnkembali.Text = "Kembali";
            this.btnkembali.UseVisualStyleBackColor = true;
            // 
            // daftar_peserta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 299);
            this.Controls.Add(this.btnkembali);
            this.Controls.Add(this.btnhapus);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btntambah);
            this.Controls.Add(this.dgvpeserta);
            this.Controls.Add(this.cbeventselect);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "daftar_peserta";
            this.Text = "daftar_peserta";
            ((System.ComponentModel.ISupportInitialize)(this.dgvpeserta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbeventselect;
        private System.Windows.Forms.DataGridView dgvpeserta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colnamapeserta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colemailpeserta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colnomorhandphone;
        private System.Windows.Forms.Button btntambah;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnhapus;
        private System.Windows.Forms.Button btnkembali;
    }
}