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
    public partial class DalamNegeri : Form
    {
        public DalamNegeri()
        {
            InitializeComponent();
            refreshform();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string strKoneksi = "Data Source = DESKTOP-2CL7BNE; Initial Catalog=DataTravel; User ID = sa; Password=NaMiRa22.";
            SqlConnection koneksi = new SqlConnection();
            koneksi.ConnectionString = strKoneksi;
            koneksi.Open();
            SqlCommand cmd = koneksi.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from DalamNegeri where NamaPemesan='" + tbnama.Text + "'";
            cmd.ExecuteNonQuery();
            koneksi.Close();

            this.dalamNegeriTableAdapter.Fill(this.dataTravelDataSet.DalamNegeri);
            dataGridView1.Refresh();
            refreshform();
        }

        

        private void DalamNegeri_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataTravelDataSet.DalamNegeri' table. You can move, or remove it, as needed.
            this.dalamNegeriTableAdapter.Fill(this.dataTravelDataSet.DalamNegeri);
            tbid.Enabled = false;
            tbnama.Enabled = false;
            tbnotel.Enabled = false;
            tbalamat.Enabled = false;
            dttgl.Enabled = false;
            tbkuota.Enabled = false;
            tbjhari.Enabled = false;
            tbbiaya.Enabled = false;



        }

        private void dalamNegeriBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

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
            tbbiaya.Text = "";

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbnama_TextChanged(object sender, EventArgs e)
        {
            string id = tbid.Text.ToString();
            string strKoneksi = "Data Source=DESKTOP-2CL7BNE; Initial Catalog=DataTravel;User " + "ID=sa;Password=NaMiRa22.";
            SqlConnection koneksi = new SqlConnection();
            koneksi.ConnectionString = strKoneksi;
            koneksi.Open();

            string str = "select*from DalamNegeri where idPemesan=@dd";
            SqlCommand cmd = new SqlCommand(str, koneksi);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(new SqlParameter("@dd", id));

            string hasil = "";
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read()) { hasil = dr["idPemesan"].ToString(); }
            dr.Close();
            koneksi.Close();

            //jika already
           // if (hasil.Equals(id))
          // {
            //    refreshform();
          //      DialogResult dlg = MessageBox.Show("Pemesanan dengan ID ini sudah ada",
           //         "Warning", MessageBoxButtons.OK);
//if (dlg == DialogResult.OK) { }
        //    }
            // else tbdes.Enabled = true;
        }

        private void btsimpan(object sender, EventArgs e)
        {
            string str = "";
            string id = tbid.Text.ToString();
            string nmpemesan = tbnama.Text.ToString();
            string notel = tbnotel.Text.ToString();
            string alamat = tbalamat.Text.ToString();
            string tanggal = dttgl.Value.ToString("dd/MM/yy");
            string kuota = tbkuota.Text.ToString();
            string jhari = tbjhari.Text.ToString();
            string biaya = tbbiaya.Text.ToString();

            string strKoneksi = "Data Source = DESKTOP-2CL7BNE; Initial Catalog=DataTravel; User ID = sa; Password=NaMiRa22.";
            SqlConnection koneksi = new SqlConnection();
            koneksi.ConnectionString = strKoneksi;
            koneksi.Open();

            str = "Insert into DalamNegeri values(@Id, @Np, @ntl, @almt, @tgl, @kuota, @jhari, @biaya)";
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
            cmd.Parameters.Add(new SqlParameter("biaya", biaya));
            cmd.ExecuteNonQuery();

            koneksi.Close();
            this.dalamNegeriTableAdapter.Fill(this.dataTravelDataSet.DalamNegeri);
            dataGridView1.Refresh();
            refreshform();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            refreshform();
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
            string b = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[7].Value);

            tbid.Text = id;
            tbnama.Text = np;
            tbnotel.Text = nt;
            tbalamat.Text = ap;
            dttgl.CustomFormat = tp;
            tbkuota.Text = ko;
            tbjhari.Text = jh;
            tbbiaya.Text = b;

            tbid.Enabled = false;
            tbnama.Enabled = true;
            tbnotel.Enabled = true;
            tbalamat.Enabled = true;
            dttgl.Enabled = true;
            tbkuota.Enabled = true;
            tbjhari.Enabled = true;
            tbbiaya.Enabled = true;

            // btSimpan.Text = "Edit";
            // btSimpan.Enabled = true;
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
            string biaya = tbbiaya.Text.ToString();

            string strKoneksi = "Data Source = DESKTOP-2CL7BNE; Initial Catalog=DataTravel; User ID = sa; Password=NaMiRa22.";
            SqlConnection koneksi = new SqlConnection();
            koneksi.ConnectionString = strKoneksi;
            koneksi.Open();

            //str = "Insert into DalamNegeri values(@Id, @Np, @ntl, @almt, @tgl, @kuota, @jhari, @biaya)";
            str = "Update DalamNegeri set NamaPemesan=@Np, NoTlp=@ntl, AlamatPemesan=@almt, TanggalPemesanan=@tgl, KuotaOrang=@kuota, JumlahHari=@jhari, Biaya=@biaya " + "where idPemesan=@Id";

            SqlCommand cmd = new SqlCommand(str, koneksi);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(new SqlParameter("Id", id));
            cmd.Parameters.Add(new SqlParameter("Np", nmpemesan));
            cmd.Parameters.Add(new SqlParameter("ntl", notel));
            cmd.Parameters.Add(new SqlParameter("almt", alamat));
            cmd.Parameters.Add(new SqlParameter("tgl", tanggal));
            cmd.Parameters.Add(new SqlParameter("kuota", kuota));
            cmd.Parameters.Add(new SqlParameter("jhari", jhari));
            cmd.Parameters.Add(new SqlParameter("biaya", biaya));
            cmd.ExecuteNonQuery();

            koneksi.Close();
            this.dalamNegeriTableAdapter.Fill(this.dataTravelDataSet.DalamNegeri);
            dataGridView1.Refresh();
            refreshform();
        }

       

        private void btcari_Click(object sender, EventArgs e)
        {
            try
            {
                this.dalamNegeriTableAdapter.FillBy(this.dataTravelDataSet.DalamNegeri, tbcari.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
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
            tbbiaya.Enabled = true;
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

        private void button1_Click(object sender, EventArgs e)
        {

            home hm = new home();
            hm.Tag = this;
            hm.Show(this);
            Hide();
        }

        private void dttgl_ValueChanged(object sender, EventArgs e)
        {
            dttgl.CustomFormat = "dd/MM/yyyy";
        }
    }
}
