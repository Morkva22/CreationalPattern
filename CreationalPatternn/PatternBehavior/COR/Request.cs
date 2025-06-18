using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.CoR
{
    public enum Priority
    {
        Low,
        Medium,
        High,
        Critical
    }

    public class SupportRequest
    {
        public string Issue { get; set; }
        public Priority Priority { get; set; }
        public string CustomerName { get; set; }

        public SupportRequest(string issue, Priority priority, string customerName)
        {
            Issue = issue;
            Priority = priority;
            CustomerName = customerName;
        }

        public override string ToString()
        {
            return $"[{Priority}] {Issue} - {CustomerName}";
        }
    }
}