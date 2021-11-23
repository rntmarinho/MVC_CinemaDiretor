namespace MVC_CinemaDiretor
{
    partial class frm_inicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_nomefilme = new System.Windows.Forms.TextBox();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.txt_lancamento = new System.Windows.Forms.TextBox();
            this.txt_duracao = new System.Windows.Forms.TextBox();
            this.txt_sinopse = new System.Windows.Forms.TextBox();
            this.lbl_nomefilme = new System.Windows.Forms.Label();
            this.lbl_codigo = new System.Windows.Forms.Label();
            this.lbl_anolancamento = new System.Windows.Forms.Label();
            this.lbl_duracao = new System.Windows.Forms.Label();
            this.lbl_sinopse = new System.Windows.Forms.Label();
            this.pnl_CRUD = new System.Windows.Forms.Panel();
            this.dgv_filmes = new System.Windows.Forms.DataGridView();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.btn_listar = new System.Windows.Forms.Button();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.pnl_CRUD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_filmes)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_nomefilme
            // 
            this.txt_nomefilme.Location = new System.Drawing.Point(24, 45);
            this.txt_nomefilme.Name = "txt_nomefilme";
            this.txt_nomefilme.Size = new System.Drawing.Size(232, 20);
            this.txt_nomefilme.TabIndex = 0;
            // 
            // txt_codigo
            // 
            this.txt_codigo.Enabled = false;
            this.txt_codigo.Location = new System.Drawing.Point(308, 45);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(100, 20);
            this.txt_codigo.TabIndex = 1;
            // 
            // txt_lancamento
            // 
            this.txt_lancamento.Location = new System.Drawing.Point(24, 113);
            this.txt_lancamento.Name = "txt_lancamento";
            this.txt_lancamento.Size = new System.Drawing.Size(100, 20);
            this.txt_lancamento.TabIndex = 2;
            // 
            // txt_duracao
            // 
            this.txt_duracao.Location = new System.Drawing.Point(308, 113);
            this.txt_duracao.Name = "txt_duracao";
            this.txt_duracao.Size = new System.Drawing.Size(100, 20);
            this.txt_duracao.TabIndex = 3;
            // 
            // txt_sinopse
            // 
            this.txt_sinopse.Location = new System.Drawing.Point(24, 182);
            this.txt_sinopse.Multiline = true;
            this.txt_sinopse.Name = "txt_sinopse";
            this.txt_sinopse.Size = new System.Drawing.Size(384, 58);
            this.txt_sinopse.TabIndex = 4;
            // 
            // lbl_nomefilme
            // 
            this.lbl_nomefilme.AutoSize = true;
            this.lbl_nomefilme.Location = new System.Drawing.Point(21, 18);
            this.lbl_nomefilme.Name = "lbl_nomefilme";
            this.lbl_nomefilme.Size = new System.Drawing.Size(76, 13);
            this.lbl_nomefilme.TabIndex = 5;
            this.lbl_nomefilme.Text = "NOME FILME:";
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.AutoSize = true;
            this.lbl_codigo.Location = new System.Drawing.Point(305, 18);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new System.Drawing.Size(52, 13);
            this.lbl_codigo.TabIndex = 6;
            this.lbl_codigo.Text = "CÓDIGO:";
            // 
            // lbl_anolancamento
            // 
            this.lbl_anolancamento.AutoSize = true;
            this.lbl_anolancamento.Location = new System.Drawing.Point(21, 84);
            this.lbl_anolancamento.Name = "lbl_anolancamento";
            this.lbl_anolancamento.Size = new System.Drawing.Size(84, 13);
            this.lbl_anolancamento.TabIndex = 7;
            this.lbl_anolancamento.Text = "LANÇAMENTO:";
            // 
            // lbl_duracao
            // 
            this.lbl_duracao.AutoSize = true;
            this.lbl_duracao.Location = new System.Drawing.Point(305, 84);
            this.lbl_duracao.Name = "lbl_duracao";
            this.lbl_duracao.Size = new System.Drawing.Size(63, 13);
            this.lbl_duracao.TabIndex = 8;
            this.lbl_duracao.Text = "DURAÇÃO:";
            // 
            // lbl_sinopse
            // 
            this.lbl_sinopse.AutoSize = true;
            this.lbl_sinopse.Location = new System.Drawing.Point(21, 152);
            this.lbl_sinopse.Name = "lbl_sinopse";
            this.lbl_sinopse.Size = new System.Drawing.Size(57, 13);
            this.lbl_sinopse.TabIndex = 9;
            this.lbl_sinopse.Text = "SINOPSE:";
            // 
            // pnl_CRUD
            // 
            this.pnl_CRUD.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnl_CRUD.Controls.Add(this.btn_excluir);
            this.pnl_CRUD.Controls.Add(this.btn_alterar);
            this.pnl_CRUD.Controls.Add(this.btn_listar);
            this.pnl_CRUD.Controls.Add(this.btn_cadastrar);
            this.pnl_CRUD.Location = new System.Drawing.Point(24, 268);
            this.pnl_CRUD.Name = "pnl_CRUD";
            this.pnl_CRUD.Size = new System.Drawing.Size(392, 48);
            this.pnl_CRUD.TabIndex = 10;
            // 
            // dgv_filmes
            // 
            this.dgv_filmes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_filmes.Location = new System.Drawing.Point(441, 18);
            this.dgv_filmes.Name = "dgv_filmes";
            this.dgv_filmes.Size = new System.Drawing.Size(514, 298);
            this.dgv_filmes.TabIndex = 11;
            this.dgv_filmes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_filmes_CellContentClick);
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.Location = new System.Drawing.Point(12, 12);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(75, 23);
            this.btn_cadastrar.TabIndex = 0;
            this.btn_cadastrar.Text = "Cadastrar";
            this.btn_cadastrar.UseVisualStyleBackColor = true;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // btn_listar
            // 
            this.btn_listar.Location = new System.Drawing.Point(107, 12);
            this.btn_listar.Name = "btn_listar";
            this.btn_listar.Size = new System.Drawing.Size(75, 23);
            this.btn_listar.TabIndex = 1;
            this.btn_listar.Text = "Listar";
            this.btn_listar.UseVisualStyleBackColor = true;
            this.btn_listar.Click += new System.EventHandler(this.btn_listar_Click);
            // 
            // btn_alterar
            // 
            this.btn_alterar.Location = new System.Drawing.Point(201, 12);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(75, 23);
            this.btn_alterar.TabIndex = 2;
            this.btn_alterar.Text = "Alterar";
            this.btn_alterar.UseVisualStyleBackColor = true;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.Location = new System.Drawing.Point(309, 12);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(75, 23);
            this.btn_excluir.TabIndex = 3;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // frm_inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 335);
            this.Controls.Add(this.dgv_filmes);
            this.Controls.Add(this.pnl_CRUD);
            this.Controls.Add(this.lbl_sinopse);
            this.Controls.Add(this.lbl_duracao);
            this.Controls.Add(this.lbl_anolancamento);
            this.Controls.Add(this.lbl_codigo);
            this.Controls.Add(this.lbl_nomefilme);
            this.Controls.Add(this.txt_sinopse);
            this.Controls.Add(this.txt_duracao);
            this.Controls.Add(this.txt_lancamento);
            this.Controls.Add(this.txt_codigo);
            this.Controls.Add(this.txt_nomefilme);
            this.Name = "frm_inicio";
            this.Text = "Início";
            this.pnl_CRUD.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_filmes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_nomefilme;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.TextBox txt_lancamento;
        private System.Windows.Forms.TextBox txt_duracao;
        private System.Windows.Forms.TextBox txt_sinopse;
        private System.Windows.Forms.Label lbl_nomefilme;
        private System.Windows.Forms.Label lbl_codigo;
        private System.Windows.Forms.Label lbl_anolancamento;
        private System.Windows.Forms.Label lbl_duracao;
        private System.Windows.Forms.Label lbl_sinopse;
        private System.Windows.Forms.Panel pnl_CRUD;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.Button btn_listar;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.DataGridView dgv_filmes;
    }
}