using LeakGas.Business.Interfaces.Data;
using LeakGas.Business.Models;
using LeakGas.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace LeakGas.Data.Repositories
{
    public class UsuarioCondominioRepository : Repository<UsuarioCondominio>, IUsuarioCondominioRepository
    {
        public  UsuarioCondominioRepository(LeakGasContext db) : base(db)
        {
        }

        public async Task<IEnumerable<UsuarioCondominio>> BuscarListaCondominioPorIdUsuario(int idUsuario)
        {
            return await Db.UsuarioCondominio.AsNoTracking()
                .Include(uc => uc.Condominio).Where(uc => uc.IdUsuario == idUsuario).ToListAsync();
        }
    }
}
