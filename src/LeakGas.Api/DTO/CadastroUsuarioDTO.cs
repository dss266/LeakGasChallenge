namespace LeakGas.Api.DTO
{
    public class CadastroUsuarioDTO
    {
        public string Nome { get; set; }
        public int Cpf { get; set; }
        public int Telefone { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public int NivelAcesso { get; set; }
    }
}
