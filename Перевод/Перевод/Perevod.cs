using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Перевод
{
    class Perevod
    {
        private int iz;
        private int v;
        private string chto_perevodit;
        public Perevod()
        {
            iz = 0;
            v = 0;
            chto_perevodit = "";
        }
        public string Per(int iz, int v, string chto_perevodit)
        {
            this.iz = iz;
            this.v = v;
            this.chto_perevodit = chto_perevodit;
            return Convert.ToString(Convert.ToInt32(chto_perevodit, iz), v);
        }
    }
}
