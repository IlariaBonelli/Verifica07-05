using ElencoSpese.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElencoSpese
{
    class FactorySpese
    {
        public static IRimborso Rimborso(string category)
        {
            IRimborso rimborso = new Altro();

            if (category == "Viaggio")
            {
                rimborso = new Viaggio();
            }
            else if (category== "Vitto")
            {
                rimborso = new Vitto();
            }
            else if (category == "Alloggio")
            {
                rimborso = new Alloggio();
            }
            return rimborso;
        }
    }
}
