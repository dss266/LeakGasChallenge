using LeakGas.Business.Interfaces.Data;
using LeakGas.Business.Models;
using LeakGas.Data.Context;

namespace LeakGas.Data.Repositories
{
    public class UsuarioRepository : Repository<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(LeakGasContext db) : base(db)
        {
        }
    }
}
