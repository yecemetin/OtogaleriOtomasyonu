using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb; //Access veritabanı kütüphanesi


namespace OtogaleriOtomasyonu
{
    public partial class Form1 : Form
    {
        //Veritabanı bağlantısının kurulması
        OleDbConnection baglantim = new OleDbConnection("Provider = Microsoft.ACE.OleDb.12.0; Data Source=" + Application.StartupPath + "\\otogaleri.accdb");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kayitlariListele(); //method çağırdık.
        }

        private void cb_marka_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_model.Items.Clear();
            string marka = cb_marka.SelectedItem.ToString();
            if (marka == "Toyota")
            {
                string[] model = { "Auris","Yaris","Corolla"};
                cb_model.Items.AddRange(model);
            }
            if (marka == "Honda")
            {
                string[] model = { "Civic", "Accord" };
                cb_model.Items.AddRange(model);
            }
            if (marka == "Opel")
            {
                string[] model = { "Astra", "Meriva", "Corsa" , "Vectra"};
                cb_model.Items.AddRange(model);
            }
            if (marka == "Renault")
            {
                string[] model = { "Clio", "Megan", "Symbol" ,"Captur","Fluence","Kangoo"};
                cb_model.Items.AddRange(model);
            }
            if (marka == "Audi")
            {
                string[] model = { "A6", "A7", "Q5","Q7" };
                cb_model.Items.AddRange(model);
            }
            if (marka == "Mercedes")
            {
                string[] model = { "A180", "Vito", "e200","c180" };
                cb_model.Items.AddRange(model);
            }
            if (marka == "BMW")
            {
                string[] model = { "520", "X5" , "320","i8","m5"};
                cb_model.Items.AddRange(model);
            }
            if (marka == "Fiat")
            {
                string[] model = { "Doblo", "Egea", "Tofaş" };
                cb_model.Items.AddRange(model);
            }
            if (marka == "Ford")
            {
                string[] model = { "Focus", "C-max", "Connect","Mustang","Fiesta" };
                cb_model.Items.AddRange(model);
            }
        }
        //method tanımlıyoruz
        private void kayitlariListele()
        {
            try
            {
                baglantim.Open();
                OleDbDataAdapter listele = new OleDbDataAdapter("Select * from araclar",baglantim);
                DataSet ds = new DataSet();
                listele.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                baglantim.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                baglantim.Close();
            }
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                baglantim.Open();
                OleDbDataAdapter eklekomutu = new OleDbDataAdapter("insert into araclar (ruhsatno,marka,model,yakit_tipi,kasa_tipi,kilometre,fiyat) values('" + txt_ruhsatNo.Text + "', '" + cb_marka.SelectedItem.ToString() + "','" + cb_model.SelectedItem.ToString() + "','" + cb_yakit.SelectedItem.ToString() + "','" + cb_kasa.SelectedItem.ToString() + "', '"+txt_km.Text +"', '"+txt_fiyat.Text+"')", baglantim);
                DataSet ds = new DataSet();
                eklekomutu.Fill(ds);
                baglantim.Close();
                MessageBox.Show("Araç veritabanına eklendi..");
                txt_ruhsatNo.Clear();
                txt_km.Clear();
                txt_fiyat.Clear();
                kayitlariListele();
            }
            catch (Exception ex)
            {
                 MessageBox.Show(ex.Message);
                baglantim.Close();
            }
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            try
            {
                baglantim.Open();
                DataSet ds = new DataSet();
                OleDbDataAdapter silkomutu = new OleDbDataAdapter("delete from araclar where ruhsatNo = '"+txt_ruhsatNo.Text+"'", baglantim);
                silkomutu.Fill(ds);
                baglantim.Close();
                MessageBox.Show("Araç veritabanından silindi..");
                kayitlariListele();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                baglantim.Close();
            }
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            try
            {
                baglantim.Open();
                OleDbDataAdapter guncellekomutu = new OleDbDataAdapter("update araclar set fiyat= '" + txt_fiyat.Text + "' where ruhsatNo='" + txt_ruhsatNo.Text +"' ", baglantim);
                DataSet ds = new DataSet();
                guncellekomutu.Fill(ds);
                baglantim.Close();
                MessageBox.Show("Araç fiyatı güncellendi..");
                kayitlariListele();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                baglantim.Close();
            }
        }

        private void btn_ara_Click(object sender, EventArgs e)
        {
            try
            {
                baglantim.Open();
                OleDbDataAdapter arakomutu = new OleDbDataAdapter("select * from araclar where ruhsatNo = '"+txt_ruhsatNo.Text+"'", baglantim);
                DataSet ds = new DataSet();
                arakomutu.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                baglantim.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                baglantim.Close();
            }
        }
    }
}
