using MelhorProjetoDaVida.Code.DTO;
using MelhorProjetoDaVida.Code.DAL;
using System.Data;

namespace MelhorProjetoDaVida.Code.BLL
{
    class DadosBLL
    {
        AcessoBancoDados banco=new AcessoBancoDados();
        string tabela="tbl_dados";
        public void Inserir(DadosDTO dto)
        {
            string inserir = $"insert into {tabela} values(null,'{dto.Phcfn}','{dto.P08}','{dto.N19}')";
            banco.ExecutarComando(inserir);
        }
        public void Editar(DadosDTO dto)
        {
            string alterar = $"update {tabela} set PHCFN = '{dto.Phcfn}', P08 = '{dto.P08}', N19 = '{dto.N19}' where ID = '{dto.Id}';";
            banco.ExecutarComando(alterar);
        }
        public void Excluir(DadosDTO dto)
        {
            string excluir = $"delete from {tabela} where ID = '{dto.Id}';";
            banco.ExecutarComando(excluir);
        }
        public DataTable Listar()
        {
            string sql = $"select * from {tabela} order by ID;";
            return banco.ExecutarConsulta(sql);
        }
    }
}
