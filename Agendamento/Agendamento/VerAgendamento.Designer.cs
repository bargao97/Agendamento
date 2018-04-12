namespace Agendamento
{
    partial class VerAgendamento
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
            this.gdvContatos = new System.Windows.Forms.DataGridView();
            this.btnOrdemAlfa = new System.Windows.Forms.Button();
            this.btnUltimosContatos = new System.Windows.Forms.Button();
            this.btnRelatorio = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.gdvContatos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(210, 12);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(173, 57);
            this.btnCadastrar.TabIndex = 0;
            this.btnCadastrar.Text = "Cadastrar Agendamento";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // gdvContatos
            // 
            this.gdvContatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvContatos.Location = new System.Drawing.Point(42, 184);
            this.gdvContatos.Name = "gdvContatos";
            this.gdvContatos.Size = new System.Drawing.Size(747, 285);
            this.gdvContatos.TabIndex = 1;
            this.gdvContatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdvContatos_CellContentClick);
            // 
            // btnOrdemAlfa
            // 
            this.btnOrdemAlfa.Location = new System.Drawing.Point(42, 145);
            this.btnOrdemAlfa.Name = "btnOrdemAlfa";
            this.btnOrdemAlfa.Size = new System.Drawing.Size(216, 23);
            this.btnOrdemAlfa.TabIndex = 2;
            this.btnOrdemAlfa.Text = "Listagem em ordem alfabetica";
            this.btnOrdemAlfa.UseVisualStyleBackColor = true;
            this.btnOrdemAlfa.Click += new System.EventHandler(this.btnOrdemAlfa_Click);
            // 
            // btnUltimosContatos
            // 
            this.btnUltimosContatos.Location = new System.Drawing.Point(573, 145);
            this.btnUltimosContatos.Name = "btnUltimosContatos";
            this.btnUltimosContatos.Size = new System.Drawing.Size(216, 23);
            this.btnUltimosContatos.TabIndex = 3;
            this.btnUltimosContatos.Text = "Ultimos contatos Adicionados";
            this.btnUltimosContatos.UseVisualStyleBackColor = true;
            this.btnUltimosContatos.Click += new System.EventHandler(this.btnUltimosContatos_Click);
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.Location = new System.Drawing.Point(462, 12);
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(173, 57);
            this.btnRelatorio.TabIndex = 5;
            this.btnRelatorio.Text = "Relatorio de contatos";
            this.btnRelatorio.UseVisualStyleBackColor = true;
            this.btnRelatorio.Click += new System.EventHandler(this.btnRelatorio_Click);
            // 
            // VerAgendamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 560);
            this.Controls.Add(this.btnRelatorio);
            this.Controls.Add(this.btnUltimosContatos);
            this.Controls.Add(this.btnOrdemAlfa);
            this.Controls.Add(this.gdvContatos);
            this.Controls.Add(this.btnCadastrar);
            this.Name = "VerAgendamento";
            this.Text = "VerAgendamento";
            this.Load += new System.EventHandler(this.VerAgendamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdvContatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.DataGridView gdvContatos;
        private System.Windows.Forms.Button btnOrdemAlfa;
        private System.Windows.Forms.Button btnUltimosContatos;
        private System.Windows.Forms.Button btnRelatorio;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}