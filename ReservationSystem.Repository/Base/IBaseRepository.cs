using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationSystem.Repository.Base
{
    public interface IBaseRepository<TObj, TFilter, TUpdate> 
    {
        Task<int> CreateAsync(TObj entity);
        Task<TObj> RetrieveByIdAsync(int objectId);
        IAsyncEnumerable<TObj> RetrieveCollectionAsync(TFilter filter);
        Task<bool> UpdateByIdAsync(int objectId, TUpdate update);
        Task<bool> DeleteByIdAsync(int objectId);
    }
}
