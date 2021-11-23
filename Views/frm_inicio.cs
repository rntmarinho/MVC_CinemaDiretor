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
    public partial class frm_inicio : Form
    {
        public frm_inicio()
        {
            InitializeComponent();
        }
        CRUD_Filmes objFilmes = new CRUD_Filmes();

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            objFilmes.nomeFilme = txt_nomefilme.Text;
            objFilmes.anoLancamento = txt_lancamento.Text;
            objFilmes.duracao = txt_duracao.Text;
            objFilmes.sinopse = txt_sinopse.Text;

            objFilmes.CadastarFilme();
            MessageBox.Show("Cadastrado Realizado");

            txt_nomefilme.Clear();
            txt_lancamento.Clear();
            txt_duracao.Clear();
            txt_sinopse.Clear();

            dgv_filmes.DataSource = objFilmes.ListarFilme();
        }

        private void btn_listar_Click(object sender, EventArgs e)
        {
            dgv_filmes.DataSource = objFilmes.ListarFilme();
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            objFilmes.codigoFilme = int.Parse(txt_codigo.Text);
            objFilmes.nomeFilme = txt_nomefilme.Text;
            objFilmes.anoLancamento = txt_lancamento.Text;
            objFilmes.duracao = txt_duracao.Text;
            objFilmes.sinopse = txt_sinopse.Text;

            objFilmes.AlterarFilme();
            MessageBox.Show("Cadastro Alterado");

            txt_codigo.Clear();
            txt_nomefilme.Clear();
            txt_lancamento.Clear();
            txt_duracao.Clear();
            txt_sinopse.Clear();

            dgv_filmes.DataSource = objFilmes.ListarFilme();
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            objFilmes.codigoFilme = int.Parse(txt_codigo.Text);
            objFilmes.nomeFilme = txt_nomefilme.Text;
            objFilmes.anoLancamento = txt_lancamento.Text;
            objFilmes.duracao = txt_duracao.Text;
            objFilmes.sinopse = txt_sinopse.Text;

            objFilmes.ExcluirFilme();
            MessageBox.Show("Cadastro Excluido");

            txt_codigo.Clear();
            txt_nomefilme.Clear();
            txt_lancamento.Clear();
            txt_duracao.Clear();
            txt_sinopse.Clear();

            dgv_filmes.DataSource = objFilmes.ListarFilme();

        }

        private void dgv_filmes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_codigo.Text = dgv_filmes.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_nomefilme.Text = dgv_filmes.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_lancamento.Text = dgv_filmes.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_duracao.Text = dgv_filmes.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_sinopse.Text = dgv_filmes.Rows[e.RowIndex].Cells[4].Value.ToString();
        }
    }
}
