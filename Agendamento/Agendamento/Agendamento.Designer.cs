namespace Agendamento
{
    partial class Agendamento
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
            this.txtTelPrincipal = new System.Windows.Forms.MaskedTextBox();
            this.txtTelOpcional = new System.Windows.Forms.MaskedTextBox();
            this.txtNomeContato = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxTipoTelPrincipal = new System.Windows.Forms.ComboBox();
            this.txtTipoTelPrincipal = new System.Windows.Forms.TextBox();
            this.txtTipoTelOpcional = new System.Windows.Forms.TextBox();
            this.cbxTipoTelOpcional = new System.Windows.Forms.ComboBox();
            this.listTelOpcional = new System.Windows.Forms.ListBox();
            this.ListEmail = new System.Windows.Forms.ListBox();
            this.txtTipoEmail = new System.Windows.Forms.TextBox();
            this.cbxTipoEmail = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
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
            this.lblNomeEmpresa = new System.Windows.Forms.Label();
            this.txtNomeEmpresa = new System.Windows.Forms.TextBox();
            this.lblCargoEmpresa = new System.Windows.Forms.Label();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.txtUFResidencial = new System.Windows.Forms.TextBox();
            this.lblUFResidencial = new System.Windows.Forms.Label();
            this.lblBairroResidencial = new System.Windows.Forms.Label();
            this.lblComplementoResidencial = new System.Windows.Forms.Label();
            this.lblNumeroResidencial = new System.Windows.Forms.Label();
            this.lblLogradouroResidencial = new System.Windows.Forms.Label();
            this.txtLogradouroResidencial = new System.Windows.Forms.TextBox();
            this.txtNumeroResidencial = new System.Windows.Forms.TextBox();
            this.txtComplementoResidencial = new System.Windows.Forms.TextBox();
            this.txtBairroResidencial = new System.Windows.Forms.TextBox();
            this.txtCepResidencial = new System.Windows.Forms.TextBox();
            this.lblCepResidencial = new System.Windows.Forms.Label();
            this.btnAddListTel = new System.Windows.Forms.Button();
            this.btnExListTel = new System.Windows.Forms.Button();
            this.btnexListEmail = new System.Windows.Forms.Button();
            this.btnAddListEmail = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtLocalidadeResidencial = new System.Windows.Forms.TextBox();
            this.lblLocalidadeResidencial = new System.Windows.Forms.Label();
            this.chkResidencial = new System.Windows.Forms.CheckBox();
            this.chkEmpresa = new System.Windows.Forms.CheckBox();
            this.txtLocalidadeEmpresa = new System.Windows.Forms.TextBox();
            this.lblLocalidadeEmpresa = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTelPrincipal
            // 
            this.txtTelPrincipal.Location = new System.Drawing.Point(134, 108);
            this.txtTelPrincipal.Mask = "(99)99999-9999";
            this.txtTelPrincipal.Name = "txtTelPrincipal";
            this.txtTelPrincipal.Size = new System.Drawing.Size(100, 20);
            this.txtTelPrincipal.TabIndex = 3;
            // 
            // txtTelOpcional
            // 
            this.txtTelOpcional.Location = new System.Drawing.Point(472, 77);
            this.txtTelOpcional.Mask = "(99)99999-9999";
            this.txtTelOpcional.Name = "txtTelOpcional";
            this.txtTelOpcional.Size = new System.Drawing.Size(100, 20);
            this.txtTelOpcional.TabIndex = 6;
            // 
            // txtNomeContato
            // 
            this.txtNomeContato.Location = new System.Drawing.Point(134, 55);
            this.txtNomeContato.Name = "txtNomeContato";
            this.txtNomeContato.Size = new System.Drawing.Size(100, 20);
            this.txtNomeContato.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome do Contato*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Telefone principal*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(366, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Telefone (Opcional)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(302, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(269, 33);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cadastrar Contato";
            // 
            // cbxTipoTelPrincipal
            // 
            this.cbxTipoTelPrincipal.FormattingEnabled = true;
            this.cbxTipoTelPrincipal.Location = new System.Drawing.Point(134, 81);
            this.cbxTipoTelPrincipal.Name = "cbxTipoTelPrincipal";
            this.cbxTipoTelPrincipal.Size = new System.Drawing.Size(100, 21);
            this.cbxTipoTelPrincipal.TabIndex = 1;
            this.cbxTipoTelPrincipal.SelectedIndexChanged += new System.EventHandler(this.cbxTipoTelPrincipal_SelectedIndexChanged);
            // 
            // txtTipoTelPrincipal
            // 
            this.txtTipoTelPrincipal.Location = new System.Drawing.Point(240, 81);
            this.txtTipoTelPrincipal.Name = "txtTipoTelPrincipal";
            this.txtTipoTelPrincipal.Size = new System.Drawing.Size(100, 20);
            this.txtTipoTelPrincipal.TabIndex = 2;
            // 
            // txtTipoTelOpcional
            // 
            this.txtTipoTelOpcional.Location = new System.Drawing.Point(578, 50);
            this.txtTipoTelOpcional.Name = "txtTipoTelOpcional";
            this.txtTipoTelOpcional.Size = new System.Drawing.Size(100, 20);
            this.txtTipoTelOpcional.TabIndex = 5;
            this.txtTipoTelOpcional.Visible = false;
            // 
            // cbxTipoTelOpcional
            // 
            this.cbxTipoTelOpcional.FormattingEnabled = true;
            this.cbxTipoTelOpcional.Location = new System.Drawing.Point(472, 50);
            this.cbxTipoTelOpcional.Name = "cbxTipoTelOpcional";
            this.cbxTipoTelOpcional.Size = new System.Drawing.Size(100, 21);
            this.cbxTipoTelOpcional.TabIndex = 4;
            this.cbxTipoTelOpcional.SelectedIndexChanged += new System.EventHandler(this.cbxTipoTelOpcional_SelectedIndexChanged);
            // 
            // listTelOpcional
            // 
            this.listTelOpcional.FormattingEnabled = true;
            this.listTelOpcional.Location = new System.Drawing.Point(684, 50);
            this.listTelOpcional.Name = "listTelOpcional";
            this.listTelOpcional.Size = new System.Drawing.Size(120, 95);
            this.listTelOpcional.TabIndex = 11;
            // 
            // ListEmail
            // 
            this.ListEmail.FormattingEnabled = true;
            this.ListEmail.Location = new System.Drawing.Point(684, 157);
            this.ListEmail.Name = "ListEmail";
            this.ListEmail.Size = new System.Drawing.Size(120, 95);
            this.ListEmail.TabIndex = 16;
            // 
            // txtTipoEmail
            // 
            this.txtTipoEmail.Location = new System.Drawing.Point(568, 157);
            this.txtTipoEmail.Name = "txtTipoEmail";
            this.txtTipoEmail.Size = new System.Drawing.Size(100, 20);
            this.txtTipoEmail.TabIndex = 10;
            this.txtTipoEmail.Visible = false;
            // 
            // cbxTipoEmail
            // 
            this.cbxTipoEmail.FormattingEnabled = true;
            this.cbxTipoEmail.Location = new System.Drawing.Point(454, 157);
            this.cbxTipoEmail.Name = "cbxTipoEmail";
            this.cbxTipoEmail.Size = new System.Drawing.Size(100, 21);
            this.cbxTipoEmail.TabIndex = 9;
            this.cbxTipoEmail.SelectedIndexChanged += new System.EventHandler(this.cbxTipoEmail_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(366, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Email(opcional)";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(369, 184);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(206, 20);
            this.txtEmail.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(347, 25);
            this.label6.TabIndex = 18;
            this.label6.Text = "Endereço Residencial(opcional)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(563, 304);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(209, 25);
            this.label7.TabIndex = 19;
            this.label7.Text = "Empresa(opcional)";
            // 
            // txtUFEmpresa
            // 
            this.txtUFEmpresa.Location = new System.Drawing.Point(727, 386);
            this.txtUFEmpresa.Name = "txtUFEmpresa";
            this.txtUFEmpresa.Size = new System.Drawing.Size(31, 20);
            this.txtUFEmpresa.TabIndex = 23;
            this.txtUFEmpresa.Visible = false;
            // 
            // lblUFEmpresa
            // 
            this.lblUFEmpresa.AutoSize = true;
            this.lblUFEmpresa.Location = new System.Drawing.Point(700, 393);
            this.lblUFEmpresa.Name = "lblUFEmpresa";
            this.lblUFEmpresa.Size = new System.Drawing.Size(21, 13);
            this.lblUFEmpresa.TabIndex = 42;
            this.lblUFEmpresa.Text = "UF";
            this.lblUFEmpresa.Visible = false;
            // 
            // lblBairroEmpresa
            // 
            this.lblBairroEmpresa.AutoSize = true;
            this.lblBairroEmpresa.Location = new System.Drawing.Point(742, 445);
            this.lblBairroEmpresa.Name = "lblBairroEmpresa";
            this.lblBairroEmpresa.Size = new System.Drawing.Size(34, 13);
            this.lblBairroEmpresa.TabIndex = 41;
            this.lblBairroEmpresa.Text = "Bairro";
            this.lblBairroEmpresa.Visible = false;
            // 
            // lblComplementoEmpresa
            // 
            this.lblComplementoEmpresa.AutoSize = true;
            this.lblComplementoEmpresa.Location = new System.Drawing.Point(526, 449);
            this.lblComplementoEmpresa.Name = "lblComplementoEmpresa";
            this.lblComplementoEmpresa.Size = new System.Drawing.Size(71, 13);
            this.lblComplementoEmpresa.TabIndex = 40;
            this.lblComplementoEmpresa.Text = "Complemento";
            this.lblComplementoEmpresa.Visible = false;
            // 
            // lblNumeroEmpresa
            // 
            this.lblNumeroEmpresa.AutoSize = true;
            this.lblNumeroEmpresa.Location = new System.Drawing.Point(742, 418);
            this.lblNumeroEmpresa.Name = "lblNumeroEmpresa";
            this.lblNumeroEmpresa.Size = new System.Drawing.Size(44, 13);
            this.lblNumeroEmpresa.TabIndex = 39;
            this.lblNumeroEmpresa.Text = "Número";
            this.lblNumeroEmpresa.Visible = false;
            // 
            // lblLogradouroEmpresa
            // 
            this.lblLogradouroEmpresa.AutoSize = true;
            this.lblLogradouroEmpresa.Location = new System.Drawing.Point(526, 418);
            this.lblLogradouroEmpresa.Name = "lblLogradouroEmpresa";
            this.lblLogradouroEmpresa.Size = new System.Drawing.Size(61, 13);
            this.lblLogradouroEmpresa.TabIndex = 38;
            this.lblLogradouroEmpresa.Text = "Logradouro";
            this.lblLogradouroEmpresa.Visible = false;
            // 
            // txtLogradouroEmpresa
            // 
            this.txtLogradouroEmpresa.Location = new System.Drawing.Point(603, 414);
            this.txtLogradouroEmpresa.Name = "txtLogradouroEmpresa";
            this.txtLogradouroEmpresa.Size = new System.Drawing.Size(118, 20);
            this.txtLogradouroEmpresa.TabIndex = 24;
            this.txtLogradouroEmpresa.Visible = false;
            // 
            // txtNumeroEmpresa
            // 
            this.txtNumeroEmpresa.Location = new System.Drawing.Point(792, 415);
            this.txtNumeroEmpresa.Name = "txtNumeroEmpresa";
            this.txtNumeroEmpresa.Size = new System.Drawing.Size(78, 20);
            this.txtNumeroEmpresa.TabIndex = 25;
            this.txtNumeroEmpresa.Visible = false;
            // 
            // txtComplementoEmpresa
            // 
            this.txtComplementoEmpresa.Location = new System.Drawing.Point(603, 442);
            this.txtComplementoEmpresa.Name = "txtComplementoEmpresa";
            this.txtComplementoEmpresa.Size = new System.Drawing.Size(118, 20);
            this.txtComplementoEmpresa.TabIndex = 26;
            this.txtComplementoEmpresa.Visible = false;
            // 
            // txtBairroEmpresa
            // 
            this.txtBairroEmpresa.Location = new System.Drawing.Point(792, 442);
            this.txtBairroEmpresa.Name = "txtBairroEmpresa";
            this.txtBairroEmpresa.Size = new System.Drawing.Size(118, 20);
            this.txtBairroEmpresa.TabIndex = 27;
            this.txtBairroEmpresa.Visible = false;
            // 
            // lblCepEmpresa
            // 
            this.lblCepEmpresa.AutoSize = true;
            this.lblCepEmpresa.Location = new System.Drawing.Point(526, 393);
            this.lblCepEmpresa.Name = "lblCepEmpresa";
            this.lblCepEmpresa.Size = new System.Drawing.Size(28, 13);
            this.lblCepEmpresa.TabIndex = 33;
            this.lblCepEmpresa.Text = "CEP";
            this.lblCepEmpresa.Visible = false;
            // 
            // txtCepEmpresa
            // 
            this.txtCepEmpresa.Location = new System.Drawing.Point(563, 386);
            this.txtCepEmpresa.Name = "txtCepEmpresa";
            this.txtCepEmpresa.Size = new System.Drawing.Size(118, 20);
            this.txtCepEmpresa.TabIndex = 22;
            this.txtCepEmpresa.Visible = false;
            this.txtCepEmpresa.Leave += new System.EventHandler(this.txtCepEmpresa_Leave);
            // 
            // lblNomeEmpresa
            // 
            this.lblNomeEmpresa.AutoSize = true;
            this.lblNomeEmpresa.Location = new System.Drawing.Point(526, 355);
            this.lblNomeEmpresa.Name = "lblNomeEmpresa";
            this.lblNomeEmpresa.Size = new System.Drawing.Size(94, 13);
            this.lblNomeEmpresa.TabIndex = 45;
            this.lblNomeEmpresa.Text = "Nome da Empresa";
            this.lblNomeEmpresa.Visible = false;
            // 
            // txtNomeEmpresa
            // 
            this.txtNomeEmpresa.Location = new System.Drawing.Point(626, 352);
            this.txtNomeEmpresa.Name = "txtNomeEmpresa";
            this.txtNomeEmpresa.Size = new System.Drawing.Size(118, 20);
            this.txtNomeEmpresa.TabIndex = 20;
            this.txtNomeEmpresa.Visible = false;
            // 
            // lblCargoEmpresa
            // 
            this.lblCargoEmpresa.AutoSize = true;
            this.lblCargoEmpresa.Location = new System.Drawing.Point(757, 355);
            this.lblCargoEmpresa.Name = "lblCargoEmpresa";
            this.lblCargoEmpresa.Size = new System.Drawing.Size(35, 13);
            this.lblCargoEmpresa.TabIndex = 47;
            this.lblCargoEmpresa.Text = "Cargo";
            this.lblCargoEmpresa.Visible = false;
            // 
            // txtCargo
            // 
            this.txtCargo.Location = new System.Drawing.Point(798, 352);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(118, 20);
            this.txtCargo.TabIndex = 21;
            this.txtCargo.Visible = false;
            // 
            // txtUFResidencial
            // 
            this.txtUFResidencial.Location = new System.Drawing.Point(222, 352);
            this.txtUFResidencial.Name = "txtUFResidencial";
            this.txtUFResidencial.Size = new System.Drawing.Size(31, 20);
            this.txtUFResidencial.TabIndex = 15;
            this.txtUFResidencial.Visible = false;
            // 
            // lblUFResidencial
            // 
            this.lblUFResidencial.AutoSize = true;
            this.lblUFResidencial.Location = new System.Drawing.Point(195, 355);
            this.lblUFResidencial.Name = "lblUFResidencial";
            this.lblUFResidencial.Size = new System.Drawing.Size(21, 13);
            this.lblUFResidencial.TabIndex = 57;
            this.lblUFResidencial.Text = "UF";
            this.lblUFResidencial.Visible = false;
            // 
            // lblBairroResidencial
            // 
            this.lblBairroResidencial.AutoSize = true;
            this.lblBairroResidencial.Location = new System.Drawing.Point(237, 411);
            this.lblBairroResidencial.Name = "lblBairroResidencial";
            this.lblBairroResidencial.Size = new System.Drawing.Size(34, 13);
            this.lblBairroResidencial.TabIndex = 56;
            this.lblBairroResidencial.Text = "Bairro";
            this.lblBairroResidencial.Visible = false;
            // 
            // lblComplementoResidencial
            // 
            this.lblComplementoResidencial.AutoSize = true;
            this.lblComplementoResidencial.Location = new System.Drawing.Point(21, 415);
            this.lblComplementoResidencial.Name = "lblComplementoResidencial";
            this.lblComplementoResidencial.Size = new System.Drawing.Size(71, 13);
            this.lblComplementoResidencial.TabIndex = 55;
            this.lblComplementoResidencial.Text = "Complemento";
            this.lblComplementoResidencial.Visible = false;
            // 
            // lblNumeroResidencial
            // 
            this.lblNumeroResidencial.AutoSize = true;
            this.lblNumeroResidencial.Location = new System.Drawing.Point(237, 384);
            this.lblNumeroResidencial.Name = "lblNumeroResidencial";
            this.lblNumeroResidencial.Size = new System.Drawing.Size(44, 13);
            this.lblNumeroResidencial.TabIndex = 54;
            this.lblNumeroResidencial.Text = "Número";
            this.lblNumeroResidencial.Visible = false;
            // 
            // lblLogradouroResidencial
            // 
            this.lblLogradouroResidencial.AutoSize = true;
            this.lblLogradouroResidencial.Location = new System.Drawing.Point(21, 384);
            this.lblLogradouroResidencial.Name = "lblLogradouroResidencial";
            this.lblLogradouroResidencial.Size = new System.Drawing.Size(61, 13);
            this.lblLogradouroResidencial.TabIndex = 53;
            this.lblLogradouroResidencial.Text = "Logradouro";
            this.lblLogradouroResidencial.Visible = false;
            // 
            // txtLogradouroResidencial
            // 
            this.txtLogradouroResidencial.Location = new System.Drawing.Point(98, 380);
            this.txtLogradouroResidencial.Name = "txtLogradouroResidencial";
            this.txtLogradouroResidencial.Size = new System.Drawing.Size(118, 20);
            this.txtLogradouroResidencial.TabIndex = 16;
            this.txtLogradouroResidencial.Visible = false;
            // 
            // txtNumeroResidencial
            // 
            this.txtNumeroResidencial.Location = new System.Drawing.Point(287, 381);
            this.txtNumeroResidencial.Name = "txtNumeroResidencial";
            this.txtNumeroResidencial.Size = new System.Drawing.Size(78, 20);
            this.txtNumeroResidencial.TabIndex = 17;
            this.txtNumeroResidencial.Visible = false;
            // 
            // txtComplementoResidencial
            // 
            this.txtComplementoResidencial.Location = new System.Drawing.Point(98, 408);
            this.txtComplementoResidencial.Name = "txtComplementoResidencial";
            this.txtComplementoResidencial.Size = new System.Drawing.Size(118, 20);
            this.txtComplementoResidencial.TabIndex = 18;
            this.txtComplementoResidencial.Visible = false;
            // 
            // txtBairroResidencial
            // 
            this.txtBairroResidencial.Location = new System.Drawing.Point(287, 408);
            this.txtBairroResidencial.Name = "txtBairroResidencial";
            this.txtBairroResidencial.Size = new System.Drawing.Size(118, 20);
            this.txtBairroResidencial.TabIndex = 19;
            this.txtBairroResidencial.Visible = false;
            // 
            // txtCepResidencial
            // 
            this.txtCepResidencial.Location = new System.Drawing.Point(58, 352);
            this.txtCepResidencial.Name = "txtCepResidencial";
            this.txtCepResidencial.Size = new System.Drawing.Size(118, 20);
            this.txtCepResidencial.TabIndex = 14;
            this.txtCepResidencial.Visible = false;
            this.txtCepResidencial.Leave += new System.EventHandler(this.txtCepResidencial_Leave);
            // 
            // lblCepResidencial
            // 
            this.lblCepResidencial.AutoSize = true;
            this.lblCepResidencial.Location = new System.Drawing.Point(21, 355);
            this.lblCepResidencial.Name = "lblCepResidencial";
            this.lblCepResidencial.Size = new System.Drawing.Size(28, 13);
            this.lblCepResidencial.TabIndex = 59;
            this.lblCepResidencial.Text = "CEP";
            this.lblCepResidencial.Visible = false;
            // 
            // btnAddListTel
            // 
            this.btnAddListTel.Location = new System.Drawing.Point(591, 76);
            this.btnAddListTel.Name = "btnAddListTel";
            this.btnAddListTel.Size = new System.Drawing.Size(29, 23);
            this.btnAddListTel.TabIndex = 7;
            this.btnAddListTel.Text = ">>";
            this.btnAddListTel.UseVisualStyleBackColor = true;
            this.btnAddListTel.Click += new System.EventHandler(this.btnAddListTel_Click);
            // 
            // btnExListTel
            // 
            this.btnExListTel.Location = new System.Drawing.Point(626, 76);
            this.btnExListTel.Name = "btnExListTel";
            this.btnExListTel.Size = new System.Drawing.Size(29, 23);
            this.btnExListTel.TabIndex = 8;
            this.btnExListTel.Text = "X";
            this.btnExListTel.UseVisualStyleBackColor = true;
            this.btnExListTel.Click += new System.EventHandler(this.btnExListTel_Click);
            // 
            // btnexListEmail
            // 
            this.btnexListEmail.Location = new System.Drawing.Point(626, 184);
            this.btnexListEmail.Name = "btnexListEmail";
            this.btnexListEmail.Size = new System.Drawing.Size(29, 23);
            this.btnexListEmail.TabIndex = 13;
            this.btnexListEmail.Text = "X";
            this.btnexListEmail.UseVisualStyleBackColor = true;
            this.btnexListEmail.Click += new System.EventHandler(this.btnexListEmail_Click);
            // 
            // btnAddListEmail
            // 
            this.btnAddListEmail.Location = new System.Drawing.Point(591, 184);
            this.btnAddListEmail.Name = "btnAddListEmail";
            this.btnAddListEmail.Size = new System.Drawing.Size(29, 23);
            this.btnAddListEmail.TabIndex = 12;
            this.btnAddListEmail.Text = ">>";
            this.btnAddListEmail.UseVisualStyleBackColor = true;
            this.btnAddListEmail.Click += new System.EventHandler(this.btnAddListEmail_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(369, 471);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(179, 57);
            this.btnCadastrar.TabIndex = 28;
            this.btnCadastrar.Text = "CADASTRAR";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtLocalidadeResidencial
            // 
            this.txtLocalidadeResidencial.Location = new System.Drawing.Point(335, 352);
            this.txtLocalidadeResidencial.Name = "txtLocalidadeResidencial";
            this.txtLocalidadeResidencial.Size = new System.Drawing.Size(94, 20);
            this.txtLocalidadeResidencial.TabIndex = 60;
            this.txtLocalidadeResidencial.Visible = false;
            // 
            // lblLocalidadeResidencial
            // 
            this.lblLocalidadeResidencial.AutoSize = true;
            this.lblLocalidadeResidencial.Location = new System.Drawing.Point(270, 355);
            this.lblLocalidadeResidencial.Name = "lblLocalidadeResidencial";
            this.lblLocalidadeResidencial.Size = new System.Drawing.Size(59, 13);
            this.lblLocalidadeResidencial.TabIndex = 61;
            this.lblLocalidadeResidencial.Text = "Localidade";
            this.lblLocalidadeResidencial.Visible = false;
            // 
            // chkResidencial
            // 
            this.chkResidencial.AutoSize = true;
            this.chkResidencial.Location = new System.Drawing.Point(364, 312);
            this.chkResidencial.Name = "chkResidencial";
            this.chkResidencial.Size = new System.Drawing.Size(102, 17);
            this.chkResidencial.TabIndex = 62;
            this.chkResidencial.Text = "Inserir endereço";
            this.chkResidencial.UseVisualStyleBackColor = true;
            this.chkResidencial.CheckedChanged += new System.EventHandler(this.chkResidencial_CheckedChanged);
            // 
            // chkEmpresa
            // 
            this.chkEmpresa.AutoSize = true;
            this.chkEmpresa.Location = new System.Drawing.Point(778, 312);
            this.chkEmpresa.Name = "chkEmpresa";
            this.chkEmpresa.Size = new System.Drawing.Size(97, 17);
            this.chkEmpresa.TabIndex = 63;
            this.chkEmpresa.Text = "Inserir empresa";
            this.chkEmpresa.UseVisualStyleBackColor = true;
            this.chkEmpresa.CheckedChanged += new System.EventHandler(this.chkEmpresa_CheckedChanged);
            // 
            // txtLocalidadeEmpresa
            // 
            this.txtLocalidadeEmpresa.Location = new System.Drawing.Point(840, 386);
            this.txtLocalidadeEmpresa.Name = "txtLocalidadeEmpresa";
            this.txtLocalidadeEmpresa.Size = new System.Drawing.Size(94, 20);
            this.txtLocalidadeEmpresa.TabIndex = 64;
            this.txtLocalidadeEmpresa.Visible = false;
            // 
            // lblLocalidadeEmpresa
            // 
            this.lblLocalidadeEmpresa.AutoSize = true;
            this.lblLocalidadeEmpresa.Location = new System.Drawing.Point(775, 393);
            this.lblLocalidadeEmpresa.Name = "lblLocalidadeEmpresa";
            this.lblLocalidadeEmpresa.Size = new System.Drawing.Size(59, 13);
            this.lblLocalidadeEmpresa.TabIndex = 65;
            this.lblLocalidadeEmpresa.Text = "Localidade";
            this.lblLocalidadeEmpresa.Visible = false;
            // 
            // Agendamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 540);
            this.Controls.Add(this.txtLocalidadeEmpresa);
            this.Controls.Add(this.lblLocalidadeEmpresa);
            this.Controls.Add(this.chkEmpresa);
            this.Controls.Add(this.chkResidencial);
            this.Controls.Add(this.txtLocalidadeResidencial);
            this.Controls.Add(this.lblLocalidadeResidencial);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnexListEmail);
            this.Controls.Add(this.btnAddListEmail);
            this.Controls.Add(this.btnExListTel);
            this.Controls.Add(this.btnAddListTel);
            this.Controls.Add(this.lblCepResidencial);
            this.Controls.Add(this.txtUFResidencial);
            this.Controls.Add(this.lblUFResidencial);
            this.Controls.Add(this.lblBairroResidencial);
            this.Controls.Add(this.lblComplementoResidencial);
            this.Controls.Add(this.lblNumeroResidencial);
            this.Controls.Add(this.lblLogradouroResidencial);
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
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.ListEmail);
            this.Controls.Add(this.txtTipoEmail);
            this.Controls.Add(this.cbxTipoEmail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listTelOpcional);
            this.Controls.Add(this.txtTipoTelOpcional);
            this.Controls.Add(this.cbxTipoTelOpcional);
            this.Controls.Add(this.txtTipoTelPrincipal);
            this.Controls.Add(this.cbxTipoTelPrincipal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNomeContato);
            this.Controls.Add(this.txtTelOpcional);
            this.Controls.Add(this.txtTelPrincipal);
            this.Name = "Agendamento";
            this.Text = "Agendamento";
            this.Load += new System.EventHandler(this.Agendamento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtTelPrincipal;
        private System.Windows.Forms.MaskedTextBox txtTelOpcional;
        private System.Windows.Forms.TextBox txtNomeContato;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxTipoTelPrincipal;
        private System.Windows.Forms.TextBox txtTipoTelPrincipal;
        private System.Windows.Forms.TextBox txtTipoTelOpcional;
        private System.Windows.Forms.ComboBox cbxTipoTelOpcional;
        private System.Windows.Forms.ListBox listTelOpcional;
        private System.Windows.Forms.ListBox ListEmail;
        private System.Windows.Forms.TextBox txtTipoEmail;
        private System.Windows.Forms.ComboBox cbxTipoEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
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
        private System.Windows.Forms.Label lblNomeEmpresa;
        private System.Windows.Forms.TextBox txtNomeEmpresa;
        private System.Windows.Forms.Label lblCargoEmpresa;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.TextBox txtUFResidencial;
        private System.Windows.Forms.Label lblUFResidencial;
        private System.Windows.Forms.Label lblBairroResidencial;
        private System.Windows.Forms.Label lblComplementoResidencial;
        private System.Windows.Forms.Label lblNumeroResidencial;
        private System.Windows.Forms.Label lblLogradouroResidencial;
        private System.Windows.Forms.TextBox txtLogradouroResidencial;
        private System.Windows.Forms.TextBox txtNumeroResidencial;
        private System.Windows.Forms.TextBox txtComplementoResidencial;
        private System.Windows.Forms.TextBox txtBairroResidencial;
        private System.Windows.Forms.TextBox txtCepResidencial;
        private System.Windows.Forms.Label lblCepResidencial;
        private System.Windows.Forms.Button btnAddListTel;
        private System.Windows.Forms.Button btnExListTel;
        private System.Windows.Forms.Button btnexListEmail;
        private System.Windows.Forms.Button btnAddListEmail;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtLocalidadeResidencial;
        private System.Windows.Forms.Label lblLocalidadeResidencial;
        private System.Windows.Forms.CheckBox chkResidencial;
        private System.Windows.Forms.CheckBox chkEmpresa;
        private System.Windows.Forms.TextBox txtLocalidadeEmpresa;
        private System.Windows.Forms.Label lblLocalidadeEmpresa;
    }
}

