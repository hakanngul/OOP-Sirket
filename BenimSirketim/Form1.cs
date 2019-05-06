using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BenimSirketim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string MuhendisBilgiGoster(Muhendis m)
        {
            string bilgi = "";
            bilgi = "Isim: " + m.Isim + "\nSoyisim: " + m.Soyisim + "\nEmail: " + m.Email + "\nDepartman: " + m.Bolum.Ad;
            return bilgi;
        }

        YazilimSirketi CSoft = new YazilimSirketi();  //Global Tanımlama 
        private void btnEkle_Click(object sender, EventArgs e)
        {
            // txtIsım -> CamelStyle isimlendirme DeveOrgucuStili
            Yazilim YZM = new Yazilim(); // Instance
            IsAnalizi IA = new IsAnalizi();
            Test TST = new Test();
            Araclar VisiualStudio = new Araclar();
            VisiualStudio.Ad = "VS2013";

            Muhendis m;
            if(txtDepartman.Text == "Yazilim")
            {
                m = new Muhendis(YZM) { 
                    Isim = txtIsim.Text,
                    Soyisim = txtSoyIsim.Text,
                    Email = txtMail.Text,
                };
                m.Bolum.Ad = txtDepartman.Text;
                MessageBox.Show(MuhendisBilgiGoster(m));
                MessageBox.Show(YZM.Yazilimci());
                CSoft.MuhendisEkle(m);
            }
            if (txtDepartman.Text == "Is Analizi")
            {
                m = new Muhendis(YZM) // Rezerve Etmek / rezervation/allocation
                {
                    Isim = txtIsim.Text,
                    Soyisim = txtSoyIsim.Text,
                    Email = txtMail.Text,
                };
                m.Bolum.Ad = txtDepartman.Text;
                MessageBox.Show(MuhendisBilgiGoster(m));
                MessageBox.Show(IA.Analizci());
                CSoft.MuhendisEkle(m);
            }
            if (txtDepartman.Text == "Test")
            {
                m = new Muhendis(TST)
                {
                    Isim = txtIsim.Text,
                    Soyisim = txtSoyIsim.Text,
                    Email = txtMail.Text,
                };
                m.Bolum.Ad = txtDepartman.Text;
                MessageBox.Show(MuhendisBilgiGoster(m));
                MessageBox.Show(TST.Testci());
                CSoft.MuhendisEkle(m);
                m.Tool = VisiualStudio; // Aggregation
            }

        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            txtListele.Text = CSoft.MuhendisListele();
        }
    }
}
