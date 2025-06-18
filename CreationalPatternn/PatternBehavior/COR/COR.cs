using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.CoR
{
    public interface ISupportHandler
    {
        ISupportHandler SetNext(ISupportHandler handler);
        object Handle(object request);
    }

    public abstract class AbstractSupportHandler : ISupportHandler
    {
        private ISupportHandler _nextHandler;

        public ISupportHandler SetNext(ISupportHandler handler)
        {
            this._nextHandler = handler;
            return handler;
        }

        public virtual object Handle(object request)
        {
            if (this._nextHandler != null)
            {
                return this._nextHandler.Handle(request);
            }
            else
            {
                return null;
            }
        }
    }
}