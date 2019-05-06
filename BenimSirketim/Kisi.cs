using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenimSirketim
{
    public class Kisi
    {
        public string Isim { get; set; } // Auto-Implemented Property // Smart-Field

        private string soyisim; // Backing Field

        public string Soyisim // Property
        {
            get { return soyisim; }
            set { soyisim = value.ToUpper(); }
        }
        
        public string Email { get; set; }
    }
}
