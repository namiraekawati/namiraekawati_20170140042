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
using ProjectAkhir.ServiceReference1;

namespace ProjectAkhir
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ServiceReference1.IService1 client = new ServiceReference1.Service1Client();
        private void button1_Click(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-2CL7BNE;Initial Catalog=DataTravel;Integrated Security=True");  
            //SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM admin WHERE username='" + tbuname.Text + "' and password='" + tbpass.Text + "'", con);

            ClassLogin d = new ClassLogin();

            if (this.tbpass.Text == d.Password && this.tbuname.Text == d.UserName)
            {
                home hm = new home();
                hm.Tag = this;
                hm.Show(this);
                Hide();
            }
            else
            {
                MessageBox.Show("Username atau Password salah");
            }

            //if (dt.Rows[0][0].ToString() == "1")
            //{
            //    home hm = new home();
            //    hm.Tag = this;
            //    hm.Show(this);
            //    Hide();
            //}
            //else
            //    MessageBox.Show("Invalid username or password");

            //int count = 0;

            //if (count == 1)
            //{
            //    home hm = new home();
            //    hm.Tag = this;
            //    hm.Show(this);
            //    Hide();
            //}
            //else if (count > 0)
            //{
            //    MessageBox.Show("duplicate username and password");
            //}
            //else
            //{
            //    MessageBox.Show( "username and password note correct");
            //}

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbuname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
