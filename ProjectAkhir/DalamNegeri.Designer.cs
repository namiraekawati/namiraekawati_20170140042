namespace ProjectAkhir
{
    partial class DalamNegeri
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
            this.tbcari = new System.Windows.Forms.TextBox();
            this.btcari = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbid = new System.Windows.Forms.TextBox();
            this.tbjhari = new System.Windows.Forms.TextBox();
            this.tbbiaya = new System.Windows.Forms.TextBox();
            this.tbkuota = new System.Windows.Forms.TextBox();
            this.tbnotel = new System.Windows.Forms.TextBox();
            this.tbalamat = new System.Windows.Forms.TextBox();
            this.tbnama = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idPemesanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaPemesanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noTlpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alamatPemesanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanggalPemesananDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kuotaOrangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jumlahHariDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.biayaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dalamNegeriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTravelDataSet = new ProjectAkhir.DataTravelDataSet();
            this.label6 = new System.Windows.Forms.Label();
            this.dalamNegeriTableAdapter = new ProjectAkhir.DataTravelDataSetTableAdapters.DalamNegeriTableAdapter();
            this.dttgl = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dalamNegeriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTravelDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcari
            // 
            this.tbcari.Location = new System.Drawing.Point(459, 12);
            this.tbcari.Multiline = true;
            this.tbcari.Name = "tbcari";
            this.tbcari.Size = new System.Drawing.Size(345, 35);
            this.tbcari.TabIndex = 0;
            // 
            // btcari
            // 
            this.btcari.BackColor = System.Drawing.Color.YellowGreen;
            this.btcari.Font = new System.Drawing.Font("Lucida Fax", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcari.Location = new System.Drawing.Point(827, 12);
            this.btcari.Name = "btcari";
            this.btcari.Size = new System.Drawing.Size(75, 35);
            this.btcari.TabIndex = 1;
            this.btcari.Text = "Cari";
            this.btcari.UseVisualStyleBackColor = false;
            this.btcari.Click += new System.EventHandler(this.btcari_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.OrangeRed;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(24, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID Pemesan";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.OrangeRed;
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(24, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nama Pemesan";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.OrangeRed;
            this.label3.Font = new System.Drawing.Font("Lucida Fax", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(24, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "No Tlp";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.OrangeRed;
            this.label4.Font = new System.Drawing.Font("Lucida Fax", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(513, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tanggal Pemesanan";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.OrangeRed;
            this.label5.Font = new System.Drawing.Font("Lucida Fax", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(24, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Alamat Pemesan";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.OrangeRed;
            this.label7.Font = new System.Drawing.Font("Lucida Fax", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(516, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Jumlah Hari";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.OrangeRed;
            this.label8.Font = new System.Drawing.Font("Lucida Fax", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(516, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "Biaya";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.OrangeRed;
            this.label10.Font = new System.Drawing.Font("Lucida Fax", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(516, 120);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 16);
            this.label10.TabIndex = 11;
            this.label10.Text = "Kuota Orang";
            // 
            // tbid
            // 
            this.tbid.Location = new System.Drawing.Point(192, 89);
            this.tbid.Name = "tbid";
            this.tbid.Size = new System.Drawing.Size(208, 22);
            this.tbid.TabIndex = 12;
            this.tbid.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.tbid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbid_KeyPress);
            // 
            // tbjhari
            // 
            this.tbjhari.Location = new System.Drawing.Point(695, 147);
            this.tbjhari.Name = "tbjhari";
            this.tbjhari.Size = new System.Drawing.Size(208, 22);
            this.tbjhari.TabIndex = 13;
            // 
            // tbbiaya
            // 
            this.tbbiaya.Location = new System.Drawing.Point(695, 175);
            this.tbbiaya.Name = "tbbiaya";
            this.tbbiaya.Size = new System.Drawing.Size(208, 22);
            this.tbbiaya.TabIndex = 16;
            // 
            // tbkuota
            // 
            this.tbkuota.Location = new System.Drawing.Point(695, 119);
            this.tbkuota.Name = "tbkuota";
            this.tbkuota.Size = new System.Drawing.Size(208, 22);
            this.tbkuota.TabIndex = 17;
            // 
            // tbnotel
            // 
            this.tbnotel.Location = new System.Drawing.Point(192, 142);
            this.tbnotel.Name = "tbnotel";
            this.tbnotel.Size = new System.Drawing.Size(208, 22);
            this.tbnotel.TabIndex = 18;
            // 
            // tbalamat
            // 
            this.tbalamat.Location = new System.Drawing.Point(192, 170);
            this.tbalamat.Name = "tbalamat";
            this.tbalamat.Size = new System.Drawing.Size(208, 22);
            this.tbalamat.TabIndex = 19;
            // 
            // tbnama
            // 
            this.tbnama.Location = new System.Drawing.Point(192, 116);
            this.tbnama.Name = "tbnama";
            this.tbnama.Size = new System.Drawing.Size(208, 22);
            this.tbnama.TabIndex = 21;
            this.tbnama.TextChanged += new System.EventHandler(this.tbnama_TextChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.YellowGreen;
            this.button2.Font = new System.Drawing.Font("Lucida Fax", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(176, 235);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 29);
            this.button2.TabIndex = 22;
            this.button2.Text = "Simpan";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btsimpan);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.YellowGreen;
            this.button3.Font = new System.Drawing.Font("Lucida Fax", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(621, 235);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(131, 29);
            this.button3.TabIndex = 23;
            this.button3.Text = "Refresh";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.YellowGreen;
            this.button4.Font = new System.Drawing.Font("Lucida Fax", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(472, 235);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(130, 29);
            this.button4.TabIndex = 24;
            this.button4.Text = "Hapus";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.YellowGreen;
            this.button5.Font = new System.Drawing.Font("Lucida Fax", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(323, 235);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(130, 29);
            this.button5.TabIndex = 25;
            this.button5.Text = "Edit ";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.YellowGreen;
            this.button6.Font = new System.Drawing.Font("Lucida Fax", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(26, 235);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(130, 29);
            this.button6.TabIndex = 26;
            this.button6.Text = "Tambah Data";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPemesanDataGridViewTextBoxColumn,
            this.namaPemesanDataGridViewTextBoxColumn,
            this.noTlpDataGridViewTextBoxColumn,
            this.alamatPemesanDataGridViewTextBoxColumn,
            this.tanggalPemesananDataGridViewTextBoxColumn,
            this.kuotaOrangDataGridViewTextBoxColumn,
            this.jumlahHariDataGridViewTextBoxColumn,
            this.biayaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dalamNegeriBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(26, 281);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(876, 195);
            this.dataGridView1.TabIndex = 27;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // idPemesanDataGridViewTextBoxColumn
            // 
            this.idPemesanDataGridViewTextBoxColumn.DataPropertyName = "idPemesan";
            this.idPemesanDataGridViewTextBoxColumn.HeaderText = "idPemesan";
            this.idPemesanDataGridViewTextBoxColumn.Name = "idPemesanDataGridViewTextBoxColumn";
            // 
            // namaPemesanDataGridViewTextBoxColumn
            // 
            this.namaPemesanDataGridViewTextBoxColumn.DataPropertyName = "NamaPemesan";
            this.namaPemesanDataGridViewTextBoxColumn.HeaderText = "NamaPemesan";
            this.namaPemesanDataGridViewTextBoxColumn.Name = "namaPemesanDataGridViewTextBoxColumn";
            // 
            // noTlpDataGridViewTextBoxColumn
            // 
            this.noTlpDataGridViewTextBoxColumn.DataPropertyName = "NoTlp";
            this.noTlpDataGridViewTextBoxColumn.HeaderText = "NoTlp";
            this.noTlpDataGridViewTextBoxColumn.Name = "noTlpDataGridViewTextBoxColumn";
            // 
            // alamatPemesanDataGridViewTextBoxColumn
            // 
            this.alamatPemesanDataGridViewTextBoxColumn.DataPropertyName = "AlamatPemesan";
            this.alamatPemesanDataGridViewTextBoxColumn.HeaderText = "AlamatPemesan";
            this.alamatPemesanDataGridViewTextBoxColumn.Name = "alamatPemesanDataGridViewTextBoxColumn";
            // 
            // tanggalPemesananDataGridViewTextBoxColumn
            // 
            this.tanggalPemesananDataGridViewTextBoxColumn.DataPropertyName = "TanggalPemesanan";
            this.tanggalPemesananDataGridViewTextBoxColumn.HeaderText = "TanggalPemesanan";
            this.tanggalPemesananDataGridViewTextBoxColumn.Name = "tanggalPemesananDataGridViewTextBoxColumn";
            // 
            // kuotaOrangDataGridViewTextBoxColumn
            // 
            this.kuotaOrangDataGridViewTextBoxColumn.DataPropertyName = "KuotaOrang";
            this.kuotaOrangDataGridViewTextBoxColumn.HeaderText = "KuotaOrang";
            this.kuotaOrangDataGridViewTextBoxColumn.Name = "kuotaOrangDataGridViewTextBoxColumn";
            // 
            // jumlahHariDataGridViewTextBoxColumn
            // 
            this.jumlahHariDataGridViewTextBoxColumn.DataPropertyName = "JumlahHari";
            this.jumlahHariDataGridViewTextBoxColumn.HeaderText = "JumlahHari";
            this.jumlahHariDataGridViewTextBoxColumn.Name = "jumlahHariDataGridViewTextBoxColumn";
            // 
            // biayaDataGridViewTextBoxColumn
            // 
            this.biayaDataGridViewTextBoxColumn.DataPropertyName = "Biaya";
            this.biayaDataGridViewTextBoxColumn.HeaderText = "Biaya";
            this.biayaDataGridViewTextBoxColumn.Name = "biayaDataGridViewTextBoxColumn";
            // 
            // dalamNegeriBindingSource
            // 
            this.dalamNegeriBindingSource.DataMember = "DalamNegeri";
            this.dalamNegeriBindingSource.DataSource = this.dataTravelDataSet;
            this.dalamNegeriBindingSource.CurrentChanged += new System.EventHandler(this.dalamNegeriBindingSource_CurrentChanged);
            // 
            // dataTravelDataSet
            // 
            this.dataTravelDataSet.DataSetName = "DataTravelDataSet";
            this.dataTravelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label6.Font = new System.Drawing.Font("Goudy Old Style", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(30, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(384, 55);
            this.label6.TabIndex = 28;
            this.label6.Text = "DALAM NEGERI";
            // 
            // dalamNegeriTableAdapter
            // 
            this.dalamNegeriTableAdapter.ClearBeforeFill = true;
            // 
            // dttgl
            // 
            this.dttgl.Location = new System.Drawing.Point(695, 85);
            this.dttgl.Name = "dttgl";
            this.dttgl.Size = new System.Drawing.Size(207, 22);
            this.dttgl.TabIndex = 29;
            this.dttgl.ValueChanged += new System.EventHandler(this.dttgl_ValueChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.YellowGreen;
            this.button1.Font = new System.Drawing.Font("Lucida Fax", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(771, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 29);
            this.button1.TabIndex = 30;
            this.button1.Text = "Kembali";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DalamNegeri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjectAkhir.Properties.Resources._2;
            this.ClientSize = new System.Drawing.Size(931, 498);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dttgl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tbnama);
            this.Controls.Add(this.tbalamat);
            this.Controls.Add(this.tbnotel);
            this.Controls.Add(this.tbkuota);
            this.Controls.Add(this.tbbiaya);
            this.Controls.Add(this.tbjhari);
            this.Controls.Add(this.tbid);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btcari);
            this.Controls.Add(this.tbcari);
            this.Name = "DalamNegeri";
            this.Text = "DALAM NEGERI";
            this.Load += new System.EventHandler(this.DalamNegeri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dalamNegeriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTravelDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbcari;
        private System.Windows.Forms.Button btcari;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbid;
        private System.Windows.Forms.TextBox tbjhari;
        private System.Windows.Forms.TextBox tbbiaya;
        private System.Windows.Forms.TextBox tbkuota;
        private System.Windows.Forms.TextBox tbnotel;
        private System.Windows.Forms.TextBox tbalamat;
        private System.Windows.Forms.TextBox tbnama;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataTravelDataSet dataTravelDataSet;
        private System.Windows.Forms.BindingSource dalamNegeriBindingSource;
        private DataTravelDataSetTableAdapters.DalamNegeriTableAdapter dalamNegeriTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPemesanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaPemesanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noTlpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alamatPemesanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggalPemesananDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kuotaOrangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jumlahHariDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn biayaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dttgl;
        private System.Windows.Forms.Button button1;
    }
}