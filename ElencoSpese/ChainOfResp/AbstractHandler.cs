using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElencoSpese
{
    public abstract class AbstractHandler : IHandler
    {
        private IHandler _nexthandler;


        public virtual string Handle(double request)
        {
            if (this._nexthandler != null)
            {
                return this._nexthandler.Handle(request);
            }
            else
            {
                return null;
            }

        }

        public IHandler SetNext(IHandler handler)
        {
            this._nexthandler = handler;
            return handler;
        }
    }
}
