using Agendamento.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agendamento
{
    public partial class CadastrarEmailOpcional : Form
    {
        public CadastrarEmailOpcional()
        {
            InitializeComponent();
        }
        private void CadastrarEmailOpcional_Load(object sender, EventArgs e)
        {
            cbxTipoEmail.Items.Add("Casa");
            cbxTipoEmail.Items.Add("Trabalho");
            cbxTipoEmail.Items.Add("Outros");

        }
        private void cbxTipoEmail_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Caso a combobox for igual a outros aparecera um campo de texto para informar um texto sobre outros
            if (cbxTipoEmail.SelectedIndex == 2)
            {
                txtTipoEmail.Visible = true;
            }
            //caso for diferente de outros oculta novamente o campo de texto
            if (cbxTipoEmail.SelectedIndex != 2)
            {
                txtTipoEmail.Text = "";
                txtTipoEmail.Visible = false;

            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            AGENDAMENTOEntities db = new AGENDAMENTOEntities();
            try
            {
                EMAIL email = new EMAIL();
                if (cbxTipoEmail.SelectedIndex == 2)
                {
                    email.TIPO_EMAIL = txtTipoEmail.Text;
                }
                else
                {
                    email.TIPO_EMAIL = cbxTipoEmail.SelectedItem.ToString();
                }
                email.EMAIL1 = txtEmail.Text;
                email.AGENDA_ID_AGENDA = VerAgendamento.idContato;
                db.EMAIL.Add(email);
                db.SaveChanges();
                MessageBox.Show("Email alterado com sucesso", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                db.Dispose();
            }
        }
    }
}
