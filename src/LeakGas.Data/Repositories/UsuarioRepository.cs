using LeakGas.Business.Interfaces.Data;
using LeakGas.Business.Models;
using LeakGas.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeakGas.Data.Repositories
{
    public class UsuarioRepository : Repository<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(LeakGasContext db) : base(db)
        {
        }

        public async Task<IEnumerable<Usuario>> BuscarCondominioPorUsuario(int idUsuario)
        {
            return await Db.Usuario.AsNoTracking().Include(u => u.UsuariosApartamentos).ThenInclude(ua => ua.Apartamento).ThenInclude(a => a.Condominio).Where(u => u.Id == idUsuario).ToListAsync();
        }

        public async Task<IEnumerable<ViewUsuario>> BuscarViewPorCondominio(int idCondominio)
        {
            return await Db.ViewUsuario.AsNoTracking().Where(vu => vu.IdCondominio == idCondominio).ToListAsync();
        }
    }
}
