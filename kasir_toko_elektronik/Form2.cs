using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kasir_toko_elektronik
{
    public partial class FormTransaksi : Form
    {
        public FormTransaksi()
        {
            InitializeComponent();
        }

        private void FormTransaksi_Load(object sender, EventArgs e)
        {
            cbBarang.Items.Add("TV32 - Rp3500000");
            cbBarang.Items.Add("Kulkas 2 Pintu - Rp5000000");
            cbBarang.Items.Add("Mesin Cuci - Rp3000000");
            cbBarang.Items.Add("Speaker Blutut - Rp500000");
            cbBarang.Items.Add("Rice Cookcer - Rp700000");
            cbBarang.Items.Add("Strika listrik - Rp500000");

            cbkecil.Items.Add("Power Bank 5000mAh - Rp150000");
            cbkecil.Items.Add("Mouse Wireless - Rp200000");
            cbkecil.Items.Add("Flashdisk 32GB - Rp120000");
            cbkecil.Items.Add("Headset - Rp250000");
            cbkecil.Items.Add("Webcam - Rp300000");


            numJumlah.Minimum = 1;
            numJumlah.Maximum = 100;
            numJumlah.Value = 1;


            lstvBelanja.View = View.Details;
            lstvBelanja.Columns.Add("Nama Barang", 150);
            lstvBelanja.Columns.Add("Jumlah", 60);
            lstvBelanja.Columns.Add("Harga ", 100);
            lstvBelanja.Columns.Add("Subtotal", 100);

        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (cbBarang.SelectedIndex == -1)
            {
                MessageBox.Show("Pilih barang terlebih dahulu!");
                return;
            }
            // ambil data barang yang dipilih
            string dataBarang = cbBarang.SelectedItem.ToString();
            string dataBarangKecil = cbkecil.SelectedItem != null ? cbkecil.SelectedItem.ToString() : "";

            string[] bagian = dataBarang.Split('-');
            string namaBarang = bagian[0].Trim();
            //int harga = int.Parse(bagian[1].Trim().Replace("Rp", "").Replace(".", ""));
            //int harga = int.Parse(bagian[1].Trim().Replace("Rp", "").Replace(".", ""));
            int jumlah = (int)numJumlah.Value;
            int harga = cbBarang.SelectedIndex switch
            {
                0 => 3500000,
                1 => 5000000,
                2 => 3000000,
                3 => 500000,
                4 => 700000,
                5 => 500000,
                _ => 0
            };
            if (cbkecil.SelectedIndex >= 0)
            {
                string[] bagianKecil = dataBarangKecil.Split('-');
                string namaBarangKecil = bagianKecil[0].Trim();
                int hargaKecil = cbkecil.SelectedIndex switch
                {
                    0 => 150000,
                    1 => 200000,
                    2 => 120000,
                    3 => 250000,
                    4 => 300000,
                    _ => 0
                };
                // tambahkan barang kecil ke listview
                int subtotalKecil = hargaKecil * jumlah;
                // cek apakah barang sudah ada di listview
                bool barangKecilSudahAda = false;
                foreach (ListViewItem item in lstvBelanja.Items)
                {
                    if (item.SubItems[0].Text == namaBarangKecil)
                    {
                        // update jumlah dan subtotal
                        int jumlahLama = int.Parse(item.SubItems[1].Text);
                        int jumlahBaru = jumlahLama + jumlah;
                        item.SubItems[1].Text = jumlahBaru.ToString();
                        int subtotalBaru = hargaKecil * jumlahBaru;
                        item.SubItems[3].Text = subtotalBaru.ToString("N0");
                        barangKecilSudahAda = true;
                        break;
                    }
                }
                if (!barangKecilSudahAda)
                {
                    string[] dataKecil = { namaBarangKecil, jumlah.ToString(), hargaKecil.ToString("N0"), subtotalKecil.ToString("N0") };
                    var itemKecil = new ListViewItem(dataKecil);
                    lstvBelanja.Items.Add(itemKecil);
                }

                //menampilkan total harga di texBok
                lblTotal.Text = (harga * jumlah + hargaKecil * jumlah).ToString("N0");


            }
            int subtotal = harga * jumlah;
            // cek apakah barang sudah ada di listview
            bool barangSudahAda = false;
            foreach (ListViewItem item in lstvBelanja.Items)
            {
                if (item.SubItems[0].Text == namaBarang)
                {
                    // update jumlah dan subtotal
                    int jumlahLama = int.Parse(item.SubItems[1].Text);
                    int jumlahBaru = jumlahLama + jumlah;
                    item.SubItems[1].Text = jumlahBaru.ToString();
                    int subtotalBaru = harga * jumlahBaru;
                    item.SubItems[3].Text = subtotalBaru.ToString("N0");
                    barangSudahAda = true;
                    break;
                }
            }
            if (!barangSudahAda)
            {
                string[] data = { namaBarang, jumlah.ToString(), harga.ToString("N0"), subtotal.ToString("N0") };
                var item = new ListViewItem(data);
                lstvBelanja.Items.Add(item);
            }
        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            //if (lstvBelanja.Items.Count == 0)
            // {
            //    MessageBox.Show("keranjang masih kosong!", "Peringatan",
            //       MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;

            //   }
            //  decimal total = 0;
            //  foreach (ListViewItem item in lstvBelanja.Items)
            //  {
            //     total += (decimal)int.Parse(item.SubItems[3].Text);
            //  }
            //  if (chkPenggunaBaru.Checked)
            // {
            //   total -= total * 0.05m;
            // }
            // txtStruk.Text = "Total Belanja: Rp" + total.ToString("N0");

        }

        private void btnCetak_Click(object sender, EventArgs e)
        {
            if (lstvBelanja.Items.Count == 0)
            {
                MessageBox.Show("keranjang masih kosong, tidak bisa mencetak struk!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            StringBuilder struk = new StringBuilder();
            struk.AppendLine("terima kasih");
            DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            struk.AppendLine("-------------------------------");
            struk.AppendLine("Barang\t\tjumlah\tHarga\tsubtotal");

            foreach (ListViewItem item in lstvBelanja.Items)
            {
                struk.AppendLine($"{item.SubItems[0].Text};\t{item.SubItems[1].Text}\t{item.SubItems[2].Text}\t{item.SubItems[3].Text}");

                struk.AppendLine("-------------------------------");
                struk.AppendLine(txtstruk.Text);
                if (chkPenggunaBaru.Checked)
                {
                    struk.AppendLine("Diskon 5% untuk pengguna baru");
                }
                struk.AppendLine("================================");
                txtstruk.Text = struk.ToString();
            }
        }

        private void btnhitung_Click_1(object sender, EventArgs e)
        {

            {
                // Ambil input dari ComboBox
                string barangbesar = cbBarang.SelectedItem?.ToString() ?? "";
                string barangkecil = cbkecil.SelectedItem?.ToString() ?? "";
                int total = 0;

                // Validasi input
                if (cbBarang.SelectedIndex == -1 && cbkecil.SelectedIndex == -1)
                {
                    MessageBox.Show("Pilih barang terlebih dahulu!");
                    return;
                }
                else if (cbBarang.SelectedIndex != -1)
                {
                    string[] bagianBesar = barangbesar.Split('-');
                    int hargaBesar = cbBarang.SelectedIndex switch
                    {
                        0 => 3500000,
                        1 => 5000000,
                        2 => 3000000,
                        3 => 500000,
                        4 => 700000,
                        5 => 500000,
                        _ => 0
                    };
                    total += hargaBesar * (int)numJumlah.Value;
                }
                else if (cbkecil.SelectedIndex != -1)
                {
                    string[] bagianKecil = barangkecil.Split('-');
                    int hargaKecil = cbkecil.SelectedIndex switch
                    {
                        0 => 150000,
                        1 => 200000,
                        2 => 120000,
                        3 => 250000,
                        4 => 300000,
                        _ => 0
                    };
                    total += hargaKecil * (int)numJumlah.Value;
                }
                total = 0;
                foreach (ListViewItem item in lstvBelanja.Items)
                {
                    int subtotal = int.Parse(item.SubItems[3].Text.Replace(".", "").Replace(",", ""));
                    total += subtotal;
                }
                if (chkPenggunaBaru.Checked)
                {
                    double diskon = total * 0.05;
                    total -= (int)diskon;
                }
                txtstruk.Text = "Rp" + total.ToString("N0");

            }

        }

    
        
    }
}    
            

               
    

