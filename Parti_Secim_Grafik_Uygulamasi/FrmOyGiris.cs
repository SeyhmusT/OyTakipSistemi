using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Parti_Secim_Grafik_Uygulamasi
{

    public partial class FrmOyGiris : Form
    {
        public FrmOyGiris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-M1VVV8I\SQLEXPRESS;Initial Catalog=DbSecimProje;Integrated Security=True;");


        private void btnOyGirisi_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLILCE (ILCEAD,APARTI,BPARTI,CPARTI,DPARTI" +
                ",EPARTI) VALUES (@P1,@P2,@P3,@P4,@P5,@P6)",baglanti);
            komut.Parameters.AddWithValue("@P1", txtIlceAd.Text);
            komut.Parameters.AddWithValue("@P2", txtAParti.Text);
            komut.Parameters.AddWithValue("@P3", txtBParti.Text);
            komut.Parameters.AddWithValue("@P4", txtCParti.Text);
            komut.Parameters.AddWithValue("@P5", txtDParti.Text);
            komut.Parameters.AddWithValue("@P6", txtEParti.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Oy ve İlçe Girişi Gerçekleşti!");

        }

        private void btnGrafik_Click(object sender, EventArgs e)
        {
            FrmGrafikler fr = new FrmGrafikler();
            fr.Show();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
