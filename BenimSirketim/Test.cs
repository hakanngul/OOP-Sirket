using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenimSirketim
{
    public class Test : Departman
    {
        public string Testci()
        {
            return base.IsYapma() + "Test Ederim.";
        }
    }
}
