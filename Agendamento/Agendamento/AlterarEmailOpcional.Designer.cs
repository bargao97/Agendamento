namespace Agendamento
{
    partial class AlterarEmailOpcional
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
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTipoEmail = new System.Windows.Forms.TextBox();
            this.cbxTipoEmail = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(119, 52);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(206, 20);
            this.txtEmail.TabIndex = 16;
            // 
            // txtTipoEmail
            // 
            this.txtTipoEmail.Location = new System.Drawing.Point(225, 25);
            this.txtTipoEmail.Name = "txtTipoEmail";
            this.txtTipoEmail.Size = new System.Drawing.Size(100, 20);
            this.txtTipoEmail.TabIndex = 15;
            this.txtTipoEmail.Visible = false;
            // 
            // cbxTipoEmail
            // 
            this.cbxTipoEmail.FormattingEnabled = true;
            this.cbxTipoEmail.Location = new System.Drawing.Point(111, 25);
            this.cbxTipoEmail.Name = "cbxTipoEmail";
            this.cbxTipoEmail.Size = new System.Drawing.Size(100, 21);
            this.cbxTipoEmail.TabIndex = 14;
            this.cbxTipoEmail.SelectedIndexChanged += new System.EventHandler(this.cbxTipoEmail_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Tipo de Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Email(opcional)";
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(26, 84);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 19;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.Location = new System.Drawing.Point(119, 84);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(75, 23);
            this.btnApagar.TabIndex = 20;
            this.btnApagar.Text = "Apagar Email";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // AlterarEmailOpcional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 119);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTipoEmail);
            this.Controls.Add(this.cbxTipoEmail);
            this.Controls.Add(this.label5);
            this.Name = "AlterarEmailOpcional";
            this.Text = "AlterarEmailOpcional";
            this.Load += new System.EventHandler(this.AlterarEmailOpcional_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTipoEmail;
        private System.Windows.Forms.ComboBox cbxTipoEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnApagar;
    }
}