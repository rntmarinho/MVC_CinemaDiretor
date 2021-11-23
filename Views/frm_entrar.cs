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
    public partial class frm_entrar : Form
    {
        public frm_entrar()
        {
            InitializeComponent();
        }

        private void mns_cadastrar_Click(object sender, EventArgs e)
        {
            frm_cadastrousuario objCadastro = new frm_cadastrousuario();    
            objCadastro.ShowDialog();   
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {

            frm_inicio objInicio = new frm_inicio();
            objInicio.ShowDialog();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mns_alterasenha_Click(object sender, EventArgs e)
        {
            frm_EsqueceuSenha objSenha = new frm_EsqueceuSenha();
            objSenha.ShowDialog();  
        }
    }
}
