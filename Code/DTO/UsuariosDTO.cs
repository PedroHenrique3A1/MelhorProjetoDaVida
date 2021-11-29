namespace MelhorProjetoDaVida.Code.DTO
{
    class UsuariosDTO
    {
        private int id;
        private int numero;
        private string nome;
        private string telefone;
        private string rua;
        private string bairro;
        private string cidade;
        private string estado;
        private string cpf;
        private string rg;
        private string data_nascimento;
        private string pais;
        private string email;
        private string senha;

        public int Id { get => id; set => id = value; }
        public int Numero { get => numero; set => numero = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Rua { get => rua; set => rua = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Rg { get => rg; set => rg = value; }
        public string Data_nascimento { get => data_nascimento; set => data_nascimento = value; }
        public string Pais { get => pais; set => pais = value; }
        public string Email { get => email; set => email = value; }
        public string Senha { get => senha; set => senha = value; }
    }
}
