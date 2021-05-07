using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElencoSpese.Entities
{
    class Alloggio : IRimborso
    {
        public decimal GeneraRimborso(decimal money)
        {
            Console.WriteLine("Rimborso per alloggio");
            return money;
        }
    }
}
