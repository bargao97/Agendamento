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
    public partial class CadastrarTelOpcional : Form
    {
        public CadastrarTelOpcional()
        {
            InitializeComponent();
        }

        private void CadastrarTelOpcional_Load(object sender, EventArgs e)
        {
            cbxTipoTel.Items.Add("Casa");
            cbxTipoTel.Items.Add("Trabalho");
            cbxTipoTel.Items.Add("Outros");
        }

        private void cbxTipoTel_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Caso a combobox for igual a outros aparecera um campo de texto para informar um texto sobre outros
            if (cbxTipoTel.SelectedIndex == 2)
            {
                txtTipoTel.Visible = true;
            }
            //caso for diferente de outros oculta novamente o campo de texto
            if (cbxTipoTel.SelectedIndex != 2)
            {
                txtTipoTel.Text = "";
                txtTipoTel.Visible = false;

            }
        }

        private void btnACadastrar_Click(object sender, EventArgs e)
        {
            AGENDAMENTOEntities db = new AGENDAMENTOEntities();
            try
            {
                TELEFONE telefone = new TELEFONE();
                if (cbxTipoTel.SelectedIndex == 2)
                {
                    telefone.TIPO_TEL = txtTipoTel.Text;
                }
                else
                {
                    telefone.TIPO_TEL = cbxTipoTel.SelectedItem.ToString();
                }
                telefone.AGENDA_ID_AGENDA = VerAgendamento.idContato;
                telefone.TEL = txtTelefone.Text;
                db.TELEFONE.Add(telefone);
                db.SaveChanges();
                MessageBox.Show("telefone cadastrado com sucesso", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
