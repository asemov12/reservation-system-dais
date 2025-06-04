using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationSystem.Repository.Helpers.User
{
    public class UserUpdate
    {
        public SqlString? Password { get; set; }
        public SqlString? Email { get; set; }
        public SqlString? Name { get; set; }
    }
}
