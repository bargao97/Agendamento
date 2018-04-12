namespace Agendamento
{
    partial class CadastrarTelOpcional
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
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.btnACadastrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTipoTel = new System.Windows.Forms.TextBox();
            this.cbxTipoTel = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(108, 52);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(116, 20);
            this.txtTelefone.TabIndex = 35;
            // 
            // btnACadastrar
            // 
            this.btnACadastrar.Location = new System.Drawing.Point(56, 80);
            this.btnACadastrar.Name = "btnACadastrar";
            this.btnACadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnACadastrar.TabIndex = 33;
            this.btnACadastrar.Text = "Cadastrar";
            this.btnACadastrar.UseVisualStyleBackColor = true;
            this.btnACadastrar.Click += new System.EventHandler(this.btnACadastrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Telefone";
            // 
            // txtTipoTel
            // 
            this.txtTipoTel.Location = new System.Drawing.Point(255, 21);
            this.txtTipoTel.Name = "txtTipoTel";
            this.txtTipoTel.Size = new System.Drawing.Size(100, 20);
            this.txtTipoTel.TabIndex = 30;
            this.txtTipoTel.Visible = false;
            // 
            // cbxTipoTel
            // 
            this.cbxTipoTel.FormattingEnabled = true;
            this.cbxTipoTel.Location = new System.Drawing.Point(141, 21);
            this.cbxTipoTel.Name = "cbxTipoTel";
            this.cbxTipoTel.Size = new System.Drawing.Size(100, 21);
            this.cbxTipoTel.TabIndex = 29;
            this.cbxTipoTel.SelectedIndexChanged += new System.EventHandler(this.cbxTipoTel_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Tipo de Telelefone";
            // 
            // CadastrarTelOpcional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 114);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.btnACadastrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTipoTel);
            this.Controls.Add(this.cbxTipoTel);
            this.Controls.Add(this.label5);
            this.Name = "CadastrarTelOpcional";
            this.Text = "CadastrarTelOpcional";
            this.Load += new System.EventHandler(this.CadastrarTelOpcional_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.Button btnACadastrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTipoTel;
        private System.Windows.Forms.ComboBox cbxTipoTel;
        private System.Windows.Forms.Label label5;
    }
}