using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectAkhir
{
    public partial class LuarNegeri : Form
    {
        public LuarNegeri()
        {
            InitializeComponent();
            refreshform();
        }

        private void LuarNegeri_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataTravelDataSet1.LuarNegeri' table. You can move, or remove it, as needed.
            this.luarNegeriTableAdapter.Fill(this.dataTravelDataSet1.LuarNegeri);
            // TODO: This line of code loads data into the 'dataTravelDataSet.DalamNegeri' table. You can move, or remove it, as needed.
            //this.dalamNegeriTableAdapter.Fill(this.dataTravelDataSet.DalamNegeri);

            tbid.Enabled = false;
            tbnama.Enabled = false;
            tbnotel.Enabled = false;
            tbalamat.Enabled = false;
            dttgl.Enabled = false;
            tbkuota.Enabled = false;
            tbjhari.Enabled = false;
            tbpas.Enabled = false;
            tbbiaya.Enabled = false;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            tbid.Enabled = true;
            tbnama.Enabled = true;
            tbnotel.Enabled = true;
            tbalamat.Enabled = true;
            dttgl.Enabled = true;
            tbkuota.Enabled = true;
            tbjhari.Enabled = true;
            tbpas.Enabled = true;
            tbbiaya.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string str = "";
            string id = tbid.Text.ToString();
            string nmpemesan = tbnama.Text.ToString();
            string notel = tbnotel.Text.ToString();
            string alamat = tbalamat.Text.ToString();
            string tanggal = dttgl.Value.ToString("dd/MM/yy");
            string kuota = tbkuota.Text.ToString();
            string jhari = tbjhari.Text.ToString();
            string pas = tbpas.Text.ToString();
            string biaya = tbbiaya.Text.ToString();

            string strKoneksi = "Data Source = DESKTOP-2CL7BNE; Initial Catalog=DataTravel; User ID = sa; Password=NaMiRa22.";
            SqlConnection koneksi = new SqlConnection();
            koneksi.ConnectionString = strKoneksi;
            koneksi.Open();

            str = "Insert into LuarNegeri values(@Id, @Np, @ntl, @almt, @tgl, @kuota, @jhari, @pas, @biaya)";
            //if (btSimpan.Text.Equals("Edit")) str = "Update Barang set nama=@Nb, Deskripsi=@des " + "where idBarang=@Id";

            SqlCommand cmd = new SqlCommand(str, koneksi);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(new SqlParameter("Id", id));
            cmd.Parameters.Add(new SqlParameter("Np", nmpemesan));
            cmd.Parameters.Add(new SqlParameter("ntl", notel));
            cmd.Parameters.Add(new SqlParameter("almt", alamat));
            cmd.Parameters.Add(new SqlParameter("tgl", tanggal));
            cmd.Parameters.Add(new SqlParameter("kuota", kuota));
            cmd.Parameters.Add(new SqlParameter("jhari", jhari));
            cmd.Parameters.Add(new SqlParameter("pas", pas));
            cmd.Parameters.Add(new SqlParameter("biaya", biaya));
            cmd.ExecuteNonQuery();

            koneksi.Close();
            this.luarNegeriTableAdapter.Fill(this.dataTravelDataSet1.LuarNegeri);
            dataGridView1.Refresh();
            refreshform();
        }

        private void refreshform()
        {
            tbid.Text = "";
            tbnama.Text = "";
            tbnotel.Text = "";
            tbalamat.Text = "";
            dttgl.Text = "";
            tbkuota.Text = "";
            tbjhari.Text = "";
            tbpas.Text = "";
            tbbiaya.Text = "";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string str = "";
            string id = tbid.Text.ToString();
            string nmpemesan = tbnama.Text.ToString();
            string notel = tbnotel.Text.ToString();
            string alamat = tbalamat.Text.ToString();
            string tanggal = dttgl.Value.ToString("dd/MM/yy");
            string kuota = tbkuota.Text.ToString();
            string jhari = tbjhari.Text.ToString();
            string pas = tbpas.Text.ToString();
            string biaya = tbbiaya.Text.ToString();

            string strKoneksi = "Data Source = DESKTOP-2CL7BNE; Initial Catalog=DataTravel; User ID = sa; Password=NaMiRa22.";
            SqlConnection koneksi = new SqlConnection();
            koneksi.ConnectionString = strKoneksi;
            koneksi.Open();

            //str = "Insert into DalamNegeri values(@Id, @Np, @ntl, @almt, @tgl, @kuota, @jhari, @biaya)";
            str = "Update LuarNegeri set NamaPemesan=@Np, NoTlp=@ntl, AlamatPemesan=@almt, TanggalPemesanan=@tgl, KuotaOrang=@kuota, JumlahHari=@jhari, Paspor=@pas, Biaya=@biaya " + "where idPemesan=@Id";

            SqlCommand cmd = new SqlCommand(str, koneksi);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(new SqlParameter("Id", id));
            cmd.Parameters.Add(new SqlParameter("Np", nmpemesan));
            cmd.Parameters.Add(new SqlParameter("ntl", notel));
            cmd.Parameters.Add(new SqlParameter("almt", alamat));
            cmd.Parameters.Add(new SqlParameter("tgl", tanggal));
            cmd.Parameters.Add(new SqlParameter("kuota", kuota));
            cmd.Parameters.Add(new SqlParameter("jhari", jhari));
            cmd.Parameters.Add(new SqlParameter("pas", pas));
            cmd.Parameters.Add(new SqlParameter("biaya", biaya));
            cmd.ExecuteNonQuery();

            koneksi.Close();
            this.luarNegeriTableAdapter.Fill(this.dataTravelDataSet1.LuarNegeri);
            dataGridView1.Refresh();
            refreshform();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string strKoneksi = "Data Source = DESKTOP-2CL7BNE; Initial Catalog=DataTravel; User ID = sa; Password=NaMiRa22.";
            SqlConnection koneksi = new SqlConnection();
            koneksi.ConnectionString = strKoneksi;
            koneksi.Open();
            SqlCommand cmd = koneksi.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from LuarNegeri where NamaPemesan='" + tbnama.Text + "'";
            cmd.ExecuteNonQuery();
            koneksi.Close();

            this.luarNegeriTableAdapter.Fill(this.dataTravelDataSet1.LuarNegeri);
            dataGridView1.Refresh();
            refreshform();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            refreshform();
        }

       

        private void btcari_Click(object sender, EventArgs e)
        {

            try
            {
                this.luarNegeriTableAdapter.FillBy(this.dataTravelDataSet1.LuarNegeri, tbcari.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            string id = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            string np = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[1].Value);
            string nt = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[2].Value);
            string ap = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[3].Value);
            string tp = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[4].Value);
            string ko = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[5].Value);
            string jh = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[6].Value);
            string ps = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[7].Value);
            string b = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[8].Value);

            tbid.Text = id;
            tbnama.Text = np;
            tbnotel.Text = nt;
            tbalamat.Text = ap;
            dttgl.CustomFormat = tp;
            tbkuota.Text = ko;
            tbjhari.Text = jh;
            tbpas.Text = jh;
            tbbiaya.Text = b;

            tbid.Enabled = false;
            tbnama.Enabled = true;
            tbnotel.Enabled = true;
            tbalamat.Enabled = true;
            dttgl.Enabled = true;
            tbkuota.Enabled = true;
            tbjhari.Enabled = true;
            tbpas.Enabled = true;
            tbbiaya.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            home hm = new home();
            hm.Tag = this;
            hm.Show(this);
            Hide();
        }

        private void tbid_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsNumber(e.KeyChar) || e.KeyChar == 8 ?
                false : true;

            Char chr = e.KeyChar;
            if (tbid.Text.Length >= 15)
            {
                if (e.KeyChar != (char)8 && e.KeyChar != 13 && e.KeyChar != 32)
                {
                    MessageBox.Show("Tidak boleh lebih dari 15 karakter");
                    e.KeyChar = (char)0;
                }
            }
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Masukan ANGKA Saja");
            }
            if (e.KeyChar == 13)
            {
                tbnama.Select();
            }
        }

        private void dttgl_ValueChanged(object sender, EventArgs e)
        {
            dttgl.CustomFormat = "dd/MM/yyyy";
        }
    }
}
