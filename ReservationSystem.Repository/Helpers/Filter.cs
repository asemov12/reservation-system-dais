using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationSystem.Repository.Helpers
{
    public class Filter
    {
        public Dictionary<string, object> Conditions { get; set; } = new Dictionary<string, object>();

        public Filter AddCondition(string field, object value)
        {
            Conditions[field] = value;
            return this;
        }
    }
}
