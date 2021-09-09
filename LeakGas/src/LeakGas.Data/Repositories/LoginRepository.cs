using LeakGas.Business.Interfaces.Data;
using LeakGas.Business.Models;
using LeakGas.Data.Context;

namespace LeakGas.Data.Repositories
{
    public class LoginRepository : Repository<Login>, ILoginRepository
    {
        protected LoginRepository(LeakGasContext db) : base(db)
        {
        }
    }
}
