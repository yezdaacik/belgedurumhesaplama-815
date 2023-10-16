using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Belge_Ortalaması_815
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBelgehesapla_Click(object sender, EventArgs e)
        {
            double notOrtalama, devamsizlikSayisi;
            int zayifSayi;

            notOrtalama = Convert.ToDouble(txtNot.Text);
            devamsizlikSayisi = Convert.ToDouble(txtDevamsizlik.Text);
            zayifSayi = Convert.ToInt32(txtZayif.Text);

            if (notOrtalama >= 70 && notOrtalama < 85 && devamsizlikSayisi < 5 && zayifSayi == 0)
            {
                lblDurum.Text = "Teşekkür belgesi alacaksınız.";
            }
            else if (notOrtalama >=85 && notOrtalama<100 && devamsizlikSayisi < 5 && zayifSayi == 0)
            {
                lblDurum.Text = "Takdir belgesi alacaksınız.";
            }
            else if (devamsizlikSayisi > 5)
            {
                lblDurum.Text = "Devamsızlık sayısı fazla";
            }
            else if (zayifSayi != 0)
            {
                lblDurum.Text = "Zayıf sayısı fazla";
            }
        }
    }
}
