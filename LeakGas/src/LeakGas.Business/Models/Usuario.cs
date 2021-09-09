using System.ComponentModel.DataAnnotations.Schema;

namespace LeakGas.Business.Models
{
    [Table("TB_USUARIO")]
    public class Usuario
    {
        [Column("ID_USUARIO")]
        public int Id { get; set; }
        [Column("FK_NIVEL_DE_ACESSO")]
        public int IdNivelAcesso { get; set; }
        [Column("NM_USUARIO")]

        public string Nome { get; set; }
        [Column("NR_DOCUMENTO")]

        public int NrDocumento { get; set; }
        [Column("NR_TELEFONE")]

        public int Telefone { get; set; }
    }
}
