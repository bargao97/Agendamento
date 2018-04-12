using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Agendamento.Database;

namespace Agendamento
{
    public partial class AlterarTelOpcional : Form
    {
        public AlterarTelOpcional()
        {
            InitializeComponent();
        }

        private void AlterarTelOpcional_Load(object sender, EventArgs e)
        {
            AGENDAMENTOEntities db = new AGENDAMENTOEntities();
            try
            {
                cbxTipoTel.Items.Add("Casa");
                cbxTipoTel.Items.Add("Trabalho");
                cbxTipoTel.Items.Add("Outros");

                var telefone = db.TELEFONE.Where(s => s.ID_TELEFONE == VerContatos.idTel).FirstOrDefault();
                if (telefone.TIPO_TEL != "Casa")
                {
                    cbxTipoTel.SelectedIndex = 0;
                }
                if (telefone.TIPO_TEL != "Trabalho")
                {
                    cbxTipoTel.SelectedIndex = 1;
                }
                if (telefone.TIPO_TEL != "Casa" && telefone.TIPO_TEL != "Trabalho")
                {
                    cbxTipoTel.SelectedIndex = 2;
                    txtTipoTel.Visible = true;
                    txtTipoTel.Text = telefone.TIPO_TEL;
                }
                txtTelefone.Text = telefone.TEL;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                db.Dispose();
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            AGENDAMENTOEntities db = new AGENDAMENTOEntities();
            try
            {
                var telefone = db.TELEFONE.Where(s => s.ID_TELEFONE == VerContatos.idTel).FirstOrDefault();
                if (cbxTipoTel.SelectedIndex == 2)
                {
                    telefone.TIPO_TEL= txtTipoTel.Text;
                }
                else
                {
                    telefone.TIPO_TEL = cbxTipoTel.SelectedItem.ToString();
                }
                telefone.TEL = txtTelefone.Text;
                db.SaveChanges();
                MessageBox.Show("telefone alterado com sucesso", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnApagar_Click(object sender, EventArgs e)
        {
            AGENDAMENTOEntities db = new AGENDAMENTOEntities();
            try
            {
                var telefone = db.TELEFONE.Where(s => s.ID_TELEFONE == VerContatos.idTel).FirstOrDefault();
                db.TELEFONE.Remove(telefone);
                db.SaveChanges();
                MessageBox.Show("Email apagado com sucesso", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
