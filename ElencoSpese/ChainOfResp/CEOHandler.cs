using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElencoSpese
{
    public class CEOHandler: AbstractHandler
    {
        public override string Handle(double request)
        {
            if(request > 1000 || request < 2500)
            {
                return $"Spesa approvata dal CEO";
            }
            else
            {
                return base.Handle(request);
            }

            
        }
    }
}
