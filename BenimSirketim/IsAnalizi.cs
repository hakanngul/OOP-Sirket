using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenimSirketim
{
    public class IsAnalizi : Departman //Kalitim
    {
        public string Analizci()
        {
            return base.IsYapma() + "Analiz Yaparım.";
        }
    }
}
