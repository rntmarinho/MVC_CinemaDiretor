namespace MVC_CinemaDiretor
{
    partial class frm_EsqueceuSenha
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
            this.pnl_alterarsenha = new System.Windows.Forms.Panel();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_novasenha = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_senhaNova = new System.Windows.Forms.TextBox();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.pnl_alterarsenha.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_alterarsenha
            // 
            this.pnl_alterarsenha.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnl_alterarsenha.Controls.Add(this.btn_sair);
            this.pnl_alterarsenha.Controls.Add(this.btn_alterar);
            this.pnl_alterarsenha.Controls.Add(this.txt_senhaNova);
            this.pnl_alterarsenha.Controls.Add(this.txt_email);
            this.pnl_alterarsenha.Controls.Add(this.lbl_novasenha);
            this.pnl_alterarsenha.Controls.Add(this.lbl_email);
            this.pnl_alterarsenha.Location = new System.Drawing.Point(12, 12);
            this.pnl_alterarsenha.Name = "pnl_alterarsenha";
            this.pnl_alterarsenha.Size = new System.Drawing.Size(301, 274);
            this.pnl_alterarsenha.TabIndex = 0;
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(119, 30);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(42, 13);
            this.lbl_email.TabIndex = 0;
            this.lbl_email.Text = "EMAIL:";
            // 
            // lbl_novasenha
            // 
            this.lbl_novasenha.AutoSize = true;
            this.lbl_novasenha.Location = new System.Drawing.Point(100, 123);
            this.lbl_novasenha.Name = "lbl_novasenha";
            this.lbl_novasenha.Size = new System.Drawing.Size(80, 13);
            this.lbl_novasenha.TabIndex = 1;
            this.lbl_novasenha.Text = "NOVA SENHA:";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(45, 73);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(187, 20);
            this.txt_email.TabIndex = 2;
            // 
            // txt_senhaNova
            // 
            this.txt_senhaNova.Location = new System.Drawing.Point(45, 166);
            this.txt_senhaNova.Name = "txt_senhaNova";
            this.txt_senhaNova.Size = new System.Drawing.Size(187, 20);
            this.txt_senhaNova.TabIndex = 3;
            // 
            // btn_alterar
            // 
            this.btn_alterar.Location = new System.Drawing.Point(45, 216);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(75, 23);
            this.btn_alterar.TabIndex = 4;
            this.btn_alterar.Text = "ALTERAR";
            this.btn_alterar.UseVisualStyleBackColor = true;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.Location = new System.Drawing.Point(157, 216);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(75, 23);
            this.btn_sair.TabIndex = 5;
            this.btn_sair.Text = "SAIR";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // frm_EsqueceuSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 304);
            this.Controls.Add(this.pnl_alterarsenha);
            this.Name = "frm_EsqueceuSenha";
            this.Text = "Esqueceu a Senha";
            this.pnl_alterarsenha.ResumeLayout(false);
            this.pnl_alterarsenha.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_alterarsenha;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.TextBox txt_senhaNova;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label lbl_novasenha;
        private System.Windows.Forms.Label lbl_email;
    }
}