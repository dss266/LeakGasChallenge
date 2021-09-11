using LeakGas.Business.Interfaces.Data;
using LeakGas.Business.Models;
using LeakGas.Data.Context;

namespace LeakGas.Data.Repositories
{
    public class CondominioRepository : Repository<Condominio>, ICondominioRepository
    {
        public CondominioRepository(LeakGasContext db) : base(db)
        {
        }
    }
}
