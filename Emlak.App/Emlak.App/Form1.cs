using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Emlak.App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            try
            {
                using (var ctx=new EvContext())
                {
                    bool durum = ctx.Adminler.Any(a => a.KullaniciAd == txtKulAd.Text
                    && a.Sifre == txtSifre.Text);
                    if (durum)
                    {
                        MessageBox.Show("Bilgiilerin Elimizde");
                        frmEvKayıt frmEv = new frmEvKayıt();
                        frmEv.Show();
                    }
                    else
                    {
                        MessageBox.Show("Zort");
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
