namespace ProjectNet
{
    partial class manajement_event
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
            this.dgvevent = new System.Windows.Forms.DataGridView();
            this.colnamaevent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coltanggalmulai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coltanggalselesai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collokasi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coldeskripsi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coljmlpeserta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coljmlpembicara = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coljmlsponsor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.btntambah = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnhapus = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnlogout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvevent)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvevent
            // 
            this.dgvevent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvevent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colnamaevent,
            this.coltanggalmulai,
            this.coltanggalselesai,
            this.collokasi,
            this.coldeskripsi,
            this.coljmlpeserta,
            this.coljmlpembicara,
            this.coljmlsponsor});
            this.dgvevent.Location = new System.Drawing.Point(5, 87);
            this.dgvevent.Name = "dgvevent";
            this.dgvevent.Size = new System.Drawing.Size(837, 183);
            this.dgvevent.TabIndex = 12;
            this.dgvevent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // colnamaevent
            // 
            this.colnamaevent.HeaderText = "Nama Event";
            this.colnamaevent.Name = "colnamaevent";
            // 
            // coltanggalmulai
            // 
            this.coltanggalmulai.HeaderText = "Tanggal Mulai";
            this.coltanggalmulai.Name = "coltanggalmulai";
            // 
            // coltanggalselesai
            // 
            this.coltanggalselesai.HeaderText = "Tanggal Selesai";
            this.coltanggalselesai.Name = "coltanggalselesai";
            // 
            // collokasi
            // 
            this.collokasi.HeaderText = "Lokasi";
            this.collokasi.Name = "collokasi";
            // 
            // coldeskripsi
            // 
            this.coldeskripsi.HeaderText = "Deskripsi";
            this.coldeskripsi.Name = "coldeskripsi";
            // 
            // coljmlpeserta
            // 
            this.coljmlpeserta.HeaderText = "Jumlah Peserta";
            this.coljmlpeserta.Name = "coljmlpeserta";
            // 
            // coljmlpembicara
            // 
            this.coljmlpembicara.HeaderText = "Jumlah Pembicara";
            this.coljmlpembicara.Name = "coljmlpembicara";
            // 
            // coljmlsponsor
            // 
            this.coljmlsponsor.HeaderText = "Jumlah Sponsor";
            this.coljmlsponsor.Name = "coljmlsponsor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label6.Location = new System.Drawing.Point(339, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(229, 24);
            this.label6.TabIndex = 13;
            this.label6.Text = "MANAJEMENT EVENT";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btntambah
            // 
            this.btntambah.Location = new System.Drawing.Point(8, 58);
            this.btntambah.Name = "btntambah";
            this.btntambah.Size = new System.Drawing.Size(75, 23);
            this.btntambah.TabIndex = 14;
            this.btntambah.Text = "Tambah";
            this.btntambah.UseVisualStyleBackColor = true;
            this.btntambah.Click += new System.EventHandler(this.btntambah_Click);
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(89, 58);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(75, 23);
            this.btnedit.TabIndex = 15;
            this.btnedit.Text = "Edit";
            this.btnedit.UseVisualStyleBackColor = true;
            // 
            // btnhapus
            // 
            this.btnhapus.Location = new System.Drawing.Point(170, 58);
            this.btnhapus.Name = "btnhapus";
            this.btnhapus.Size = new System.Drawing.Size(75, 23);
            this.btnhapus.TabIndex = 16;
            this.btnhapus.Text = "Hapus";
            this.btnhapus.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 276);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Daftar Peserta";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(172, 276);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "Daftar Pembicara";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(329, 276);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(151, 23);
            this.button3.TabIndex = 19;
            this.button3.Text = "Daftar Sponsor";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnlogout
            // 
            this.btnlogout.Location = new System.Drawing.Point(767, 276);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(75, 23);
            this.btnlogout.TabIndex = 20;
            this.btnlogout.Text = "Logout";
            this.btnlogout.UseVisualStyleBackColor = true;
            // 
            // manajement_event
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 311);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnhapus);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btntambah);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvevent);
            this.Name = "manajement_event";
            this.Text = "manajement_event";
            this.Load += new System.EventHandler(this.manajement_event_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvevent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvevent;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btntambah;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnhapus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colnamaevent;
        private System.Windows.Forms.DataGridViewTextBoxColumn coltanggalmulai;
        private System.Windows.Forms.DataGridViewTextBoxColumn coltanggalselesai;
        private System.Windows.Forms.DataGridViewTextBoxColumn collokasi;
        private System.Windows.Forms.DataGridViewTextBoxColumn coldeskripsi;
        private System.Windows.Forms.DataGridViewTextBoxColumn coljmlpeserta;
        private System.Windows.Forms.DataGridViewTextBoxColumn coljmlpembicara;
        private System.Windows.Forms.DataGridViewTextBoxColumn coljmlsponsor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnlogout;
    }
}