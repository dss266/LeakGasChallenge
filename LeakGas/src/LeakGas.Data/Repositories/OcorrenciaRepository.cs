using LeakGas.Business.Interfaces.Data;
using LeakGas.Business.Models;
using LeakGas.Data.Context;

namespace LeakGas.Data.Repositories
{
    public class OcorrenciaRepository : Repository<Ocorrencia>, IOcorrenciaRepository
    {
        protected OcorrenciaRepository(LeakGasContext db) : base(db)
        {
        }
    }
}
