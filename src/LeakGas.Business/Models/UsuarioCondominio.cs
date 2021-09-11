using System.ComponentModel.DataAnnotations.Schema;

namespace LeakGas.Business.Models
{
    [Table("TB_USU_CON")]
    public class UsuarioCondominio
    {
        [Column("ID_USU_CON")]
        public int Id { get; set; }
        [Column("FK_ID_USUARIO")]

        public int IdUsuario { get; set; }

        [Column("FK_ID_CONDOMINIO")]

        public int IdCondominio { get; set; }

        public virtual Condominio Condominio { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
