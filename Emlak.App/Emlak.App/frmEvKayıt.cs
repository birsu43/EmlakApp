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
    public enum Durum
    {
        Insert,
        Update
    }
    public partial class frmEvKayıt : Form
    {
        public float evFiyat;
        public Durum durum = Durum.Insert;
        public frmEvKayıt()
        {
            InitializeComponent();

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                using (var ctx = new EvContext())
                {


                    switch (durum)
                    {
                        case Durum.Insert:
                            var ev = new Ev
                            {
                                Semt = txtSemt.Text,
                                Depozito = float.Parse(txtDEpozit.Text),
                                Fiyat = float.Parse(txtFiyat.Text),
                                OdaSayi = Convert.ToInt32(txtOda.Text),
                                MetreKare = float.Parse(txtMetre.Text),
                                EvId = int.Parse(txtEvId.Text)
                            };
                            durum = Durum.Update;
                            btnKaydet.Text = "Güncelle";
                            ctx.Evler.Add(ev);
                            ctx.SaveChanges();
                            break;
                        case Durum.Update:
                         
                            var ev1 = ctx.Evler.Find();
                            if (ev1 != null)
                            {
                                ev1.Depozito = float.Parse(txtDEpozit.Text);
                                ev1.Fiyat = float.Parse(txtFiyat.Text);
                                ev1.MetreKare=float.Parse(txtMetre.Text);
                                ev1.OdaSayi=Convert.ToInt32(txtOda.Text);
                                ev1.Semt=txtSemt.Text;
                                durum = Durum.Insert;
                                btnKaydet.Text = "Kaydet";
                            }
                            break;
                        default:
                            break;
                    }

                    int sonuc = ctx.SaveChanges();
                    if (sonuc > 0)
                    {
                        MessageBox.Show("Kayıt Başarısız");

                    }
                    else
                    {
                        MessageBox.Show("Kayıt Başarılı");
                    }

                }
            }
            catch (Exception)
            {

                throw;
            }


        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            using (var ctx = new EvContext())
            {


                int a = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Question?", "Title", "Default Text"));
                var sonuc = from o in ctx.Evler where o.Fiyat == a select o;
                Console.WriteLine(a);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
