using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiTestAC.Domain.Contracts
{
    public interface IGenericRepository<T> where T: class
    {
        Task<IEnumerable<T>> GetAll();
    }
}
