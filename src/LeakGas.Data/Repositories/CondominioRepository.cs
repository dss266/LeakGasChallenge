using LeakGas.Business.Interfaces.Data;
using LeakGas.Business.Models;
using LeakGas.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeakGas.Data.Repositories
{
    public class CondominioRepository : Repository<Condominio>, ICondominioRepository
    {
        public CondominioRepository(LeakGasContext db) : base(db)
        {
        }

        public async Task<IEnumerable<Condominio>> BuscarCondominioPorIdUsuario(int idUsuario)
        {
            return await Db.Condominio.AsNoTracking()
                .Include(c => c.UsuariosCondominios).ToListAsync();
        }
    }
}
