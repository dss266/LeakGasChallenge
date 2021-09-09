using System.ComponentModel.DataAnnotations.Schema;

namespace LeakGas.Business.Models
{
    [Table("TP_TP_OCORRENCIA")]
    public class TipoOcorrencia
    {
        [Column("ID_TP_OCORRENCIA")]
        public int Id { get; set; }
        [Column("DESC_OCORRENCIA")]
        public string Descricao { get; set; }
    }
}
