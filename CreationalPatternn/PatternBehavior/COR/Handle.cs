using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.CoR
{
    public class Level1SupportHandler : AbstractSupportHandler
    {
        public override object Handle(object request)
        {
            if (request is SupportRequest supportRequest)
            {
                if (supportRequest.Priority == Priority.Low)
                {
                    return $"Level1Support: I'll handle {supportRequest}. Basic troubleshooting provided!";
                }
                else
                {
                    return base.Handle(request);
                }
            }
            return base.Handle(request);
        }
    }

    public class Level2SupportHandler : AbstractSupportHandler
    {
        public override object Handle(object request)
        {
            if (request is SupportRequest supportRequest)
            {
                if (supportRequest.Priority == Priority.Medium)
                {
                    return $"Level2Support: I'll handle {supportRequest}. Technical analysis completed!";
                }
                else
                {
                    return base.Handle(request);
                }
            }
            return base.Handle(request);
        }
    }

    public class Level3SupportHandler : AbstractSupportHandler
    {
        public override object Handle(object request)
        {
            if (request is SupportRequest supportRequest)
            {
                if (supportRequest.Priority == Priority.High)
                {
                    return $"Level3Support: I'll handle {supportRequest}. Advanced technical solution applied!";
                }
                else
                {
                    return base.Handle(request);
                }
            }
            return base.Handle(request);
        }
    }

    public class ManagerHandler : AbstractSupportHandler
    {
        public override object Handle(object request)
        {
            if (request is SupportRequest supportRequest)
            {
                return $"Manager: I'll handle {supportRequest}. Escalated to management level!";
            }
            return "Manager: Request handled at management level!";
        }
    }
}