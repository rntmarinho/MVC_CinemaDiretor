using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_CinemaDiretor
{
    internal class Cadastro_usuario
    {
        public string nome, email, senha;
        public string tabela = "tbl_diretores";

        Conexao objConexao = new Conexao();

        public void CadastarUsuario()
        {
            string cadastrar = $@"insert into {tabela} values (null, '{nome}', '{email}',
                                  '{senha}');";

            objConexao.ExecutarComando(cadastrar);
        }

    }
}
