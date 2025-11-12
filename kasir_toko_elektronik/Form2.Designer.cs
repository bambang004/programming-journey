namespace kasir_toko_elektronik
{
    partial class FormTransaksi
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
            lblJudul = new Label();
            lblDaftarBarang = new Label();
            lblKeranjang = new Label();
            lstvBelanja = new ListView();
            lblJumlah = new Label();
            btnTambah = new Button();
            chkPenggunaBaru = new CheckBox();
            lblTotal = new Label();
            btnselesai = new Button();
            lblStruk = new Label();
            numJumlah = new NumericUpDown();
            cbBarang = new ComboBox();
            cbkecil = new ComboBox();
            btnhitung = new Button();
            txtstruk = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numJumlah).BeginInit();
            SuspendLayout();
            // 
            // lblJudul
            // 
            lblJudul.AutoSize = true;
            lblJudul.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblJudul.Location = new Point(324, 33);
            lblJudul.Name = "lblJudul";
            lblJudul.Size = new Size(355, 38);
            lblJudul.TabIndex = 0;
            lblJudul.Text = "KASIR TOKO ELEKTRONIK";
            // 
            // lblDaftarBarang
            // 
            lblDaftarBarang.AutoSize = true;
            lblDaftarBarang.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblDaftarBarang.Location = new Point(65, 136);
            lblDaftarBarang.Name = "lblDaftarBarang";
            lblDaftarBarang.Size = new Size(123, 25);
            lblDaftarBarang.TabIndex = 1;
            lblDaftarBarang.Text = "Daftar Barang";
            // 
            // lblKeranjang
            // 
            lblKeranjang.AutoSize = true;
            lblKeranjang.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblKeranjang.Location = new Point(422, 138);
            lblKeranjang.Name = "lblKeranjang";
            lblKeranjang.Size = new Size(155, 25);
            lblKeranjang.TabIndex = 3;
            lblKeranjang.Text = "Keranjang Belanja";
            // 
            // lstvBelanja
            // 
            lstvBelanja.Location = new Point(427, 178);
            lstvBelanja.Name = "lstvBelanja";
            lstvBelanja.Size = new Size(379, 182);
            lstvBelanja.TabIndex = 4;
            lstvBelanja.UseCompatibleStateImageBehavior = false;
            // 
            // lblJumlah
            // 
            lblJumlah.AutoSize = true;
            lblJumlah.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblJumlah.Location = new Point(50, 394);
            lblJumlah.Name = "lblJumlah";
            lblJumlah.Size = new Size(68, 25);
            lblJumlah.TabIndex = 5;
            lblJumlah.Text = "Jumlah";
            // 
            // btnTambah
            // 
            btnTambah.BackColor = Color.FromArgb(1, 255, 111);
            btnTambah.Location = new Point(65, 462);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(112, 34);
            btnTambah.TabIndex = 7;
            btnTambah.Text = "Tambah";
            btnTambah.UseVisualStyleBackColor = false;
            btnTambah.Click += btnTambah_Click;
            // 
            // chkPenggunaBaru
            // 
            chkPenggunaBaru.AutoSize = true;
            chkPenggunaBaru.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            chkPenggunaBaru.Location = new Point(421, 390);
            chkPenggunaBaru.Name = "chkPenggunaBaru";
            chkPenggunaBaru.Size = new Size(262, 29);
            chkPenggunaBaru.TabIndex = 8;
            chkPenggunaBaru.Text = "Pengguna Baru  (Diskon 5%)";
            chkPenggunaBaru.UseVisualStyleBackColor = true;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(427, 513);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(151, 25);
            lblTotal.TabIndex = 9;
            lblTotal.Text = "Total Akhir:    Rp0";
            // 
            // btnselesai
            // 
            btnselesai.BackColor = Color.Orange;
            btnselesai.Location = new Point(583, 447);
            btnselesai.Name = "btnselesai";
            btnselesai.Size = new Size(112, 34);
            btnselesai.TabIndex = 11;
            btnselesai.Text = "Cetak Struk";
            btnselesai.UseVisualStyleBackColor = false;
            btnselesai.Click += btnCetak_Click;
            // 
            // lblStruk
            // 
            lblStruk.AutoSize = true;
            lblStruk.Location = new Point(422, 564);
            lblStruk.Name = "lblStruk";
            lblStruk.Size = new Size(52, 25);
            lblStruk.TabIndex = 12;
            lblStruk.Text = "Struk";
            // 
            // numJumlah
            // 
            numJumlah.Location = new Point(156, 390);
            numJumlah.Name = "numJumlah";
            numJumlah.Size = new Size(180, 31);
            numJumlah.TabIndex = 14;
            // 
            // cbBarang
            // 
            cbBarang.FormattingEnabled = true;
            cbBarang.Location = new Point(65, 194);
            cbBarang.Name = "cbBarang";
            cbBarang.Size = new Size(224, 33);
            cbBarang.TabIndex = 15;
            // 
            // cbkecil
            // 
            cbkecil.FormattingEnabled = true;
            cbkecil.Location = new Point(65, 270);
            cbkecil.Name = "cbkecil";
            cbkecil.Size = new Size(230, 33);
            cbkecil.TabIndex = 16;
            // 
            // btnhitung
            // 
            btnhitung.BackColor = Color.Tomato;
            btnhitung.Location = new Point(428, 447);
            btnhitung.Name = "btnhitung";
            btnhitung.Size = new Size(112, 34);
            btnhitung.TabIndex = 17;
            btnhitung.Text = "Hittung";
            btnhitung.UseVisualStyleBackColor = false;
            btnhitung.Click += btnhitung_Click_1;
            // 
            // txtstruk
            // 
            txtstruk.Location = new Point(512, 564);
            txtstruk.Name = "txtstruk";
            txtstruk.Size = new Size(150, 31);
            txtstruk.TabIndex = 19;
            // 
            // FormTransaksi
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(970, 668);
            Controls.Add(txtstruk);
            Controls.Add(btnhitung);
            Controls.Add(cbkecil);
            Controls.Add(cbBarang);
            Controls.Add(numJumlah);
            Controls.Add(lblStruk);
            Controls.Add(btnselesai);
            Controls.Add(lblTotal);
            Controls.Add(chkPenggunaBaru);
            Controls.Add(btnTambah);
            Controls.Add(lblJumlah);
            Controls.Add(lstvBelanja);
            Controls.Add(lblKeranjang);
            Controls.Add(lblDaftarBarang);
            Controls.Add(lblJudul);
            Name = "FormTransaksi";
            Text = "Transaksi";
            Load += FormTransaksi_Load;
            ((System.ComponentModel.ISupportInitialize)numJumlah).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblJudul;
        private Label lblDaftarBarang;
        private Label lblKeranjang;
        private ListView lstvBelanja;
        private Label lblJumlah;
        private Button btnTambah;
        private CheckBox chkPenggunaBaru;
        private Label lblTotal;
        private Button btnselesai;
        private Label lblStruk;
        private NumericUpDown numJumlah;
        private ComboBox cbBarang;
        private ComboBox cbkecil;
        private Button btnhitung;
        private TextBox txtstruk;
    }
}