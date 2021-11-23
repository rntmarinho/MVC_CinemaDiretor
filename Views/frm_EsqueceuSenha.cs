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
    public partial class frm_EsqueceuSenha : Form
    {
        public frm_EsqueceuSenha()
        {
            InitializeComponent();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
             AlterarSenha objSenha = new AlterarSenha();

            objSenha.email = txt_email.Text;
            objSenha.senha = txt_senhaNova.Text;

            objSenha.Alterar_Senha();
            MessageBox.Show("Senha alterada.");

            txt_email.Clear();
            txt_senhaNova.Clear();
        }
    }
}
