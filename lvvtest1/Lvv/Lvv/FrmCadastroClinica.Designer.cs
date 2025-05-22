namespace Lvv
{
    partial class FrmCadastroClinica
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
            LblNomeClinica = new Label();
            TxtNomeClinica = new TextBox();
            LblCnpj = new Label();
            LblTelefoneClinica = new Label();
            label3 = new Label();
            LblUfClinica = new Label();
            LblCidadeClinica = new Label();
            LblTipoAtendimento = new Label();
            TxtBoxEndereço = new TextBox();
            TxtBoxCidade = new TextBox();
            MaskBoxTelefone = new MaskedTextBox();
            MaskBoxCnpj = new MaskedTextBox();
            MaskBoxUf = new MaskedTextBox();
            CmbBoxTipoDeAtendimento = new ComboBox();
            label1 = new Label();
            BtnSalvar = new Button();
            BtnCancelar = new Button();
            BtnLimpar = new Button();
            SuspendLayout();
            // 
            // LblNomeClinica
            // 
            LblNomeClinica.AutoSize = true;
            LblNomeClinica.Location = new Point(28, 66);
            LblNomeClinica.Name = "LblNomeClinica";
            LblNomeClinica.Size = new Size(85, 15);
            LblNomeClinica.TabIndex = 0;
            LblNomeClinica.Text = "Nome Clinica :";
            // 
            // TxtNomeClinica
            // 
            TxtNomeClinica.Location = new Point(164, 63);
            TxtNomeClinica.Name = "TxtNomeClinica";
            TxtNomeClinica.Size = new Size(180, 23);
            TxtNomeClinica.TabIndex = 1;
            // 
            // LblCnpj
            // 
            LblCnpj.AutoSize = true;
            LblCnpj.Location = new Point(28, 95);
            LblCnpj.Name = "LblCnpj";
            LblCnpj.Size = new Size(79, 15);
            LblCnpj.TabIndex = 2;
            LblCnpj.Text = "CNPJ Clinica :";
            // 
            // LblTelefoneClinica
            // 
            LblTelefoneClinica.AutoSize = true;
            LblTelefoneClinica.Location = new Point(29, 124);
            LblTelefoneClinica.Name = "LblTelefoneClinica";
            LblTelefoneClinica.Size = new Size(97, 15);
            LblTelefoneClinica.TabIndex = 5;
            LblTelefoneClinica.Text = "Telefone Clinica :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 153);
            label3.Name = "label3";
            label3.Size = new Size(115, 15);
            label3.TabIndex = 6;
            label3.Text = "Endereço da clinica :";
            // 
            // LblUfClinica
            // 
            LblUfClinica.AutoSize = true;
            LblUfClinica.Location = new Point(29, 182);
            LblUfClinica.Name = "LblUfClinica";
            LblUfClinica.Size = new Size(78, 15);
            LblUfClinica.TabIndex = 7;
            LblUfClinica.Text = "Uf da clinica :";
            // 
            // LblCidadeClinica
            // 
            LblCidadeClinica.AutoSize = true;
            LblCidadeClinica.Location = new Point(29, 211);
            LblCidadeClinica.Name = "LblCidadeClinica";
            LblCidadeClinica.Size = new Size(103, 15);
            LblCidadeClinica.TabIndex = 8;
            LblCidadeClinica.Text = "Cidade da clinica :";
            // 
            // LblTipoAtendimento
            // 
            LblTipoAtendimento.AutoSize = true;
            LblTipoAtendimento.Location = new Point(28, 249);
            LblTipoAtendimento.Name = "LblTipoAtendimento";
            LblTipoAtendimento.Size = new Size(124, 15);
            LblTipoAtendimento.TabIndex = 9;
            LblTipoAtendimento.Text = "Tipo de atendimento :";
            // 
            // TxtBoxEndereço
            // 
            TxtBoxEndereço.Location = new Point(164, 150);
            TxtBoxEndereço.Name = "TxtBoxEndereço";
            TxtBoxEndereço.Size = new Size(180, 23);
            TxtBoxEndereço.TabIndex = 10;
            // 
            // TxtBoxCidade
            // 
            TxtBoxCidade.Location = new Point(164, 208);
            TxtBoxCidade.Name = "TxtBoxCidade";
            TxtBoxCidade.Size = new Size(180, 23);
            TxtBoxCidade.TabIndex = 11;
            // 
            // MaskBoxTelefone
            // 
            MaskBoxTelefone.Location = new Point(164, 121);
            MaskBoxTelefone.Mask = "(00) 00000-0000";
            MaskBoxTelefone.Name = "MaskBoxTelefone";
            MaskBoxTelefone.RejectInputOnFirstFailure = true;
            MaskBoxTelefone.Size = new Size(180, 23);
            MaskBoxTelefone.TabIndex = 12;
            MaskBoxTelefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // MaskBoxCnpj
            // 
            MaskBoxCnpj.Location = new Point(164, 92);
            MaskBoxCnpj.Mask = "00,000,000/0000-00";
            MaskBoxCnpj.Name = "MaskBoxCnpj";
            MaskBoxCnpj.RejectInputOnFirstFailure = true;
            MaskBoxCnpj.Size = new Size(180, 23);
            MaskBoxCnpj.TabIndex = 13;
            MaskBoxCnpj.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // MaskBoxUf
            // 
            MaskBoxUf.Location = new Point(164, 179);
            MaskBoxUf.Mask = "LL";
            MaskBoxUf.Name = "MaskBoxUf";
            MaskBoxUf.RejectInputOnFirstFailure = true;
            MaskBoxUf.Size = new Size(180, 23);
            MaskBoxUf.TabIndex = 14;
            MaskBoxUf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // CmbBoxTipoDeAtendimento
            // 
            CmbBoxTipoDeAtendimento.FormattingEnabled = true;
            CmbBoxTipoDeAtendimento.Items.AddRange(new object[] { "Álcool", "Pornografia", "Drogas ilícitas", "Jogos de azar", "Internet/Rede Sociais", "Medicamentos", "TODOS" });
            CmbBoxTipoDeAtendimento.Location = new Point(164, 246);
            CmbBoxTipoDeAtendimento.Name = "CmbBoxTipoDeAtendimento";
            CmbBoxTipoDeAtendimento.Size = new Size(180, 23);
            CmbBoxTipoDeAtendimento.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 24);
            label1.Name = "label1";
            label1.Size = new Size(116, 15);
            label1.TabIndex = 16;
            label1.Text = "CADASTRO CLINICA";
            // 
            // BtnSalvar
            // 
            BtnSalvar.Location = new Point(623, 347);
            BtnSalvar.Name = "BtnSalvar";
            BtnSalvar.Size = new Size(75, 23);
            BtnSalvar.TabIndex = 20;
            BtnSalvar.Text = "Salvar";
            BtnSalvar.UseVisualStyleBackColor = true;
            // 
            // BtnCancelar
            // 
            BtnCancelar.Location = new Point(542, 347);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(75, 23);
            BtnCancelar.TabIndex = 19;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // BtnLimpar
            // 
            BtnLimpar.Location = new Point(461, 347);
            BtnLimpar.Name = "BtnLimpar";
            BtnLimpar.Size = new Size(75, 23);
            BtnLimpar.TabIndex = 18;
            BtnLimpar.Text = "Limpar";
            BtnLimpar.UseVisualStyleBackColor = true;
            // 
            // FrmCadastroClinica
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnSalvar);
            Controls.Add(BtnCancelar);
            Controls.Add(BtnLimpar);
            Controls.Add(label1);
            Controls.Add(CmbBoxTipoDeAtendimento);
            Controls.Add(MaskBoxUf);
            Controls.Add(MaskBoxCnpj);
            Controls.Add(MaskBoxTelefone);
            Controls.Add(TxtBoxCidade);
            Controls.Add(TxtBoxEndereço);
            Controls.Add(LblTipoAtendimento);
            Controls.Add(LblCidadeClinica);
            Controls.Add(LblUfClinica);
            Controls.Add(label3);
            Controls.Add(LblTelefoneClinica);
            Controls.Add(LblCnpj);
            Controls.Add(TxtNomeClinica);
            Controls.Add(LblNomeClinica);
            Name = "FrmCadastroClinica";
            Text = "FrmCadastroClinica";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblNomeClinica;
        private TextBox TxtNomeClinica;
        private Label LblCnpj;
        private Label LblTelefoneClinica;
        private Label label3;
        private Label LblUfClinica;
        private Label LblCidadeClinica;
        private Label LblTipoAtendimento;
        private TextBox TxtBoxEndereço;
        private TextBox TxtBoxCidade;
        private MaskedTextBox MaskBoxTelefone;
        private MaskedTextBox MaskBoxCnpj;
        private MaskedTextBox MaskBoxUf;
        private ComboBox CmbBoxTipoDeAtendimento;
        private Label label1;
        private Button BtnSalvar;
        private Button BtnCancelar;
        private Button BtnLimpar;
    }
}