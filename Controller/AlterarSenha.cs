using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_CinemaDiretor
{
    internal class AlterarSenha
    {
        Conexao objConexao = new Conexao();

        public string email, senha;
        public string tabela = "tbl_diretores";

        public void Alterar_Senha()
        {
            string alterar = $@"update {tabela} set senha='{senha}' where email='{email}';";

            objConexao.ExecutarComando(alterar);
        }
    }
}
