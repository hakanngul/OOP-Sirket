using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenimSirketim
{
    public class YazilimSirketi
    {
        public List<Muhendis> Muhendisler { get; set; }

        public YazilimSirketi()
        {
            this.Muhendisler = new List<Muhendis>(); // Composition..
        }
        public void MuhendisEkle(Muhendis m)
        {
            Muhendisler.Add(m);
        }
        public void MuhendisCikar(Muhendis m)
        {
            Muhendisler.Remove(m);
        }
        public string MuhendisListele()
        {
            string temp="";
            foreach (Muhendis n in Muhendisler)
            {
                temp += "Adi:" + n.Isim + " " + n.Soyisim + "\tBolum: " + n.Bolum.Ad + Environment.NewLine;
            }
            return temp;
        }
    }
}
