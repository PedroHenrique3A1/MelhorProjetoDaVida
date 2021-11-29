using System;
using System.Windows.Forms;
using MelhorProjetoDaVida.Code.BLL;
using MelhorProjetoDaVida.Code.DTO;

namespace MelhorProjetoDaVida.Ui
{
    public partial class FrmUsuarios : Form
    {
        UsuariosBLL usu_bll = new UsuariosBLL();
        UsuariosDTO usu_dto = new UsuariosDTO();
        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            usu_dto.Cpf = txt_cpf.Text;
            usu_dto.Email = txt_email.Text;
            usu_dto.Senha = txt_senha.Text;
            usu_bll.Inserir(usu_dto);
            MessageBox.Show("Cadastrado com sucesso");
            txt_cpf.Clear();
            txt_email.Clear();
            txt_senha.Clear();
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            usu_dto.Id = int.Parse(num_id.Value.ToString());
            usu_dto.Cpf = txt_cpf.Text;
            usu_dto.Email = txt_email.Text;
            usu_dto.Senha = txt_senha.Text;
            usu_bll.Editar(usu_dto);
            MessageBox.Show("Editado com sucesso");
            num_id.ResetText();
            txt_cpf.Clear();
            txt_email.Clear();
            txt_senha.Clear();
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            usu_dto.Id = int.Parse(num_id.Value.ToString());
            usu_bll.Excluir(usu_dto);
            MessageBox.Show("Excluido com sucesso");
            num_id.ResetText();
        }

        private void btn_listar_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = usu_bll.Listar();
        }

        private void btn_dados_Click(object sender, EventArgs e)
        {
            FrmDados dados = new FrmDados();
            dados.ShowDialog();
        }
    }
}
