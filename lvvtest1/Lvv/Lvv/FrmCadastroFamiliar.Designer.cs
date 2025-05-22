namespace Lvv
{
    partial class dadd
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
            LblNomeFamiliar = new Label();
            TxtBoxFamiliar = new TextBox();
            comboBox1 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            MaskTextTelefone = new MaskedTextBox();
            txtNomePacienteFamiliar = new TextBox();
            label3 = new Label();
            BtnSalvar = new Button();
            BtnCancelar = new Button();
            BtnLimpar = new Button();
            SuspendLayout();
            // 
            // LblNomeFamiliar
            // 
            LblNomeFamiliar.AutoSize = true;
            LblNomeFamiliar.Location = new Point(34, 64);
            LblNomeFamiliar.Name = "LblNomeFamiliar";
            LblNomeFamiliar.Size = new Size(106, 15);
            LblNomeFamiliar.TabIndex = 0;
            LblNomeFamiliar.Text = "Nome do familiar :";
            LblNomeFamiliar.Click += label1_Click;
            // 
            // TxtBoxFamiliar
            // 
            TxtBoxFamiliar.Location = new Point(146, 61);
            TxtBoxFamiliar.Name = "TxtBoxFamiliar";
            TxtBoxFamiliar.Size = new Size(217, 23);
            TxtBoxFamiliar.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Pai", "Mãe", "Tio", "Tia", "Sobrinho", "Sobrinha", "Filho", "Filha", "Irmão", "Irmã", "Primo", "Prima" });
            comboBox1.Location = new Point(146, 132);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 135);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 3;
            label1.Text = "Parentesco :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 99);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 4;
            label2.Text = "Telefone :";
            // 
            // MaskTextTelefone
            // 
            MaskTextTelefone.Location = new Point(146, 96);
            MaskTextTelefone.Mask = "(00) 00000-0000";
            MaskTextTelefone.Name = "MaskTextTelefone";
            MaskTextTelefone.RejectInputOnFirstFailure = true;
            MaskTextTelefone.Size = new Size(172, 23);
            MaskTextTelefone.TabIndex = 6;
            MaskTextTelefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtNomePacienteFamiliar
            // 
            txtNomePacienteFamiliar.Location = new Point(146, 25);
            txtNomePacienteFamiliar.Name = "txtNomePacienteFamiliar";
            txtNomePacienteFamiliar.ReadOnly = true;
            txtNomePacienteFamiliar.Size = new Size(217, 23);
            txtNomePacienteFamiliar.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 28);
            label3.Name = "label3";
            label3.Size = new Size(111, 15);
            label3.TabIndex = 7;
            label3.Text = "Nome do paciente :";
            // 
            // BtnSalvar
            // 
            BtnSalvar.Location = new Point(232, 233);
            BtnSalvar.Name = "BtnSalvar";
            BtnSalvar.Size = new Size(75, 23);
            BtnSalvar.TabIndex = 18;
            BtnSalvar.Text = "Salvar";
            BtnSalvar.UseVisualStyleBackColor = true;
            BtnSalvar.Click += BtnSalvar_Click;
            // 
            // BtnCancelar
            // 
            BtnCancelar.Location = new Point(70, 233);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(75, 23);
            BtnCancelar.TabIndex = 19;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // BtnLimpar
            // 
            BtnLimpar.Location = new Point(151, 233);
            BtnLimpar.Name = "BtnLimpar";
            BtnLimpar.Size = new Size(75, 23);
            BtnLimpar.TabIndex = 20;
            BtnLimpar.Text = "Limpar";
            BtnLimpar.UseVisualStyleBackColor = true;
            // 
            // dadd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnLimpar);
            Controls.Add(BtnCancelar);
            Controls.Add(BtnSalvar);
            Controls.Add(txtNomePacienteFamiliar);
            Controls.Add(label3);
            Controls.Add(MaskTextTelefone);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(TxtBoxFamiliar);
            Controls.Add(LblNomeFamiliar);
            Name = "dadd";
            Text = "FrmCadastroFamiliar";
            Load += dadd_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblNomeFamiliar;
        private TextBox TxtBoxFamiliar;
        private ComboBox comboBox1;
        private Label label1;
        private Label label2;
        private MaskedTextBox MaskTextTelefone;
        private TextBox txtNomePacienteFamiliar;
        private Label label3;
        private Button BtnSalvar;
        private Button BtnCancelar;
        private Button BtnLimpar;
    }
}