using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElencoSpese
{
    public class ManagerHandler: AbstractHandler
    {
        public override string Handle(double request)
        {
            if (request <=400)
            {
                return $"Spesa approvata dal manager";
            }
            else
            {
                return base.Handle(request);
            }


        }
    }
}
