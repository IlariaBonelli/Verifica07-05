using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElencoSpese.Entities
{
    public class Viaggio : IRimborso
    {
        public decimal GeneraRimborso(decimal money)
        {
            Console.WriteLine("Rimborso per viaggio");
            return money + (decimal)50.0;
        }
    }
}
