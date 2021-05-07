using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElencoSpese.Entities
{
    class Altro : IRimborso
    {
        public decimal GeneraRimborso(decimal money)
        {
            Console.WriteLine("Rimborso per altro");
            return (decimal)0.1 * money;
        }
    }
}
