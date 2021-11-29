using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using MelhorProjetoDaVida.Code.BLL;
using MelhorProjetoDaVida.Code.DTO;

namespace MelhorProjetoDaVida
{
    public partial class Form1 : Form
    {
        UsuariosBLL usu_bll = new UsuariosBLL();
        UsuariosDTO usu_dto = new UsuariosDTO();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            usu_dto.Cpf = txt_cpf.Text;
            usu_dto.Email = txt_email.Text;
            usu_dto.Senha = txt_senha.Text;
            if (usu_bll.RealizarLogin(usu_dto) == true)
            {
                Ui.FrmUsuarios usu = new Ui.FrmUsuarios();
                usu.ShowDialog();
            }
            else
            {
                MessageBox.Show("Verifique os dados");
            }
        }
    }
}
