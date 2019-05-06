using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenimSirketim
{
    public class Muhendis : Kisi
    {
        public Departman Bolum { get; set; } // Tanımlama/Bildirme
        public Muhendis()
        {

        }
        public Muhendis(Departman d) //Constructor Method
        {
            this.Bolum = d; //this referance
        }
        public Araclar Tool { get; set; }
    }
}
