namespace CadastroDePessoas
{
    partial class Form1
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
            this.groupBoxDadosPessoais = new System.Windows.Forms.GroupBox();
            this.radioButtonMasculino = new System.Windows.Forms.RadioButton();
            this.radioButtonFeminino = new System.Windows.Forms.RadioButton();
            this.dateTimeNascimento = new System.Windows.Forms.DateTimePicker();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.labelGenero = new System.Windows.Forms.Label();
            this.labelDataNascimento = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.groupBoxEndereco = new System.Windows.Forms.GroupBox();
            this.textBoxCidade = new System.Windows.Forms.TextBox();
            this.textBoxLogradouro = new System.Windows.Forms.TextBox();
            this.textBoxEstado = new System.Windows.Forms.TextBox();
            this.labelEstado = new System.Windows.Forms.Label();
            this.labelCidade = new System.Windows.Forms.Label();
            this.labelLogradouro = new System.Windows.Forms.Label();
            this.groupBoxDadosCadastrais = new System.Windows.Forms.GroupBox();
            this.richTextBoxObservacao = new System.Windows.Forms.RichTextBox();
            this.labelObservacao = new System.Windows.Forms.Label();
            this.dateTimeCadastro = new System.Windows.Forms.DateTimePicker();
            this.labelDataCadastro = new System.Windows.Forms.Label();
            this.groupBoxCriar = new System.Windows.Forms.GroupBox();
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewPessoa = new System.Windows.Forms.DataGridView();
            this.buttonExibir = new System.Windows.Forms.Button();
            this.groupBoxDadosPessoais.SuspendLayout();
            this.groupBoxEndereco.SuspendLayout();
            this.groupBoxDadosCadastrais.SuspendLayout();
            this.groupBoxCriar.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPessoa)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxDadosPessoais
            // 
            this.groupBoxDadosPessoais.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBoxDadosPessoais.Controls.Add(this.radioButtonMasculino);
            this.groupBoxDadosPessoais.Controls.Add(this.radioButtonFeminino);
            this.groupBoxDadosPessoais.Controls.Add(this.dateTimeNascimento);
            this.groupBoxDadosPessoais.Controls.Add(this.textBoxNome);
            this.groupBoxDadosPessoais.Controls.Add(this.labelGenero);
            this.groupBoxDadosPessoais.Controls.Add(this.labelDataNascimento);
            this.groupBoxDadosPessoais.Controls.Add(this.labelNome);
            this.groupBoxDadosPessoais.Location = new System.Drawing.Point(29, 36);
            this.groupBoxDadosPessoais.Name = "groupBoxDadosPessoais";
            this.groupBoxDadosPessoais.Size = new System.Drawing.Size(366, 117);
            this.groupBoxDadosPessoais.TabIndex = 0;
            this.groupBoxDadosPessoais.TabStop = false;
            this.groupBoxDadosPessoais.Text = "Dados Pessoais";
            // 
            // radioButtonMasculino
            // 
            this.radioButtonMasculino.AutoSize = true;
            this.radioButtonMasculino.Location = new System.Drawing.Point(233, 86);
            this.radioButtonMasculino.Name = "radioButtonMasculino";
            this.radioButtonMasculino.Size = new System.Drawing.Size(73, 17);
            this.radioButtonMasculino.TabIndex = 5;
            this.radioButtonMasculino.TabStop = true;
            this.radioButtonMasculino.Text = "Masculino";
            this.radioButtonMasculino.UseVisualStyleBackColor = true;
            // 
            // radioButtonFeminino
            // 
            this.radioButtonFeminino.AutoSize = true;
            this.radioButtonFeminino.Location = new System.Drawing.Point(145, 86);
            this.radioButtonFeminino.Name = "radioButtonFeminino";
            this.radioButtonFeminino.Size = new System.Drawing.Size(67, 17);
            this.radioButtonFeminino.TabIndex = 4;
            this.radioButtonFeminino.TabStop = true;
            this.radioButtonFeminino.Text = "Feminino";
            this.radioButtonFeminino.UseVisualStyleBackColor = true;
            // 
            // dateTimeNascimento
            // 
            this.dateTimeNascimento.Location = new System.Drawing.Point(119, 55);
            this.dateTimeNascimento.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dateTimeNascimento.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimeNascimento.Name = "dateTimeNascimento";
            this.dateTimeNascimento.Size = new System.Drawing.Size(234, 20);
            this.dateTimeNascimento.TabIndex = 3;
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(118, 24);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(235, 20);
            this.textBoxNome.TabIndex = 1;
            // 
            // labelGenero
            // 
            this.labelGenero.AutoSize = true;
            this.labelGenero.Location = new System.Drawing.Point(67, 86);
            this.labelGenero.Name = "labelGenero";
            this.labelGenero.Size = new System.Drawing.Size(45, 13);
            this.labelGenero.TabIndex = 2;
            this.labelGenero.Text = "Gênero:";
            // 
            // labelDataNascimento
            // 
            this.labelDataNascimento.AutoSize = true;
            this.labelDataNascimento.Location = new System.Drawing.Point(7, 55);
            this.labelDataNascimento.Name = "labelDataNascimento";
            this.labelDataNascimento.Size = new System.Drawing.Size(105, 13);
            this.labelDataNascimento.TabIndex = 1;
            this.labelDataNascimento.Text = "Data de nascimento:";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(74, 27);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(38, 13);
            this.labelNome.TabIndex = 0;
            this.labelNome.Text = "Nome:";
            // 
            // groupBoxEndereco
            // 
            this.groupBoxEndereco.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBoxEndereco.Controls.Add(this.textBoxCidade);
            this.groupBoxEndereco.Controls.Add(this.textBoxLogradouro);
            this.groupBoxEndereco.Controls.Add(this.textBoxEstado);
            this.groupBoxEndereco.Controls.Add(this.labelEstado);
            this.groupBoxEndereco.Controls.Add(this.labelCidade);
            this.groupBoxEndereco.Controls.Add(this.labelLogradouro);
            this.groupBoxEndereco.Location = new System.Drawing.Point(29, 159);
            this.groupBoxEndereco.Name = "groupBoxEndereco";
            this.groupBoxEndereco.Size = new System.Drawing.Size(366, 135);
            this.groupBoxEndereco.TabIndex = 1;
            this.groupBoxEndereco.TabStop = false;
            this.groupBoxEndereco.Text = "Endereço";
            // 
            // textBoxCidade
            // 
            this.textBoxCidade.Location = new System.Drawing.Point(119, 63);
            this.textBoxCidade.Name = "textBoxCidade";
            this.textBoxCidade.Size = new System.Drawing.Size(234, 20);
            this.textBoxCidade.TabIndex = 5;
            // 
            // textBoxLogradouro
            // 
            this.textBoxLogradouro.Location = new System.Drawing.Point(119, 28);
            this.textBoxLogradouro.Name = "textBoxLogradouro";
            this.textBoxLogradouro.Size = new System.Drawing.Size(234, 20);
            this.textBoxLogradouro.TabIndex = 4;
            // 
            // textBoxEstado
            // 
            this.textBoxEstado.Location = new System.Drawing.Point(119, 99);
            this.textBoxEstado.Name = "textBoxEstado";
            this.textBoxEstado.Size = new System.Drawing.Size(234, 20);
            this.textBoxEstado.TabIndex = 3;
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.Location = new System.Drawing.Point(69, 99);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(43, 13);
            this.labelEstado.TabIndex = 2;
            this.labelEstado.Text = "Estado:";
            // 
            // labelCidade
            // 
            this.labelCidade.AutoSize = true;
            this.labelCidade.Location = new System.Drawing.Point(67, 63);
            this.labelCidade.Name = "labelCidade";
            this.labelCidade.Size = new System.Drawing.Size(43, 13);
            this.labelCidade.TabIndex = 1;
            this.labelCidade.Text = "Cidade:";
            // 
            // labelLogradouro
            // 
            this.labelLogradouro.AutoSize = true;
            this.labelLogradouro.Location = new System.Drawing.Point(46, 30);
            this.labelLogradouro.Name = "labelLogradouro";
            this.labelLogradouro.Size = new System.Drawing.Size(64, 13);
            this.labelLogradouro.TabIndex = 0;
            this.labelLogradouro.Text = "Logradouro:";
            // 
            // groupBoxDadosCadastrais
            // 
            this.groupBoxDadosCadastrais.Controls.Add(this.richTextBoxObservacao);
            this.groupBoxDadosCadastrais.Controls.Add(this.labelObservacao);
            this.groupBoxDadosCadastrais.Controls.Add(this.dateTimeCadastro);
            this.groupBoxDadosCadastrais.Controls.Add(this.labelDataCadastro);
            this.groupBoxDadosCadastrais.Location = new System.Drawing.Point(389, 25);
            this.groupBoxDadosCadastrais.Name = "groupBoxDadosCadastrais";
            this.groupBoxDadosCadastrais.Size = new System.Drawing.Size(381, 257);
            this.groupBoxDadosCadastrais.TabIndex = 2;
            this.groupBoxDadosCadastrais.TabStop = false;
            this.groupBoxDadosCadastrais.Text = "Dados cadastrais";
            // 
            // richTextBoxObservacao
            // 
            this.richTextBoxObservacao.Location = new System.Drawing.Point(38, 85);
            this.richTextBoxObservacao.Name = "richTextBoxObservacao";
            this.richTextBoxObservacao.Size = new System.Drawing.Size(315, 159);
            this.richTextBoxObservacao.TabIndex = 3;
            this.richTextBoxObservacao.Text = "";
            // 
            // labelObservacao
            // 
            this.labelObservacao.AutoSize = true;
            this.labelObservacao.Location = new System.Drawing.Point(35, 61);
            this.labelObservacao.Name = "labelObservacao";
            this.labelObservacao.Size = new System.Drawing.Size(68, 13);
            this.labelObservacao.TabIndex = 2;
            this.labelObservacao.Text = "Observação:";
            // 
            // dateTimeCadastro
            // 
            this.dateTimeCadastro.Location = new System.Drawing.Point(119, 21);
            this.dateTimeCadastro.Name = "dateTimeCadastro";
            this.dateTimeCadastro.Size = new System.Drawing.Size(234, 20);
            this.dateTimeCadastro.TabIndex = 1;
            // 
            // labelDataCadastro
            // 
            this.labelDataCadastro.AutoSize = true;
            this.labelDataCadastro.Location = new System.Drawing.Point(35, 27);
            this.labelDataCadastro.Name = "labelDataCadastro";
            this.labelDataCadastro.Size = new System.Drawing.Size(77, 13);
            this.labelDataCadastro.TabIndex = 0;
            this.labelDataCadastro.Text = "Data cadastro:";
            // 
            // groupBoxCriar
            // 
            this.groupBoxCriar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBoxCriar.Controls.Add(this.buttonCadastrar);
            this.groupBoxCriar.Controls.Add(this.groupBoxDadosCadastrais);
            this.groupBoxCriar.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCriar.Name = "groupBoxCriar";
            this.groupBoxCriar.Size = new System.Drawing.Size(776, 330);
            this.groupBoxCriar.TabIndex = 3;
            this.groupBoxCriar.TabStop = false;
            this.groupBoxCriar.Text = "Cadastrar";
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.Location = new System.Drawing.Point(271, 301);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(221, 23);
            this.buttonCadastrar.TabIndex = 0;
            this.buttonCadastrar.Text = "Cadastrar";
            this.buttonCadastrar.UseVisualStyleBackColor = true;
            this.buttonCadastrar.Click += new System.EventHandler(this.buttonCadastrar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.buttonExibir);
            this.groupBox1.Controls.Add(this.dataGridViewPessoa);
            this.groupBox1.Location = new System.Drawing.Point(12, 361);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 262);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pessoa cadastradas";
            // 
            // dataGridViewPessoa
            // 
            this.dataGridViewPessoa.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewPessoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPessoa.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridViewPessoa.Location = new System.Drawing.Point(17, 37);
            this.dataGridViewPessoa.MultiSelect = false;
            this.dataGridViewPessoa.Name = "dataGridViewPessoa";
            this.dataGridViewPessoa.ReadOnly = true;
            this.dataGridViewPessoa.RowTemplate.ReadOnly = true;
            this.dataGridViewPessoa.Size = new System.Drawing.Size(747, 167);
            this.dataGridViewPessoa.TabIndex = 0;
            // 
            // buttonExibir
            // 
            this.buttonExibir.AutoSize = true;
            this.buttonExibir.Location = new System.Drawing.Point(271, 219);
            this.buttonExibir.Name = "buttonExibir";
            this.buttonExibir.Size = new System.Drawing.Size(221, 23);
            this.buttonExibir.TabIndex = 1;
            this.buttonExibir.Text = "Exibir cadastro";
            this.buttonExibir.UseVisualStyleBackColor = true;
            this.buttonExibir.Click += new System.EventHandler(this.buttonExibir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 635);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxEndereco);
            this.Controls.Add(this.groupBoxDadosPessoais);
            this.Controls.Add(this.groupBoxCriar);
            this.Name = "Form1";
            this.Text = "Cadastro de Pessoas";
            this.groupBoxDadosPessoais.ResumeLayout(false);
            this.groupBoxDadosPessoais.PerformLayout();
            this.groupBoxEndereco.ResumeLayout(false);
            this.groupBoxEndereco.PerformLayout();
            this.groupBoxDadosCadastrais.ResumeLayout(false);
            this.groupBoxDadosCadastrais.PerformLayout();
            this.groupBoxCriar.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPessoa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDadosPessoais;
        private System.Windows.Forms.RadioButton radioButtonMasculino;
        private System.Windows.Forms.RadioButton radioButtonFeminino;
        private System.Windows.Forms.DateTimePicker dateTimeNascimento;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label labelGenero;
        private System.Windows.Forms.Label labelDataNascimento;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.GroupBox groupBoxEndereco;
        private System.Windows.Forms.TextBox textBoxCidade;
        private System.Windows.Forms.TextBox textBoxLogradouro;
        private System.Windows.Forms.TextBox textBoxEstado;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.Label labelCidade;
        private System.Windows.Forms.Label labelLogradouro;
        private System.Windows.Forms.GroupBox groupBoxDadosCadastrais;
        private System.Windows.Forms.RichTextBox richTextBoxObservacao;
        private System.Windows.Forms.Label labelObservacao;
        private System.Windows.Forms.DateTimePicker dateTimeCadastro;
        private System.Windows.Forms.Label labelDataCadastro;
        private System.Windows.Forms.GroupBox groupBoxCriar;
        private System.Windows.Forms.Button buttonCadastrar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewPessoa;
        private System.Windows.Forms.Button buttonExibir;
    }
}

