using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using MaterialSkin;
using MaterialSkin.Controls;

namespace PersonelEntities
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
        }
        personsEntities per = new personsEntities();

        private void Form1_Load(object sender, EventArgs e)
        {
             
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            person pe = new person();
            pe.Ad = materialTxtAd.Text;
            pe.Soyad = materialTxtSoyad.Text;
            pe.Sehir = materialTxtSehir.Text;
            pe.Maas = Convert.ToInt16(materialTxtMaas.Text);
            pe.Durum = materialTxtDurum.Text;
            pe.yas = materialTxtYas.Text;
            per.person.Add(pe);
            MessageBox.Show("Personel Eklendi");
            per.SaveChanges();
            dataGridView1.DataSource = per.person.ToList();
            materialTxtid.Clear();
            materialTxtAd.Clear();
            materialTxtSoyad.Clear();
            materialTxtSehir.Clear();
            materialTxtMaas.Clear();
            materialTxtDurum.Clear();
            materialTxtYas.Clear();
            
        }

        private void materialButton3_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(materialTxtid.Text);
            person pe = per.person.First(x => x.id == id);
            per.person.Remove(pe);
            per.SaveChanges();
            MessageBox.Show("Personel Silindi");
            dataGridView1.DataSource = per.person.ToList();
        }

        private void materialBtnGuncel_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(materialTxtid.Text);
            person pe = per.person.First(x=> x.id == id);
            pe.Ad = materialTxtAd.Text;
            pe.Soyad = materialTxtSoyad.Text;
            pe.Sehir = materialTxtSehir.Text;
          //  pe.Maas = Convert.ToInt16(materialTxtMaas.Text);
            pe.Durum = materialTxtDurum.Text;
            pe.yas = materialTxtYas.Text;
            per.SaveChanges();
            MessageBox.Show("Personel Güncellendi");
            dataGridView1.DataSource = per.person.ToList();

            materialTxtid.Clear();
            materialTxtAd.Clear();
            materialTxtSoyad.Clear();
            materialTxtSehir.Clear();
            materialTxtMaas.Clear();
            materialTxtDurum.Clear();
            materialTxtYas.Clear();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = per.person.ToList();//Görüntüle Butonu
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.github.com/Merdan.002");
        }
    }
}
