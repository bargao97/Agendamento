namespace Agendamento
{
    partial class VerContatos
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
            this.txtLocalidadeEmpresa = new System.Windows.Forms.TextBox();
            this.lblLocalidadeEmpresa = new System.Windows.Forms.Label();
            this.chkEmpresa = new System.Windows.Forms.CheckBox();
            this.chkResidencial = new System.Windows.Forms.CheckBox();
            this.txtLocalidadeResidencial = new System.Windows.Forms.TextBox();
            this.lblLocalidadeResidencial = new System.Windows.Forms.Label();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.txtUFResidencial = new System.Windows.Forms.TextBox();
            this.lblUFResidencial = new System.Windows.Forms.Label();
            this.lblBairroResidencial = new System.Windows.Forms.Label();
            this.lblNumeroResidencial = new System.Windows.Forms.Label();
            this.txtLogradouroResidencial = new System.Windows.Forms.TextBox();
            this.txtNumeroResidencial = new System.Windows.Forms.TextBox();
            this.txtComplementoResidencial = new System.Windows.Forms.TextBox();
            this.txtBairroResidencial = new System.Windows.Forms.TextBox();
            this.txtCepResidencial = new System.Windows.Forms.TextBox();
            this.lblCargoEmpresa = new System.Windows.Forms.Label();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.lblNomeEmpresa = new System.Windows.Forms.Label();
            this.txtNomeEmpresa = new System.Windows.Forms.TextBox();
            this.txtUFEmpresa = new System.Windows.Forms.TextBox();
            this.lblUFEmpresa = new System.Windows.Forms.Label();
            this.lblBairroEmpresa = new System.Windows.Forms.Label();
            this.lblComplementoEmpresa = new System.Windows.Forms.Label();
            this.lblNumeroEmpresa = new System.Windows.Forms.Label();
            this.lblLogradouroEmpresa = new System.Windows.Forms.Label();
            this.txtLogradouroEmpresa = new System.Windows.Forms.TextBox();
            this.txtNumeroEmpresa = new System.Windows.Forms.TextBox();
            this.txtComplementoEmpresa = new System.Windows.Forms.TextBox();
            this.txtBairroEmpresa = new System.Windows.Forms.TextBox();
            this.lblCepEmpresa = new System.Windows.Forms.Label();
            this.txtCepEmpresa = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTipoTelPrincipal = new System.Windows.Forms.TextBox();
            this.cbxTipoTelPrincipal = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeContato = new System.Windows.Forms.TextBox();
            this.txtTelPrincipal = new System.Windows.Forms.MaskedTextBox();
            this.gdvTelefone = new System.Windows.Forms.DataGridView();
            this.gdvEmail = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddTel = new System.Windows.Forms.Button();
            this.btnAddEmail = new System.Windows.Forms.Button();
            this.lblCepResidencial = new System.Windows.Forms.Label();
            this.lblComplementoResidencial = new System.Windows.Forms.Label();
            this.lblLogradouroResidencial = new System.Windows.Forms.Label();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnCarregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gdvTelefone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvEmail)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLocalidadeEmpresa
            // 
            this.txtLocalidadeEmpresa.Location = new System.Drawing.Point(843, 386);
            this.txtLocalidadeEmpresa.Name = "txtLocalidadeEmpresa";
            this.txtLocalidadeEmpresa.Size = new System.Drawing.Size(94, 20);
            this.txtLocalidadeEmpresa.TabIndex = 119;
            this.txtLocalidadeEmpresa.Visible = false;
            // 
            // lblLocalidadeEmpresa
            // 
            this.lblLocalidadeEmpresa.AutoSize = true;
            this.lblLocalidadeEmpresa.Location = new System.Drawing.Point(778, 393);
            this.lblLocalidadeEmpresa.Name = "lblLocalidadeEmpresa";
            this.lblLocalidadeEmpresa.Size = new System.Drawing.Size(59, 13);
            this.lblLocalidadeEmpresa.TabIndex = 120;
            this.lblLocalidadeEmpresa.Text = "Localidade";
            this.lblLocalidadeEmpresa.Visible = false;
            // 
            // chkEmpresa
            // 
            this.chkEmpresa.AutoSize = true;
            this.chkEmpresa.Location = new System.Drawing.Point(781, 312);
            this.chkEmpresa.Name = "chkEmpresa";
            this.chkEmpresa.Size = new System.Drawing.Size(97, 17);
            this.chkEmpresa.TabIndex = 118;
            this.chkEmpresa.Text = "Inserir empresa";
            this.chkEmpresa.UseVisualStyleBackColor = true;
            this.chkEmpresa.CheckedChanged += new System.EventHandler(this.chkEmpresa_CheckedChanged);
            // 
            // chkResidencial
            // 
            this.chkResidencial.AutoSize = true;
            this.chkResidencial.Location = new System.Drawing.Point(367, 312);
            this.chkResidencial.Name = "chkResidencial";
            this.chkResidencial.Size = new System.Drawing.Size(102, 17);
            this.chkResidencial.TabIndex = 117;
            this.chkResidencial.Text = "Inserir endereço";
            this.chkResidencial.UseVisualStyleBackColor = true;
            this.chkResidencial.CheckedChanged += new System.EventHandler(this.chkResidencial_CheckedChanged);
            // 
            // txtLocalidadeResidencial
            // 
            this.txtLocalidadeResidencial.Location = new System.Drawing.Point(338, 352);
            this.txtLocalidadeResidencial.Name = "txtLocalidadeResidencial";
            this.txtLocalidadeResidencial.Size = new System.Drawing.Size(94, 20);
            this.txtLocalidadeResidencial.TabIndex = 115;
            this.txtLocalidadeResidencial.Visible = false;
            // 
            // lblLocalidadeResidencial
            // 
            this.lblLocalidadeResidencial.AutoSize = true;
            this.lblLocalidadeResidencial.Location = new System.Drawing.Point(273, 355);
            this.lblLocalidadeResidencial.Name = "lblLocalidadeResidencial";
            this.lblLocalidadeResidencial.Size = new System.Drawing.Size(59, 13);
            this.lblLocalidadeResidencial.TabIndex = 116;
            this.lblLocalidadeResidencial.Text = "Localidade";
            this.lblLocalidadeResidencial.Visible = false;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Location = new System.Drawing.Point(372, 471);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(179, 57);
            this.btnAlterar.TabIndex = 103;
            this.btnAlterar.Text = "ALTERAR";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // txtUFResidencial
            // 
            this.txtUFResidencial.Location = new System.Drawing.Point(225, 352);
            this.txtUFResidencial.Name = "txtUFResidencial";
            this.txtUFResidencial.Size = new System.Drawing.Size(31, 20);
            this.txtUFResidencial.TabIndex = 87;
            this.txtUFResidencial.Visible = false;
            // 
            // lblUFResidencial
            // 
            this.lblUFResidencial.AutoSize = true;
            this.lblUFResidencial.Location = new System.Drawing.Point(198, 355);
            this.lblUFResidencial.Name = "lblUFResidencial";
            this.lblUFResidencial.Size = new System.Drawing.Size(21, 13);
            this.lblUFResidencial.TabIndex = 114;
            this.lblUFResidencial.Text = "UF";
            this.lblUFResidencial.Visible = false;
            // 
            // lblBairroResidencial
            // 
            this.lblBairroResidencial.AutoSize = true;
            this.lblBairroResidencial.Location = new System.Drawing.Point(240, 411);
            this.lblBairroResidencial.Name = "lblBairroResidencial";
            this.lblBairroResidencial.Size = new System.Drawing.Size(34, 13);
            this.lblBairroResidencial.TabIndex = 113;
            this.lblBairroResidencial.Text = "Bairro";
            this.lblBairroResidencial.Visible = false;
            // 
            // lblNumeroResidencial
            // 
            this.lblNumeroResidencial.AutoSize = true;
            this.lblNumeroResidencial.Location = new System.Drawing.Point(240, 384);
            this.lblNumeroResidencial.Name = "lblNumeroResidencial";
            this.lblNumeroResidencial.Size = new System.Drawing.Size(44, 13);
            this.lblNumeroResidencial.TabIndex = 112;
            this.lblNumeroResidencial.Text = "Número";
            this.lblNumeroResidencial.Visible = false;
            // 
            // txtLogradouroResidencial
            // 
            this.txtLogradouroResidencial.Location = new System.Drawing.Point(101, 380);
            this.txtLogradouroResidencial.Name = "txtLogradouroResidencial";
            this.txtLogradouroResidencial.Size = new System.Drawing.Size(118, 20);
            this.txtLogradouroResidencial.TabIndex = 89;
            this.txtLogradouroResidencial.Visible = false;
            // 
            // txtNumeroResidencial
            // 
            this.txtNumeroResidencial.Location = new System.Drawing.Point(290, 381);
            this.txtNumeroResidencial.Name = "txtNumeroResidencial";
            this.txtNumeroResidencial.Size = new System.Drawing.Size(78, 20);
            this.txtNumeroResidencial.TabIndex = 90;
            this.txtNumeroResidencial.Visible = false;
            // 
            // txtComplementoResidencial
            // 
            this.txtComplementoResidencial.Location = new System.Drawing.Point(101, 408);
            this.txtComplementoResidencial.Name = "txtComplementoResidencial";
            this.txtComplementoResidencial.Size = new System.Drawing.Size(118, 20);
            this.txtComplementoResidencial.TabIndex = 92;
            this.txtComplementoResidencial.Visible = false;
            // 
            // txtBairroResidencial
            // 
            this.txtBairroResidencial.Location = new System.Drawing.Point(290, 408);
            this.txtBairroResidencial.Name = "txtBairroResidencial";
            this.txtBairroResidencial.Size = new System.Drawing.Size(118, 20);
            this.txtBairroResidencial.TabIndex = 93;
            this.txtBairroResidencial.Visible = false;
            // 
            // txtCepResidencial
            // 
            this.txtCepResidencial.Location = new System.Drawing.Point(61, 352);
            this.txtCepResidencial.Name = "txtCepResidencial";
            this.txtCepResidencial.Size = new System.Drawing.Size(118, 20);
            this.txtCepResidencial.TabIndex = 86;
            this.txtCepResidencial.Visible = false;
            this.txtCepResidencial.Leave += new System.EventHandler(this.txtCepResidencial_Leave);
            // 
            // lblCargoEmpresa
            // 
            this.lblCargoEmpresa.AutoSize = true;
            this.lblCargoEmpresa.Location = new System.Drawing.Point(760, 355);
            this.lblCargoEmpresa.Name = "lblCargoEmpresa";
            this.lblCargoEmpresa.Size = new System.Drawing.Size(35, 13);
            this.lblCargoEmpresa.TabIndex = 111;
            this.lblCargoEmpresa.Text = "Cargo";
            this.lblCargoEmpresa.Visible = false;
            // 
            // txtCargo
            // 
            this.txtCargo.Location = new System.Drawing.Point(801, 352);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(118, 20);
            this.txtCargo.TabIndex = 96;
            this.txtCargo.Visible = false;
            // 
            // lblNomeEmpresa
            // 
            this.lblNomeEmpresa.AutoSize = true;
            this.lblNomeEmpresa.Location = new System.Drawing.Point(529, 355);
            this.lblNomeEmpresa.Name = "lblNomeEmpresa";
            this.lblNomeEmpresa.Size = new System.Drawing.Size(94, 13);
            this.lblNomeEmpresa.TabIndex = 110;
            this.lblNomeEmpresa.Text = "Nome da Empresa";
            this.lblNomeEmpresa.Visible = false;
            // 
            // txtNomeEmpresa
            // 
            this.txtNomeEmpresa.Location = new System.Drawing.Point(629, 352);
            this.txtNomeEmpresa.Name = "txtNomeEmpresa";
            this.txtNomeEmpresa.Size = new System.Drawing.Size(118, 20);
            this.txtNomeEmpresa.TabIndex = 95;
            this.txtNomeEmpresa.Visible = false;
            // 
            // txtUFEmpresa
            // 
            this.txtUFEmpresa.Location = new System.Drawing.Point(730, 386);
            this.txtUFEmpresa.Name = "txtUFEmpresa";
            this.txtUFEmpresa.Size = new System.Drawing.Size(31, 20);
            this.txtUFEmpresa.TabIndex = 98;
            this.txtUFEmpresa.Visible = false;
            // 
            // lblUFEmpresa
            // 
            this.lblUFEmpresa.AutoSize = true;
            this.lblUFEmpresa.Location = new System.Drawing.Point(703, 393);
            this.lblUFEmpresa.Name = "lblUFEmpresa";
            this.lblUFEmpresa.Size = new System.Drawing.Size(21, 13);
            this.lblUFEmpresa.TabIndex = 109;
            this.lblUFEmpresa.Text = "UF";
            this.lblUFEmpresa.Visible = false;
            // 
            // lblBairroEmpresa
            // 
            this.lblBairroEmpresa.AutoSize = true;
            this.lblBairroEmpresa.Location = new System.Drawing.Point(745, 445);
            this.lblBairroEmpresa.Name = "lblBairroEmpresa";
            this.lblBairroEmpresa.Size = new System.Drawing.Size(34, 13);
            this.lblBairroEmpresa.TabIndex = 108;
            this.lblBairroEmpresa.Text = "Bairro";
            this.lblBairroEmpresa.Visible = false;
            // 
            // lblComplementoEmpresa
            // 
            this.lblComplementoEmpresa.AutoSize = true;
            this.lblComplementoEmpresa.Location = new System.Drawing.Point(529, 449);
            this.lblComplementoEmpresa.Name = "lblComplementoEmpresa";
            this.lblComplementoEmpresa.Size = new System.Drawing.Size(71, 13);
            this.lblComplementoEmpresa.TabIndex = 107;
            this.lblComplementoEmpresa.Text = "Complemento";
            this.lblComplementoEmpresa.Visible = false;
            // 
            // lblNumeroEmpresa
            // 
            this.lblNumeroEmpresa.AutoSize = true;
            this.lblNumeroEmpresa.Location = new System.Drawing.Point(745, 418);
            this.lblNumeroEmpresa.Name = "lblNumeroEmpresa";
            this.lblNumeroEmpresa.Size = new System.Drawing.Size(44, 13);
            this.lblNumeroEmpresa.TabIndex = 106;
            this.lblNumeroEmpresa.Text = "Número";
            this.lblNumeroEmpresa.Visible = false;
            // 
            // lblLogradouroEmpresa
            // 
            this.lblLogradouroEmpresa.AutoSize = true;
            this.lblLogradouroEmpresa.Location = new System.Drawing.Point(529, 418);
            this.lblLogradouroEmpresa.Name = "lblLogradouroEmpresa";
            this.lblLogradouroEmpresa.Size = new System.Drawing.Size(61, 13);
            this.lblLogradouroEmpresa.TabIndex = 105;
            this.lblLogradouroEmpresa.Text = "Logradouro";
            this.lblLogradouroEmpresa.Visible = false;
            // 
            // txtLogradouroEmpresa
            // 
            this.txtLogradouroEmpresa.Location = new System.Drawing.Point(606, 414);
            this.txtLogradouroEmpresa.Name = "txtLogradouroEmpresa";
            this.txtLogradouroEmpresa.Size = new System.Drawing.Size(118, 20);
            this.txtLogradouroEmpresa.TabIndex = 99;
            this.txtLogradouroEmpresa.Visible = false;
            // 
            // txtNumeroEmpresa
            // 
            this.txtNumeroEmpresa.Location = new System.Drawing.Point(795, 415);
            this.txtNumeroEmpresa.Name = "txtNumeroEmpresa";
            this.txtNumeroEmpresa.Size = new System.Drawing.Size(78, 20);
            this.txtNumeroEmpresa.TabIndex = 100;
            this.txtNumeroEmpresa.Visible = false;
            // 
            // txtComplementoEmpresa
            // 
            this.txtComplementoEmpresa.Location = new System.Drawing.Point(606, 442);
            this.txtComplementoEmpresa.Name = "txtComplementoEmpresa";
            this.txtComplementoEmpresa.Size = new System.Drawing.Size(118, 20);
            this.txtComplementoEmpresa.TabIndex = 101;
            this.txtComplementoEmpresa.Visible = false;
            // 
            // txtBairroEmpresa
            // 
            this.txtBairroEmpresa.Location = new System.Drawing.Point(795, 442);
            this.txtBairroEmpresa.Name = "txtBairroEmpresa";
            this.txtBairroEmpresa.Size = new System.Drawing.Size(118, 20);
            this.txtBairroEmpresa.TabIndex = 102;
            this.txtBairroEmpresa.Visible = false;
            // 
            // lblCepEmpresa
            // 
            this.lblCepEmpresa.AutoSize = true;
            this.lblCepEmpresa.Location = new System.Drawing.Point(529, 393);
            this.lblCepEmpresa.Name = "lblCepEmpresa";
            this.lblCepEmpresa.Size = new System.Drawing.Size(28, 13);
            this.lblCepEmpresa.TabIndex = 104;
            this.lblCepEmpresa.Text = "CEP";
            this.lblCepEmpresa.Visible = false;
            // 
            // txtCepEmpresa
            // 
            this.txtCepEmpresa.Location = new System.Drawing.Point(566, 386);
            this.txtCepEmpresa.Name = "txtCepEmpresa";
            this.txtCepEmpresa.Size = new System.Drawing.Size(118, 20);
            this.txtCepEmpresa.TabIndex = 97;
            this.txtCepEmpresa.Visible = false;
            this.txtCepEmpresa.Leave += new System.EventHandler(this.txtCepEmpresa_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(566, 304);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(209, 25);
            this.label7.TabIndex = 94;
            this.label7.Text = "Empresa(opcional)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(347, 25);
            this.label6.TabIndex = 91;
            this.label6.Text = "Endereço Residencial(opcional)";
            // 
            // txtTipoTelPrincipal
            // 
            this.txtTipoTelPrincipal.Location = new System.Drawing.Point(460, 55);
            this.txtTipoTelPrincipal.Name = "txtTipoTelPrincipal";
            this.txtTipoTelPrincipal.Size = new System.Drawing.Size(100, 20);
            this.txtTipoTelPrincipal.TabIndex = 68;
            // 
            // cbxTipoTelPrincipal
            // 
            this.cbxTipoTelPrincipal.FormattingEnabled = true;
            this.cbxTipoTelPrincipal.Location = new System.Drawing.Point(354, 55);
            this.cbxTipoTelPrincipal.Name = "cbxTipoTelPrincipal";
            this.cbxTipoTelPrincipal.Size = new System.Drawing.Size(100, 21);
            this.cbxTipoTelPrincipal.TabIndex = 67;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(305, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(269, 33);
            this.label4.TabIndex = 76;
            this.label4.Text = "Cadastrar Contato";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(258, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 71;
            this.label2.Text = "Telefone principal*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 70;
            this.label1.Text = "Nome do Contato*";
            // 
            // txtNomeContato
            // 
            this.txtNomeContato.Location = new System.Drawing.Point(137, 55);
            this.txtNomeContato.Name = "txtNomeContato";
            this.txtNomeContato.Size = new System.Drawing.Size(100, 20);
            this.txtNomeContato.TabIndex = 66;
            // 
            // txtTelPrincipal
            // 
            this.txtTelPrincipal.Location = new System.Drawing.Point(566, 55);
            this.txtTelPrincipal.Mask = "(99)99999-9999";
            this.txtTelPrincipal.Name = "txtTelPrincipal";
            this.txtTelPrincipal.Size = new System.Drawing.Size(100, 20);
            this.txtTelPrincipal.TabIndex = 69;
            // 
            // gdvTelefone
            // 
            this.gdvTelefone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvTelefone.Location = new System.Drawing.Point(20, 146);
            this.gdvTelefone.Name = "gdvTelefone";
            this.gdvTelefone.Size = new System.Drawing.Size(388, 137);
            this.gdvTelefone.TabIndex = 121;
            this.gdvTelefone.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdvTelefone_CellContentClick);
            // 
            // gdvEmail
            // 
            this.gdvEmail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvEmail.Location = new System.Drawing.Point(495, 146);
            this.gdvEmail.Name = "gdvEmail";
            this.gdvEmail.Size = new System.Drawing.Size(418, 137);
            this.gdvEmail.TabIndex = 122;
            this.gdvEmail.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdvEmail_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 25);
            this.label3.TabIndex = 123;
            this.label3.Text = "Telefones Opcionais";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(595, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 25);
            this.label5.TabIndex = 124;
            this.label5.Text = "Emails Opcionais";
            // 
            // btnAddTel
            // 
            this.btnAddTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTel.Location = new System.Drawing.Point(276, 109);
            this.btnAddTel.Name = "btnAddTel";
            this.btnAddTel.Size = new System.Drawing.Size(41, 34);
            this.btnAddTel.TabIndex = 125;
            this.btnAddTel.Text = "+";
            this.btnAddTel.UseVisualStyleBackColor = true;
            this.btnAddTel.Click += new System.EventHandler(this.btnAddTel_Click);
            // 
            // btnAddEmail
            // 
            this.btnAddEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEmail.Location = new System.Drawing.Point(795, 106);
            this.btnAddEmail.Name = "btnAddEmail";
            this.btnAddEmail.Size = new System.Drawing.Size(41, 34);
            this.btnAddEmail.TabIndex = 126;
            this.btnAddEmail.Text = "+";
            this.btnAddEmail.UseVisualStyleBackColor = true;
            this.btnAddEmail.Click += new System.EventHandler(this.btnAddEmail_Click);
            // 
            // lblCepResidencial
            // 
            this.lblCepResidencial.AutoSize = true;
            this.lblCepResidencial.Location = new System.Drawing.Point(17, 355);
            this.lblCepResidencial.Name = "lblCepResidencial";
            this.lblCepResidencial.Size = new System.Drawing.Size(28, 13);
            this.lblCepResidencial.TabIndex = 129;
            this.lblCepResidencial.Text = "CEP";
            this.lblCepResidencial.Visible = false;
            // 
            // lblComplementoResidencial
            // 
            this.lblComplementoResidencial.AutoSize = true;
            this.lblComplementoResidencial.Location = new System.Drawing.Point(17, 415);
            this.lblComplementoResidencial.Name = "lblComplementoResidencial";
            this.lblComplementoResidencial.Size = new System.Drawing.Size(71, 13);
            this.lblComplementoResidencial.TabIndex = 128;
            this.lblComplementoResidencial.Text = "Complemento";
            this.lblComplementoResidencial.Visible = false;
            // 
            // lblLogradouroResidencial
            // 
            this.lblLogradouroResidencial.AutoSize = true;
            this.lblLogradouroResidencial.Location = new System.Drawing.Point(17, 384);
            this.lblLogradouroResidencial.Name = "lblLogradouroResidencial";
            this.lblLogradouroResidencial.Size = new System.Drawing.Size(61, 13);
            this.lblLogradouroResidencial.TabIndex = 127;
            this.lblLogradouroResidencial.Text = "Logradouro";
            this.lblLogradouroResidencial.Visible = false;
            // 
            // btnApagar
            // 
            this.btnApagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagar.Location = new System.Drawing.Point(578, 471);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(179, 57);
            this.btnApagar.TabIndex = 130;
            this.btnApagar.Text = "APAGAR CONTATO";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // btnCarregar
            // 
            this.btnCarregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarregar.Location = new System.Drawing.Point(357, 106);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(200, 34);
            this.btnCarregar.TabIndex = 131;
            this.btnCarregar.Text = "Carregar dados Opcionais";
            this.btnCarregar.UseVisualStyleBackColor = true;
            this.btnCarregar.Click += new System.EventHandler(this.btnCarregar_Click);
            // 
            // VerContatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 540);
            this.Controls.Add(this.btnCarregar);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.lblCepResidencial);
            this.Controls.Add(this.lblComplementoResidencial);
            this.Controls.Add(this.lblLogradouroResidencial);
            this.Controls.Add(this.btnAddEmail);
            this.Controls.Add(this.btnAddTel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gdvEmail);
            this.Controls.Add(this.gdvTelefone);
            this.Controls.Add(this.txtLocalidadeEmpresa);
            this.Controls.Add(this.lblLocalidadeEmpresa);
            this.Controls.Add(this.chkEmpresa);
            this.Controls.Add(this.chkResidencial);
            this.Controls.Add(this.txtLocalidadeResidencial);
            this.Controls.Add(this.lblLocalidadeResidencial);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.txtUFResidencial);
            this.Controls.Add(this.lblUFResidencial);
            this.Controls.Add(this.lblBairroResidencial);
            this.Controls.Add(this.lblNumeroResidencial);
            this.Controls.Add(this.txtLogradouroResidencial);
            this.Controls.Add(this.txtNumeroResidencial);
            this.Controls.Add(this.txtComplementoResidencial);
            this.Controls.Add(this.txtBairroResidencial);
            this.Controls.Add(this.txtCepResidencial);
            this.Controls.Add(this.lblCargoEmpresa);
            this.Controls.Add(this.txtCargo);
            this.Controls.Add(this.lblNomeEmpresa);
            this.Controls.Add(this.txtNomeEmpresa);
            this.Controls.Add(this.txtUFEmpresa);
            this.Controls.Add(this.lblUFEmpresa);
            this.Controls.Add(this.lblBairroEmpresa);
            this.Controls.Add(this.lblComplementoEmpresa);
            this.Controls.Add(this.lblNumeroEmpresa);
            this.Controls.Add(this.lblLogradouroEmpresa);
            this.Controls.Add(this.txtLogradouroEmpresa);
            this.Controls.Add(this.txtNumeroEmpresa);
            this.Controls.Add(this.txtComplementoEmpresa);
            this.Controls.Add(this.txtBairroEmpresa);
            this.Controls.Add(this.lblCepEmpresa);
            this.Controls.Add(this.txtCepEmpresa);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTipoTelPrincipal);
            this.Controls.Add(this.cbxTipoTelPrincipal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNomeContato);
            this.Controls.Add(this.txtTelPrincipal);
            this.Name = "VerContatos";
            this.Text = "VerContatos";
            this.Load += new System.EventHandler(this.VerContatos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdvTelefone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvEmail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLocalidadeEmpresa;
        private System.Windows.Forms.Label lblLocalidadeEmpresa;
        private System.Windows.Forms.CheckBox chkEmpresa;
        private System.Windows.Forms.CheckBox chkResidencial;
        private System.Windows.Forms.TextBox txtLocalidadeResidencial;
        private System.Windows.Forms.Label lblLocalidadeResidencial;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.TextBox txtUFResidencial;
        private System.Windows.Forms.Label lblUFResidencial;
        private System.Windows.Forms.Label lblBairroResidencial;
        private System.Windows.Forms.Label lblNumeroResidencial;
        private System.Windows.Forms.TextBox txtLogradouroResidencial;
        private System.Windows.Forms.TextBox txtNumeroResidencial;
        private System.Windows.Forms.TextBox txtComplementoResidencial;
        private System.Windows.Forms.TextBox txtBairroResidencial;
        private System.Windows.Forms.TextBox txtCepResidencial;
        private System.Windows.Forms.Label lblCargoEmpresa;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.Label lblNomeEmpresa;
        private System.Windows.Forms.TextBox txtNomeEmpresa;
        private System.Windows.Forms.TextBox txtUFEmpresa;
        private System.Windows.Forms.Label lblUFEmpresa;
        private System.Windows.Forms.Label lblBairroEmpresa;
        private System.Windows.Forms.Label lblComplementoEmpresa;
        private System.Windows.Forms.Label lblNumeroEmpresa;
        private System.Windows.Forms.Label lblLogradouroEmpresa;
        private System.Windows.Forms.TextBox txtLogradouroEmpresa;
        private System.Windows.Forms.TextBox txtNumeroEmpresa;
        private System.Windows.Forms.TextBox txtComplementoEmpresa;
        private System.Windows.Forms.TextBox txtBairroEmpresa;
        private System.Windows.Forms.Label lblCepEmpresa;
        private System.Windows.Forms.TextBox txtCepEmpresa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTipoTelPrincipal;
        private System.Windows.Forms.ComboBox cbxTipoTelPrincipal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeContato;
        private System.Windows.Forms.MaskedTextBox txtTelPrincipal;
        private System.Windows.Forms.DataGridView gdvTelefone;
        private System.Windows.Forms.DataGridView gdvEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAddTel;
        private System.Windows.Forms.Button btnAddEmail;
        private System.Windows.Forms.Label lblCepResidencial;
        private System.Windows.Forms.Label lblComplementoResidencial;
        private System.Windows.Forms.Label lblLogradouroResidencial;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnCarregar;
    }
}