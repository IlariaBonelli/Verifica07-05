using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElencoSpese.Entities
{
    public interface IRimborso
    {
        public decimal GeneraRimborso(decimal money);
    }
}
