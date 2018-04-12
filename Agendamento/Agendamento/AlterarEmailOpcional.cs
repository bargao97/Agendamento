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
    public partial class AlterarEmailOpcional : Form
    {
        public AlterarEmailOpcional()
        {
            InitializeComponent();
        }

        private void AlterarEmailOpcional_Load(object sender, EventArgs e)
        {
            AGENDAMENTOEntities db = new AGENDAMENTOEntities();
            try
            {
                cbxTipoEmail.Items.Add("Casa");
                cbxTipoEmail.Items.Add("Trabalho");
                cbxTipoEmail.Items.Add("Outros");

                var email = db.EMAIL.Where(s => s.ID_EMAIL == VerContatos.idEmail).FirstOrDefault();
                if (email.TIPO_EMAIL != "Casa")
                {
                    cbxTipoEmail.SelectedIndex = 0;
                }
                if (email.TIPO_EMAIL != "Trabalho")
                {
                    cbxTipoEmail.SelectedIndex = 1;
                }
                if (email.TIPO_EMAIL != "Casa" && email.TIPO_EMAIL != "Trabalho")
                {
                    cbxTipoEmail.SelectedIndex = 2;
                    txtTipoEmail.Visible = true;
                    txtTipoEmail.Text = email.TIPO_EMAIL;
                }
                txtEmail.Text = email.EMAIL1;
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

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            AGENDAMENTOEntities db = new AGENDAMENTOEntities();
            try
            {
                var email = db.EMAIL.Where(s => s.ID_EMAIL == VerContatos.idEmail).FirstOrDefault();
                if (cbxTipoEmail.SelectedIndex == 2)
                {
                    email.TIPO_EMAIL = txtTipoEmail.Text;
                }
                else
                {
                    email.TIPO_EMAIL = cbxTipoEmail.SelectedItem.ToString();
                }
                email.EMAIL1 = txtEmail.Text;
                db.SaveChanges();
                MessageBox.Show("Email alterado com sucesso","SUCESSO",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Close();
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

        

        private void btnApagar_Click(object sender, EventArgs e)
        {
            AGENDAMENTOEntities db = new AGENDAMENTOEntities();
            try
            {
                var email = db.EMAIL.Where(s => s.ID_EMAIL == VerContatos.idEmail).FirstOrDefault();
                db.EMAIL.Remove(email);
                db.SaveChanges();
                MessageBox.Show("Email apagado com sucesso", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
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
    }
}
