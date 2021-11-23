namespace MVC_CinemaDiretor
{
    partial class frm_entrar
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.mns_cadastraralterar = new System.Windows.Forms.MenuStrip();
            this.mns_cadastrar = new System.Windows.Forms.ToolStripMenuItem();
            this.mns_alterasenha = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_senha = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.btn_entrar = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.mns_cadastraralterar.SuspendLayout();
            this.SuspendLayout();
            // 
            // mns_cadastraralterar
            // 
            this.mns_cadastraralterar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mns_cadastraralterar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mns_cadastrar,
            this.mns_alterasenha});
            this.mns_cadastraralterar.Location = new System.Drawing.Point(0, 0);
            this.mns_cadastraralterar.Name = "mns_cadastraralterar";
            this.mns_cadastraralterar.Size = new System.Drawing.Size(313, 24);
            this.mns_cadastraralterar.TabIndex = 0;
            this.mns_cadastraralterar.Text = "menuStrip1";
            // 
            // mns_cadastrar
            // 
            this.mns_cadastrar.Name = "mns_cadastrar";
            this.mns_cadastrar.Size = new System.Drawing.Size(86, 20);
            this.mns_cadastrar.Text = "CADASTRAR";
            this.mns_cadastrar.Click += new System.EventHandler(this.mns_cadastrar_Click);
            // 
            // mns_alterasenha
            // 
            this.mns_alterasenha.Name = "mns_alterasenha";
            this.mns_alterasenha.Size = new System.Drawing.Size(117, 20);
            this.mns_alterasenha.Text = "ESQUECEU SENHA";
            this.mns_alterasenha.Click += new System.EventHandler(this.mns_alterasenha_Click);
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(141, 60);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(42, 13);
            this.lbl_email.TabIndex = 1;
            this.lbl_email.Text = "EMAIL:";
            // 
            // lbl_senha
            // 
            this.lbl_senha.AutoSize = true;
            this.lbl_senha.Location = new System.Drawing.Point(139, 142);
            this.lbl_senha.Name = "lbl_senha";
            this.lbl_senha.Size = new System.Drawing.Size(47, 13);
            this.lbl_senha.TabIndex = 2;
            this.lbl_senha.Text = "SENHA:";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(51, 101);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(222, 20);
            this.txt_email.TabIndex = 3;
            // 
            // txt_senha
            // 
            this.txt_senha.Location = new System.Drawing.Point(51, 177);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.Size = new System.Drawing.Size(222, 20);
            this.txt_senha.TabIndex = 4;
            // 
            // btn_entrar
            // 
            this.btn_entrar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_entrar.Location = new System.Drawing.Point(51, 219);
            this.btn_entrar.Name = "btn_entrar";
            this.btn_entrar.Size = new System.Drawing.Size(75, 23);
            this.btn_entrar.TabIndex = 5;
            this.btn_entrar.Text = "ENTRAR";
            this.btn_entrar.UseVisualStyleBackColor = false;
            this.btn_entrar.Click += new System.EventHandler(this.btn_entrar_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_sair.Location = new System.Drawing.Point(198, 219);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(75, 23);
            this.btn_sair.TabIndex = 6;
            this.btn_sair.Text = "SAIR";
            this.btn_sair.UseVisualStyleBackColor = false;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // frm_entrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 277);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_entrar);
            this.Controls.Add(this.txt_senha);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.lbl_senha);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.mns_cadastraralterar);
            this.MainMenuStrip = this.mns_cadastraralterar;
            this.Name = "frm_entrar";
            this.Text = "ENTRAR";
            this.mns_cadastraralterar.ResumeLayout(false);
            this.mns_cadastraralterar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mns_cadastraralterar;
        private System.Windows.Forms.ToolStripMenuItem mns_cadastrar;
        private System.Windows.Forms.ToolStripMenuItem mns_alterasenha;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_senha;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.Button btn_entrar;
        private System.Windows.Forms.Button btn_sair;
    }
}

