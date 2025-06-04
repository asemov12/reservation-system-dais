using Microsoft.Data.SqlClient;
using ReservationSystem.Models;
using ReservationSystem.Repository.Base;
using ReservationSystem.Repository.Helpers.User;
using ReservationSystem.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationSystem.Repository.Repos
{

    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        private const string idColumnName = "UserId";

        protected override string[] GetColumns()
        {
            return new string[] 
            {
                idColumnName,
                "Name",
                "Email",
                "Username",
                "HashedPassword"
            };

        }

        protected override string GetTableName()
        {
            return "Users";
        }

        protected override User MapEntity(SqlDataReader reader)
        {
            return new User
            {
                UserId = Convert.ToInt32(reader[idColumnName]),
                Name = Convert.ToString(reader["Name"]),
                Email = Convert.ToString(reader["Email"]),
                Username = Convert.ToString(reader["Username"]),
                HashedPassword = Convert.ToString(reader["HashedPassword"])
            };
        }
        public async Task<int> CreateAsync(User entity)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteByIdAsync(int objectId)
        {
            throw new NotImplementedException();
        }

        public async Task<User> RetrieveByIdAsync(int objectId)
        {
            throw new NotImplementedException();
        }

        public async IAsyncEnumerable<User> RetrieveCollectionAsync(UserFilter filter)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> UpdateByIdAsync(int objectId, UserUpdate update)
        {
            throw new NotImplementedException();
        }


    }
}
