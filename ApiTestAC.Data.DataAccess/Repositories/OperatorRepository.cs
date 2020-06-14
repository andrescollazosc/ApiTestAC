using ApiTestAC.Domain.Contracts;
using ApiTestAC.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiTestAC.Data.DataAccess.Repositories
{
    public class OperatorRepository : IGenericRepository<Operator>
    {
        #region Attributes
        private readonly db_test_ACC1Context _context;
        private DbSet<Operator> _dbSet;
        #endregion

        #region Constructors
        public OperatorRepository(db_test_ACC1Context context) {
            this._context = context;
            this._dbSet = _context.Set<Operator>();
        }
        #endregion

        #region Public methods
        public async Task<IEnumerable<Operator>> GetAll()
        {
            var result = await _dbSet.ToListAsync();
            return result;
        }
        #endregion
    }
}
