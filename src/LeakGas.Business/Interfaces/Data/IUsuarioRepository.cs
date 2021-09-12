using LeakGas.Business.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LeakGas.Business.Interfaces.Data
{
    public interface IUsuarioRepository : IRepository<Usuario>
    {
        Task<IEnumerable<Usuario>> BuscarCondominioPorUsuario(int idUsuario);
        Task<IEnumerable<ViewUsuario>> BuscarViewPorCondominio(int idCondominio);

        Task CadastroProcedure(string nome, int cpf, int telefone, string login, string senha, int nivelAcesso);
    }
}
