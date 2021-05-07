using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElencoSpese
{
    public class OpManagerHandler: AbstractHandler
    {
        public override string Handle(double request)
        {
            if (request > 400 || request <=1000)
            {
                return $"Spesa approvata dall'op manager";
            }
            else
            {
                return base.Handle(request);
            }


        }
    }
}
