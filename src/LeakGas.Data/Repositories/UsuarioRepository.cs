using LeakGas.Business.Interfaces.Data;
using LeakGas.Business.Models;
using LeakGas.Data.Context;
using Microsoft.EntityFrameworkCore;
using Oracle.ManagedDataAccess.Client;
using System.Collections.Generic;
using System.Data;
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

        public async Task CadastroProcedure(string nome, long cpf, long telefone, string login, string senha, int nivelAcesso)
        {
            try
            {
                OracleParameter p1 = new OracleParameter("V_NM_USUARIO", OracleDbType.Varchar2, nome, ParameterDirection.Input);
                OracleParameter p2 = new OracleParameter("V_NR_DOCUMENTO", OracleDbType.Int32, cpf, ParameterDirection.Input);
                OracleParameter p3 = new OracleParameter("V_NR_TELEFONE", OracleDbType.Int32, telefone, ParameterDirection.Input);
                OracleParameter p4 = new OracleParameter("V_LOGIN", OracleDbType.Varchar2, login, ParameterDirection.Input);
                OracleParameter p5 = new OracleParameter("V_SENHA", OracleDbType.Varchar2, senha, ParameterDirection.Input);
                OracleParameter p6 = new OracleParameter("V_ID_NIVEL_DE_ACESSO", OracleDbType.Int32, nivelAcesso, ParameterDirection.Input);


                string sql = "EXECUTE P_INSERT_NOVO_USUARIO(:V_NM_USUARIO,:V_NR_DOCUMENTO,:V_NR_TELEFONE,:V_LOGIN,:V_SENHA,:V_ID_NIVEL_DE_ACESSO);";
                var result = Db.Usuario.FromSqlRaw(sql, p1, p2, p3, p4, p5, p6);
            }
            catch (System.Exception e)
            {

                throw;
            }
        }
    }
}
