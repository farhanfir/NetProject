namespace ProjectNet
{
    partial class daftar_pembicara
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
            this.btnkembali = new System.Windows.Forms.Button();
            this.btnhapus = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btntambah = new System.Windows.Forms.Button();
            this.dgvpembicara = new System.Windows.Forms.DataGridView();
            this.cbeventselect = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.colnamapembicara = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colprofesi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colbio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpembicara)).BeginInit();
            this.SuspendLayout();
            // 
            // btnkembali
            // 
            this.btnkembali.Location = new System.Drawing.Point(22, 263);
            this.btnkembali.Name = "btnkembali";
            this.btnkembali.Size = new System.Drawing.Size(75, 23);
            this.btnkembali.TabIndex = 15;
            this.btnkembali.Text = "Kembali";
            this.btnkembali.UseVisualStyleBackColor = true;
            // 
            // btnhapus
            // 
            this.btnhapus.Location = new System.Drawing.Point(184, 234);
            this.btnhapus.Name = "btnhapus";
            this.btnhapus.Size = new System.Drawing.Size(75, 23);
            this.btnhapus.TabIndex = 14;
            this.btnhapus.Text = "Hapus";
            this.btnhapus.UseVisualStyleBackColor = true;
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(103, 234);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(75, 23);
            this.btnedit.TabIndex = 13;
            this.btnedit.Text = "Edit";
            this.btnedit.UseVisualStyleBackColor = true;
            // 
            // btntambah
            // 
            this.btntambah.Location = new System.Drawing.Point(22, 234);
            this.btntambah.Name = "btntambah";
            this.btntambah.Size = new System.Drawing.Size(75, 23);
            this.btntambah.TabIndex = 12;
            this.btntambah.Text = "Tambah";
            this.btntambah.UseVisualStyleBackColor = true;
            // 
            // dgvpembicara
            // 
            this.dgvpembicara.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvpembicara.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colnamapembicara,
            this.colprofesi,
            this.colbio});
            this.dgvpembicara.Location = new System.Drawing.Point(22, 87);
            this.dgvpembicara.Name = "dgvpembicara";
            this.dgvpembicara.Size = new System.Drawing.Size(347, 140);
            this.dgvpembicara.TabIndex = 11;
            // 
            // cbeventselect
            // 
            this.cbeventselect.FormattingEnabled = true;
            this.cbeventselect.Location = new System.Drawing.Point(60, 60);
            this.cbeventselect.Name = "cbeventselect";
            this.cbeventselect.Size = new System.Drawing.Size(172, 21);
            this.cbeventselect.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Event";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "DAFTAR PEMBICARA";
            // 
            // colnamapembicara
            // 
            this.colnamapembicara.HeaderText = "Nama Pembicara";
            this.colnamapembicara.Name = "colnamapembicara";
            // 
            // colprofesi
            // 
            this.colprofesi.HeaderText = "Profesi";
            this.colprofesi.Name = "colprofesi";
            // 
            // colbio
            // 
            this.colbio.HeaderText = "Bio";
            this.colbio.Name = "colbio";
            // 
            // daftar_pembicara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 296);
            this.Controls.Add(this.btnkembali);
            this.Controls.Add(this.btnhapus);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btntambah);
            this.Controls.Add(this.dgvpembicara);
            this.Controls.Add(this.cbeventselect);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "daftar_pembicara";
            this.Text = "daftar_pembicara";
            ((System.ComponentModel.ISupportInitialize)(this.dgvpembicara)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnkembali;
        private System.Windows.Forms.Button btnhapus;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btntambah;
        private System.Windows.Forms.DataGridView dgvpembicara;
        private System.Windows.Forms.ComboBox cbeventselect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colnamapembicara;
        private System.Windows.Forms.DataGridViewTextBoxColumn colprofesi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbio;
    }
}