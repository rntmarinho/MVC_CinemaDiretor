using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVC_CinemaDiretor
{
    public partial class frm_cadastrousuario : Form
    {
        public frm_cadastrousuario()
        {
            InitializeComponent();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            Cadastro_usuario objCadastro = new Cadastro_usuario();

            objCadastro.nome = txt_nome.Text;
            objCadastro.email = txt_email.Text;
            objCadastro.senha = txt_senha.Text;

            objCadastro.CadastarUsuario();
            MessageBox.Show("Usuário Cadastrado");

            txt_nome.Clear();
            txt_email.Clear();
            txt_senha.Clear();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
