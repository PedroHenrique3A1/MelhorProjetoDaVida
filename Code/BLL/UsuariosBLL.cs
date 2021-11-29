using MelhorProjetoDaVida.Code.DTO;
using MelhorProjetoDaVida.Code.DAL;
using System.Data;

namespace MelhorProjetoDaVida.Code.BLL
{
    class UsuariosBLL
    {
        AcessoBancoDados banco = new AcessoBancoDados();
        string tabela = "tbl_usuario";
        public bool RealizarLogin(UsuariosDTO dto)
        {
            string sql = $"select * from {tabela} where CPF = '{dto.Cpf}' and email = '{dto.Email}' and senha = '{dto.Senha}';";
            DataTable dt = banco.ExecutarConsulta(sql);
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Inserir(UsuariosDTO dto)
        {
            string inserir = $"insert into {tabela}(ID,CPF,email,senha) values(null,'{dto.Cpf}','{dto.Email}','{dto.Senha}')";
            banco.ExecutarComando(inserir);
        }
        public void Editar(UsuariosDTO dto)
        {
            string alterar = $"update {tabela} set CPF = '{dto.Cpf}', email = '{dto.Email}', senha = '{dto.Senha}' where id = '{dto.Id}';";
            banco.ExecutarComando(alterar);
        }
        public void Excluir(UsuariosDTO dto)
        {
            string excluir = $"delete from {tabela} where id = '{dto.Id}';";
            banco.ExecutarComando(excluir);
        }
        public DataTable Listar()
        {
            string sql = $"select * from {tabela} order by id;";
            return banco.ExecutarConsulta(sql);
        }
    }
}
