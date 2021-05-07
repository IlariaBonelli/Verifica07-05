using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElencoSpese.Entities
{
    class Vitto : IRimborso
    {
        public decimal GeneraRimborso(decimal money)
        {
            Console.WriteLine("Rimborso per vitto");
            return (decimal)0.70 * money;
        }
    }
}
