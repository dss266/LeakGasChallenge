using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeakGas.Business.Models
{
    [Keyless]
    [Table("TB_LOGIN")]
    public class Login
    {
        [Column("LOGIN")]
        public string Usuario { get; set; }
        public string Senha { get; set; }
        [Column("FK_ID_USUARIO")]
        public int IdUsuario { get; set; }
    }
}
