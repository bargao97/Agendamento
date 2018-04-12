namespace Agendamento
{
    partial class CadastrarEmailOpcional
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
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTipoEmail = new System.Windows.Forms.TextBox();
            this.cbxTipoEmail = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(35, 89);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 26;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Email(opcional)";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(128, 57);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(206, 20);
            this.txtEmail.TabIndex = 23;
            // 
            // txtTipoEmail
            // 
            this.txtTipoEmail.Location = new System.Drawing.Point(234, 30);
            this.txtTipoEmail.Name = "txtTipoEmail";
            this.txtTipoEmail.Size = new System.Drawing.Size(100, 20);
            this.txtTipoEmail.TabIndex = 22;
            this.txtTipoEmail.Visible = false;
            // 
            // cbxTipoEmail
            // 
            this.cbxTipoEmail.FormattingEnabled = true;
            this.cbxTipoEmail.Location = new System.Drawing.Point(120, 30);
            this.cbxTipoEmail.Name = "cbxTipoEmail";
            this.cbxTipoEmail.Size = new System.Drawing.Size(100, 21);
            this.cbxTipoEmail.TabIndex = 21;
            this.cbxTipoEmail.SelectedIndexChanged += new System.EventHandler(this.cbxTipoEmail_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Tipo de Email";
            // 
            // CadastrarEmailOpcional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 145);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTipoEmail);
            this.Controls.Add(this.cbxTipoEmail);
            this.Controls.Add(this.label5);
            this.Name = "CadastrarEmailOpcional";
            this.Text = "CadastrarEmailOpcional";
            this.Load += new System.EventHandler(this.CadastrarEmailOpcional_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTipoEmail;
        private System.Windows.Forms.ComboBox cbxTipoEmail;
        private System.Windows.Forms.Label label5;
    }
}