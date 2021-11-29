using System;
using System.Windows.Forms;
using MelhorProjetoDaVida.Code.BLL;
using MelhorProjetoDaVida.Code.DTO;

namespace MelhorProjetoDaVida.Ui
{
    public partial class FrmDados : Form
    {
        DadosBLL dados_bll = new DadosBLL();
        DadosDTO dados_dto = new DadosDTO();
        public FrmDados()
        {
            InitializeComponent();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            dados_dto.Phcfn = txt_phcfn.Text;
            dados_dto.P08 = int.Parse(num_p08.Value.ToString());
            dados_dto.N19 = int.Parse(num_n19.Value.ToString());
            dados_bll.Inserir(dados_dto);
            MessageBox.Show("Cadastrado com sucesso");
            txt_phcfn.Clear();
            num_p08.ResetText();
            num_n19.ResetText();
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            dados_dto.Id = int.Parse(num_id.Value.ToString());
            dados_dto.Phcfn = txt_phcfn.Text;
            dados_dto.P08 = int.Parse(num_p08.Value.ToString());
            dados_dto.N19 = int.Parse(num_n19.Value.ToString());
            dados_bll.Editar(dados_dto);
            MessageBox.Show("Cadastrado com sucesso");
            num_id.ResetText();
            txt_phcfn.Clear();
            num_p08.ResetText();
            num_n19.ResetText();
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            dados_dto.Id = int.Parse(num_id.Value.ToString());
            dados_bll.Excluir(dados_dto);
            MessageBox.Show("Excluido com sucesso");
            num_id.ResetText();
        }

        private void btn_listar_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = dados_bll.Listar();
        }

        private void btn_usuarios_Click(object sender, EventArgs e)
        {
            FrmUsuarios usu = new FrmUsuarios();
            usu.ShowDialog();
        }
    }
}
