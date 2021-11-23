using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_CinemaDiretor
{
    internal class CRUD_Filmes
    {
        Conexao objConexao = new Conexao();

        public int codigoFilme;
        public string nomeFilme, anoLancamento, duracao, sinopse;
        public string tabela = "tbl_filmes";

        public void CadastarFilme()
        {
            string cadastrar = $@"insert into {tabela} values (null, '{nomeFilme}', '{anoLancamento}',
                                  '{duracao}', '{sinopse}');";

            objConexao.ExecutarComando(cadastrar);
        }

        public void AlterarFilme()
        {
            string alterar = $@"update {tabela} set filme='{nomeFilme}', anoFilme='{anoLancamento}',
                                duracao='{duracao}', sinopse='{sinopse}' where codigo='{codigoFilme}';";

            objConexao.ExecutarComando(alterar);
        }

        public void ExcluirFilme()
        {
            string excluir = $@"delete from {tabela} where codigo='{codigoFilme}';";

            objConexao.ExecutarComando(excluir);
        }

        public DataTable ListarFilme()
        {

            string listar = $"select * from {tabela} order by codigo;";
            return objConexao.ExecutarConsulta(listar);
        }
    }
}
