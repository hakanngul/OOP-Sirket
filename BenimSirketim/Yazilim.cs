using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenimSirketim
{
    public class Yazilim : Departman
    {
        public string Yazilimci()
        {
            return base.IsYapma() + "Kod Yazarım.";
        }
    }
}
