namespace Lvv
{
    partial class FrmCadastroPaciente
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            TxtNomePaciente = new TextBox();
            LblCpfPaciente = new Label();
            MaskTxtCPF = new MaskedTextBox();
            MaskTextTelefone = new MaskedTextBox();
            LblTelefone = new Label();
            monthCalendar1 = new MonthCalendar();
            LblDataNasc = new Label();
            LblUF = new Label();
            MaskTextUf = new MaskedTextBox();
            LblCIdade = new Label();
            textBox1 = new TextBox();
            CmbBoxTipoDeVicio = new ComboBox();
            LblTipoDeVicio = new Label();
            BtnLimpar = new Button();
            BtnCancelar = new Button();
            BtnSalvar = new Button();
            LblFamiliar = new Label();
            BtnFamiliar = new Button();
            LblNomeFamiliar = new Label();
            TxtNomeFamiliarPaciente = new TextBox();
            LblBlog = new Label();
            lblEmail = new Label();
            textBox2 = new TextBox();
            LblSenha = new Label();
            textBox3 = new TextBox();
            LblConfirmaSenha = new Label();
            textBox4 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 29);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome :";
            // 
            // TxtNomePaciente
            // 
            TxtNomePaciente.Location = new Point(95, 29);
            TxtNomePaciente.Name = "TxtNomePaciente";
            TxtNomePaciente.Size = new Size(172, 23);
            TxtNomePaciente.TabIndex = 1;
            TxtNomePaciente.TextChanged += TxtNomePaciente_TextChanged;
            // 
            // LblCpfPaciente
            // 
            LblCpfPaciente.AutoSize = true;
            LblCpfPaciente.Location = new Point(31, 63);
            LblCpfPaciente.Name = "LblCpfPaciente";
            LblCpfPaciente.Size = new Size(34, 15);
            LblCpfPaciente.TabIndex = 2;
            LblCpfPaciente.Text = "CPF :";
            // 
            // MaskTxtCPF
            // 
            MaskTxtCPF.Location = new Point(95, 60);
            MaskTxtCPF.Mask = "000,000,000-00";
            MaskTxtCPF.Name = "MaskTxtCPF";
            MaskTxtCPF.RejectInputOnFirstFailure = true;
            MaskTxtCPF.Size = new Size(172, 23);
            MaskTxtCPF.TabIndex = 4;
            MaskTxtCPF.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // MaskTextTelefone
            // 
            MaskTextTelefone.Location = new Point(95, 89);
            MaskTextTelefone.Mask = "(00) 00000-0000";
            MaskTextTelefone.Name = "MaskTextTelefone";
            MaskTextTelefone.RejectInputOnFirstFailure = true;
            MaskTextTelefone.Size = new Size(172, 23);
            MaskTextTelefone.TabIndex = 5;
            MaskTextTelefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // LblTelefone
            // 
            LblTelefone.AutoSize = true;
            LblTelefone.Location = new Point(31, 92);
            LblTelefone.Name = "LblTelefone";
            LblTelefone.Size = new Size(58, 15);
            LblTelefone.TabIndex = 6;
            LblTelefone.Text = "Telefone :";
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(31, 148);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 7;
            // 
            // LblDataNasc
            // 
            LblDataNasc.AutoSize = true;
            LblDataNasc.Location = new Point(31, 124);
            LblDataNasc.Name = "LblDataNasc";
            LblDataNasc.Size = new Size(118, 15);
            LblDataNasc.TabIndex = 8;
            LblDataNasc.Text = "Data de nascimento :";
            // 
            // LblUF
            // 
            LblUF.AutoSize = true;
            LblUF.Location = new Point(31, 327);
            LblUF.Name = "LblUF";
            LblUF.Size = new Size(27, 15);
            LblUF.TabIndex = 9;
            LblUF.Text = "UF :";
            // 
            // MaskTextUf
            // 
            MaskTextUf.Location = new Point(95, 324);
            MaskTextUf.Mask = "LL";
            MaskTextUf.Name = "MaskTextUf";
            MaskTextUf.RejectInputOnFirstFailure = true;
            MaskTextUf.Size = new Size(172, 23);
            MaskTextUf.TabIndex = 10;
            MaskTextUf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // LblCIdade
            // 
            LblCIdade.AutoSize = true;
            LblCIdade.Location = new Point(31, 364);
            LblCIdade.Name = "LblCIdade";
            LblCIdade.Size = new Size(50, 15);
            LblCIdade.TabIndex = 11;
            LblCIdade.Text = "Cidade :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(95, 364);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(172, 23);
            textBox1.TabIndex = 12;
            // 
            // CmbBoxTipoDeVicio
            // 
            CmbBoxTipoDeVicio.FormattingEnabled = true;
            CmbBoxTipoDeVicio.Items.AddRange(new object[] { "Álcool", "Pornografia", "Drogas ilícitas", "Jogos de azar", "Internet/Rede Sociais", "Medicamentos" });
            CmbBoxTipoDeVicio.Location = new Point(591, 26);
            CmbBoxTipoDeVicio.Name = "CmbBoxTipoDeVicio";
            CmbBoxTipoDeVicio.Size = new Size(121, 23);
            CmbBoxTipoDeVicio.TabIndex = 13;
            // 
            // LblTipoDeVicio
            // 
            LblTipoDeVicio.AutoSize = true;
            LblTipoDeVicio.Location = new Point(504, 29);
            LblTipoDeVicio.Name = "LblTipoDeVicio";
            LblTipoDeVicio.Size = new Size(81, 15);
            LblTipoDeVicio.TabIndex = 14;
            LblTipoDeVicio.Text = "Tipo de vicio :";
            // 
            // BtnLimpar
            // 
            BtnLimpar.Location = new Point(537, 397);
            BtnLimpar.Name = "BtnLimpar";
            BtnLimpar.Size = new Size(75, 23);
            BtnLimpar.TabIndex = 15;
            BtnLimpar.Text = "Limpar";
            BtnLimpar.UseVisualStyleBackColor = true;
            // 
            // BtnCancelar
            // 
            BtnCancelar.Location = new Point(618, 397);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(75, 23);
            BtnCancelar.TabIndex = 16;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // BtnSalvar
            // 
            BtnSalvar.Location = new Point(699, 397);
            BtnSalvar.Name = "BtnSalvar";
            BtnSalvar.Size = new Size(75, 23);
            BtnSalvar.TabIndex = 17;
            BtnSalvar.Text = "Salvar";
            BtnSalvar.UseVisualStyleBackColor = true;
            // 
            // LblFamiliar
            // 
            LblFamiliar.AutoSize = true;
            LblFamiliar.Location = new Point(504, 89);
            LblFamiliar.Name = "LblFamiliar";
            LblFamiliar.Size = new Size(119, 15);
            LblFamiliar.TabIndex = 18;
            LblFamiliar.Text = "Cadastro de familiar..";
            // 
            // BtnFamiliar
            // 
            BtnFamiliar.Location = new Point(629, 85);
            BtnFamiliar.Name = "BtnFamiliar";
            BtnFamiliar.Size = new Size(75, 23);
            BtnFamiliar.TabIndex = 19;
            BtnFamiliar.Text = "Cadastrar";
            BtnFamiliar.UseVisualStyleBackColor = true;
            BtnFamiliar.Click += BtnFamiliar_Click;
            // 
            // LblNomeFamiliar
            // 
            LblNomeFamiliar.AutoSize = true;
            LblNomeFamiliar.Location = new Point(504, 124);
            LblNomeFamiliar.Name = "LblNomeFamiliar";
            LblNomeFamiliar.Size = new Size(106, 15);
            LblNomeFamiliar.TabIndex = 20;
            LblNomeFamiliar.Text = "Nome do familiar :";
            // 
            // TxtNomeFamiliarPaciente
            // 
            TxtNomeFamiliarPaciente.Location = new Point(616, 121);
            TxtNomeFamiliarPaciente.Name = "TxtNomeFamiliarPaciente";
            TxtNomeFamiliarPaciente.ReadOnly = true;
            TxtNomeFamiliarPaciente.Size = new Size(172, 23);
            TxtNomeFamiliarPaciente.TabIndex = 21;
            // 
            // LblBlog
            // 
            LblBlog.AutoSize = true;
            LblBlog.Location = new Point(504, 188);
            LblBlog.Name = "LblBlog";
            LblBlog.Size = new Size(81, 15);
            LblBlog.TabIndex = 22;
            LblBlog.Text = "Cadastro Blog";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(504, 221);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(42, 15);
            lblEmail.TabIndex = 23;
            lblEmail.Text = "Email :";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(602, 218);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(172, 23);
            textBox2.TabIndex = 24;
            // 
            // LblSenha
            // 
            LblSenha.AutoSize = true;
            LblSenha.Location = new Point(504, 266);
            LblSenha.Name = "LblSenha";
            LblSenha.Size = new Size(45, 15);
            LblSenha.TabIndex = 25;
            LblSenha.Text = "Senha :";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(602, 263);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(172, 23);
            textBox3.TabIndex = 26;
            // 
            // LblConfirmaSenha
            // 
            LblConfirmaSenha.AutoSize = true;
            LblConfirmaSenha.Location = new Point(501, 307);
            LblConfirmaSenha.Name = "LblConfirmaSenha";
            LblConfirmaSenha.Size = new Size(101, 15);
            LblConfirmaSenha.TabIndex = 27;
            LblConfirmaSenha.Text = "Confirmar senha :";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(602, 304);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(172, 23);
            textBox4.TabIndex = 28;
            // 
            // FrmCadastroPaciente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox4);
            Controls.Add(LblConfirmaSenha);
            Controls.Add(textBox3);
            Controls.Add(LblSenha);
            Controls.Add(textBox2);
            Controls.Add(lblEmail);
            Controls.Add(LblBlog);
            Controls.Add(TxtNomeFamiliarPaciente);
            Controls.Add(LblNomeFamiliar);
            Controls.Add(BtnFamiliar);
            Controls.Add(LblFamiliar);
            Controls.Add(BtnSalvar);
            Controls.Add(BtnCancelar);
            Controls.Add(BtnLimpar);
            Controls.Add(LblTipoDeVicio);
            Controls.Add(CmbBoxTipoDeVicio);
            Controls.Add(textBox1);
            Controls.Add(LblCIdade);
            Controls.Add(MaskTextUf);
            Controls.Add(LblUF);
            Controls.Add(LblDataNasc);
            Controls.Add(monthCalendar1);
            Controls.Add(LblTelefone);
            Controls.Add(MaskTextTelefone);
            Controls.Add(MaskTxtCPF);
            Controls.Add(LblCpfPaciente);
            Controls.Add(TxtNomePaciente);
            Controls.Add(label1);
            Name = "FrmCadastroPaciente";
            Text = "FrmCadastroPaciente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TxtNomePaciente;
        private Label LblCpfPaciente;
        private MaskedTextBox MaskTxtCPF;
        private MaskedTextBox MaskTextTelefone;
        private Label LblTelefone;
        private MonthCalendar monthCalendar1;
        private Label LblDataNasc;
        private Label LblUF;
        private MaskedTextBox MaskTextUf;
        private Label LblCIdade;
        private TextBox textBox1;
        private ComboBox CmbBoxTipoDeVicio;
        private Label LblTipoDeVicio;
        private Button BtnLimpar;
        private Button BtnCancelar;
        private Button BtnSalvar;
        private Label LblFamiliar;
        private Button BtnFamiliar;
        private Label LblNomeFamiliar;
        private TextBox TxtNomeFamiliarPaciente;
        private Label LblBlog;
        private Label lblEmail;
        private TextBox textBox2;
        private Label LblSenha;
        private TextBox textBox3;
        private Label LblConfirmaSenha;
        private TextBox textBox4;
    }
}
