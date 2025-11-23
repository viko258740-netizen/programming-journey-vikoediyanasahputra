using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KasirBioskop
{
    public partial class Form1 : Form
    {
        // Variabel global untuk menyimpan pilihan
        private string filmDipilih = "";
        private string hariDipilih = "";
        private string jamDipilih = "";
        private string kursiDipilih = "";
        private Button buttonJamAktif = null;

        public Form1()
        {
            InitializeComponent();

            // Memanggil fungsi saat form load
            LoadFilm();             // Mengisi data film ke ComboBox
            LoadHari();             // Mengisi tanggal (hari) seminggu ke depan
            GenerateKursiGroupBox();// Membuat tombol-tombol kursi secara dinamis
            SetDefaultButtonColors();// Mengatur warna awal untuk tombol jam (jika ada)
            AddLayarProyeksi();// Menambahkan Panel dan Label yang merepresentasikan layar bioskop
        }

        // Fungsi pembantu untuk mengatur warna default awal pada tombol jam (opsional)
        private void SetDefaultButtonColors()
        {
            // Perulangan untuk mencari semua kontrol di form yang merupakan Button dan memiliki nama diawali "buttonJam"
            foreach (Control c in this.Controls)
            {
                if (c is Button && c.Name.StartsWith("buttonJam"))
                {
                    c.BackColor = System.Drawing.Color.LightGray; // Mengatur warna abu-abu terang sebagai default
                }
            }
        }

        // ================================================
        // 1. MENGISI COMBOBOX FILM
        // ================================================
        private void LoadFilm()
        {
            // Menambahkan daftar nama-nama film ke dalam ComboBox
            comboBoxFilm.Items.Add("Jumbo ");
            comboBoxFilm.Items.Add("KKN Desa Penari ");
            comboBoxFilm.Items.Add("Laskar Pelangi");
            comboBoxFilm.Items.Add("Pabrik Gula");
            comboBoxFilm.Items.Add("Rumah Untuk Alie");
            comboBoxFilm.SelectedIndex = 0; // Mengatur film pertama sebagai pilihan default
        }

        // ================================================
        // 2. COMBOBOX HARI (REALTIME — MINGGU INI)fc
        // ================================================
        private void LoadHari()
        {
            DateTime today = DateTime.Now; // Mengambil tanggal hari ini

            // Perulangan untuk mengisi ComboBox dengan tanggal hari ini sampai 7 hari ke depan
            for (int i = 0; i < 7; i++)
            {
                DateTime date = today.AddDays(i);
                // Menambahkan tanggal dengan format Hari, Tanggal Bulan Tahun
                comboBoxHari.Items.Add(date.ToString("dddd, dd MMMM yyyy"));
            }

            comboBoxHari.SelectedIndex = 0; // Mengatur hari ini sebagai pilihan default
        }

        // ======================================================
        // 3. MENAMBAHKAN LAYAR PROYEKSI DI ATAS KURSI
        // ======================================================
        private void AddLayarProyeksi()
        {
            // Membuat Panel untuk memperlihatkan layar
            Panel layarPanel = new Panel();
            layarPanel.Name = "layarBioskop";
            layarPanel.Text = ""; //Panel tidak menampilkan teks secara langsung
            layarPanel.Width = groupBoxKursi.Width; // Mengatur lebar Panel layar sama dengan lebar GroupBox kursi
            layarPanel.Height = 30; // Mengatur tinggi layar sekitar 30 piksel

            // Memberikan warna yang kontras pada Panel layar agar terlihat jelas
            layarPanel.BackColor = System.Drawing.Color.Red;

            // Menentukan posisi Panel layar 40 piksel di atas GroupBox Kursi
            layarPanel.Left = groupBoxKursi.Left;
            layarPanel.Top = groupBoxKursi.Top - 40;

            // Membuat Label baru sebagai teks "LAYAR PROYEKSI"
            Label labelLayar = new Label();
            labelLayar.Text = "LAYAR PROYEKSI"; // Agar label bertuliskan "LAYAR PROYEKSI"
            labelLayar.AutoSize = true;
            labelLayar.ForeColor = System.Drawing.Color.White; // Mengatur warna teks menjadi putih

            // Menghitung posisi Label agar berada tepat di tengah Panel Layar
            labelLayar.Left = (layarPanel.Width - labelLayar.Width) / 2;
            labelLayar.Top = (layarPanel.Height - labelLayar.Height) / 2;

            // Menambahkan Label teks ke dalam Panel
            layarPanel.Controls.Add(labelLayar);

            // Menambahkan Panel Layar ke dalam Form1
            this.Controls.Add(layarPanel);
        }

        // ======================================================
        // 4. GENERATE KURSI DALAM GROUPBOX
        // ======================================================
        private void GenerateKursiGroupBox()
        {
            // Mengubah definisi baris dan jumlah kursi per baris
            string[] baris = { "A", "B", "C", "D" }; // Baris kursi tetap A sampai D
            int jumlahPerBaris = 4;                 // Mengubah jumlah kursi untuk setiap baris 

            int x = 15; // Koordinat X (horizontal) awal untuk tombol kursi
            int y = 25; // Koordinat Y (vertikal) awal untuk tombol kursi

            // Loop untuk setiap baris (A, B, C, D)
            foreach (string huruf in baris)
            {
                // Loop untuk setiap nomor kursi (1 sampai 4)
                for (int i = 1; i <= jumlahPerBaris; i++)
                {
                    Button btn = new Button();
                    btn.Text = huruf + i;         // Contoh: A1, A2, A3, A4, B1, dst.
                    btn.Width = 50;               // Mengatur lebar tombol kursi
                    btn.Height = 35;              // Mengatur tinggi tombol kursi
                    btn.Left = x;                 // Mengatur posisi horizontal tombol
                    btn.Top = y;                  // Mengatur posisi vertikal tombol
                    btn.BackColor = System.Drawing.Color.LightGray; // Mengatur warna default kursi

                    // Menghubungkan event klik tombol kursi ke method KursiDipilih
                    btn.Click += KursiDipilih;
                    btn.Click += KursiDipilih;

                    // Menambahkan tombol kursi ke dalam GroupBox
                    groupBoxKursi.Controls.Add(btn);

                    x += 55; // Menggeser posisi X ke kanan untuk tombol kursi berikutnya (50 lebar + 5 jarak)
                }

                y += 40; // Menggeser posisi Y ke bawah untuk baris kursi berikutnya (35 tinggi + 5 jarak)
                x = 15; // Mengatur ulang posisi X ke awal baris baru
            }
        }

        // ======================================================
        // 5. PEMILIHAN KURSI
        // ======================================================
        private void KursiDipilih(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            kursiDipilih = btn.Text;// Menyimpan nama kursi yang dipilih

            // Perulangan untuk mereset warna semua tombol kursi kembali ke default
            foreach (Control c in groupBoxKursi.Controls)
            {
                if (c is Button)
                    c.BackColor = System.Drawing.Color.LightGray;
            }
            // Memberikan warna penanda (hijau terang) pada tombol kursi yang baru dipilih
            btn.BackColor = System.Drawing.Color.LightGreen;
        }

        // ======================================================
        // FUNGSI PEMBANTU UNTUK SET JAM TAYANG 
        // ======================================================
        private void SetJamDipilih(string jam, Button currentButton)
        {
            // Reset warna tombol jam sebelumnya
            if (buttonJamAktif != null)
            {
                // Mengembalikan warna tombol jam sebelumnya ke warna default
                buttonJamAktif.BackColor = System.Drawing.Color.LightGray;
            }

            // Menyimpan nilai jam tayang baru dan menandai tombol baru sebagai aktif
            jamDipilih = jam;
            buttonJamAktif = currentButton;
            buttonJamAktif.BackColor = System.Drawing.Color.LightBlue; // Memberikan warna penanda (biru terang) untuk jam yang dipilih
        }

        // ======================================================
        // 6. PEMILIHAN JAM
        // ======================================================
        private void buttonJam1_Click(object sender, EventArgs e)
        {
            // Memanggil fungsi pembantu untuk mengatur jam tayang "10.00 AM"
            SetJamDipilih("10.00 AM", (Button)sender);
        }

        private void buttonJam2_Click(object sender, EventArgs e)
        {
            // Memanggil fungsi pembantu untuk mengatur jam tayang "1.30 PM"
            SetJamDipilih("1.30 PM", (Button)sender);
        }

        private void buttonJam3_Click(object sender, EventArgs e)
        {
            // Memanggil fungsi pembantu untuk mengatur jam tayang "5.00 PM"
            SetJamDipilih("5.00 PM", (Button)sender);
        }

        private void buttonJam4_Click(object sender, EventArgs e)
        {
            // Memanggil fungsi pembantu untuk mengatur jam tayang "8.30 PM"
            SetJamDipilih("8.30 PM", (Button)sender);
        }

        // ======================================================
        // 7. TOMBOL BAYAR
        // ======================================================
        private void buttonBayar_Click(object sender, EventArgs e)
        {
            // Validasi awal: Memeriksa apakah input uang bayar sudah diisi
            if (textBoxBayar.Text.Trim() == "")
            {
                MessageBox.Show("Masukkan jumlah uang bayar terlebih dahulu!");
                return;
            }

            // Blok try-catch untuk menangani potensi kesalahan input format 
            try
            {
                // Validasi input nama pembeli
                if (textBoxNama.Text.Trim() == "")
                {
                    MessageBox.Show("Nama belum diisi!");
                    return;
                }
                // Validasi pilihan film
                if (comboBoxFilm.SelectedIndex == -1)
                {
                    MessageBox.Show("Pilih film terlebih dahulu!");
                    return;
                }
                // Validasi pilihan hari
                if (comboBoxHari.SelectedIndex == -1)
                {
                    MessageBox.Show("Pilih hari terlebih dahulu!");
                    return;
                }
                // Validasi pilihan jam
                if (jamDipilih == "")
                {
                    MessageBox.Show("Pilih jam tayang!");
                    return;
                }
                // Validasi pilihan film
                if (kursiDipilih == "")
                {
                    MessageBox.Show("Pilih kursi terlebih dahulu!");
                    return;
                }

                // Menyimpan pilihan film dan hari dari ComboBox ke variabel global
                filmDipilih = comboBoxFilm.Text;
                hariDipilih = comboBoxHari.Text;

                int harga = 35000;// Menetapkan harga tiket bioskop
                // Mengkonversi teks dari textBoxBayar menjadi integer 
                int bayar = int.Parse(textBoxBayar.Text);
                int kembali = bayar - harga;

                // Validasi apakah uang bayar mencukupi
                if (bayar < harga)
                {
                    MessageBox.Show("Uang bayar kurang! Harus minimal Rp. 35.000");
                    return;
                }

                // ==================================================
                // MEMBUAT DAN MENAMPILKAN STRUK PEMBAYARAN DALAM BENTUK MESSAGEBOX
                // ==================================================
                string struk =
                    "========== STRUK BIOSKOP ==========\n\n" +
                    "Nama        : " + textBoxNama.Text + "\n" +
                    "Film        : " + filmDipilih + "\n" +
                    "Hari        : " + hariDipilih + "\n" +
                    "Jam         : " + jamDipilih + "\n" +
                    "Kursi       : " + kursiDipilih + "\n" +
                    "-----------------------------------\n" +
                    "Harga Tiket : Rp. 35.000\n" +
                    "Uang Bayar  : Rp. " + string.Format("{0:N0}", bayar) + "\n" + // Memformat angka bayar dengan pemisah ribuan
                    "Kembalian   : Rp. " + string.Format("{0:N0}", kembali) + "\n" + // Memformat angka kembalian dengan pemisah ribuan
                    "===================================";

                // Menampilkan struk pembayaran dalam sebuah MessageBox
                MessageBox.Show(struk, "Struk Pembayaran", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Opsi: Panggil fungsi ResetForm() di sini jika diperlukan reset setelah transaksi sukses
                // ResetForm();
            }
            catch (FormatException)
            {
                // Menangani jika input di textBoxBayar bukan merupakan format angka yang valid
                MessageBox.Show("Input uang harus berupa angka!", "Kesalahan Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                // Menangani semua jenis exception tak terduga lainnya
                MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        
    }
}

