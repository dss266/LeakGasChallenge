using LeakGas.Business.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LeakGas.Business.Interfaces.Data
{
    public interface ICondominioRepository : IRepository<Condominio>
    {
        Task<IEnumerable<Condominio>> BuscarCondominioPorIdUsuario(int idUsuario);
    }
}
