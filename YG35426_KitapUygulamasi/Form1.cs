using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YG35426_KitapUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void Temizle()
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    TextBox txt = (TextBox)item;
                    txt.Clear();
                }
                else if (item is NumericUpDown)
                {
                    NumericUpDown nu = (NumericUpDown)item;
                    nu.Value = 50;
                }
                else if (item is DateTimePicker)
                {
                    DateTimePicker dt = (DateTimePicker)item;
                    dt.Value = DateTime.Now;
                }
            }
            txtKitapAdi.Focus();
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            Kitap k = new Kitap();
            k.ISBNNo = txtISBNNo.Text;
            k.KitapAdi = txtKitapAdi.Text;
            k.SayfaSayisi = Convert.ToInt32(nuSayfaSayisi.Value);
            k.Tur = txtTuru.Text;
            k.YayinEvi = txtYayinEvi.Text;
            k.YayinTarihi = dtYayinTarihi.Value;
            k.Yazar = txtYazari.Text;
            lstKitaplar.Items.Add(k);
            //lstKitaplar.Items.Add(string.Format("{0} >> {1}", k.KitapAdi, k.Yazar));
            Temizle();
        }
        Kitap seciliKitap;
        private void lstKitaplar_DoubleClick(object sender, EventArgs e)
        {
            seciliKitap = (Kitap)lstKitaplar.SelectedItem;
            txtISBNNo.Text = seciliKitap.ISBNNo;
            txtKitapAdi.Text = seciliKitap.KitapAdi;
            txtTuru.Text = seciliKitap.Tur;
            txtYayinEvi.Text = seciliKitap.YayinEvi;
            txtYazari.Text = seciliKitap.Yazar;
            nuSayfaSayisi.Value = seciliKitap.SayfaSayisi;
            dtYayinTarihi.Value = seciliKitap.YayinTarihi;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            seciliKitap.ISBNNo = txtISBNNo.Text;
            seciliKitap.KitapAdi = txtKitapAdi.Text;
            seciliKitap.SayfaSayisi = Convert.ToInt32(nuSayfaSayisi.Value);
            seciliKitap.Tur = txtTuru.Text;
            seciliKitap.YayinEvi = txtYayinEvi.Text;
            seciliKitap.YayinTarihi = dtYayinTarihi.Value;
            seciliKitap.Yazar = txtYazari.Text;

            int index = lstKitaplar.SelectedIndex;
            lstKitaplar.Items.RemoveAt(index);
            lstKitaplar.Items.Insert(index, seciliKitap);
            Temizle();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lstKitaplar.Items.Remove(lstKitaplar.SelectedItem);
        }
    }
}
