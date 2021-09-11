using LeakGas.Business.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LeakGas.Business.Interfaces.Data
{
    public interface IUsuarioCondominioRepository : IRepository<UsuarioCondominio>
    {
        Task<IEnumerable<UsuarioCondominio>> BuscarListaCondominioPorIdUsuario(int idUsuario);
    }
}
