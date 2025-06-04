using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationSystem.Repository.Helpers.User
{
    public class UserFilter
    {
        public SqlString? Username { get; set; }
        public SqlString? Email { get; set; }

    }
}
