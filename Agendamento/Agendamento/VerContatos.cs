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
using System.Xml.Linq;
using System.Net;

namespace Agendamento
{
    public partial class VerContatos : Form
    {
        public VerContatos()
        {
            InitializeComponent();
        }

        private void VerContatos_Load(object sender, EventArgs e)
        {
            AGENDAMENTOEntities db = new AGENDAMENTOEntities();
            try
            {
                //Adiciona os tipos de Telefone na combobox cbxTipoTelPrincipal
                cbxTipoTelPrincipal.Items.Add("Casa");
                cbxTipoTelPrincipal.Items.Add("Trabalho");
                cbxTipoTelPrincipal.Items.Add("Outros");
                
                //Busca o Contato no banco
                var contato= db.AGENDA.Where(s => s.ID_AGENDA == VerAgendamento.idContato).FirstOrDefault();

                //Insere os dados nos campos
                txtNomeContato.Text = contato.NOME;

                if (contato.TIPO_TEL_PRINCIPAL != "Casa")
                {
                    cbxTipoTelPrincipal.SelectedIndex = 0;
                }
                if(contato.TIPO_TEL_PRINCIPAL != "Trabalho")
                {
                    cbxTipoTelPrincipal.SelectedIndex = 1;
                }
                if (contato.TIPO_TEL_PRINCIPAL != "Casa" || contato.TIPO_TEL_PRINCIPAL != "Trabalho")
                {
                    cbxTipoTelPrincipal.SelectedIndex = 2;
                    txtTipoTelPrincipal.Visible = true;
                    txtTipoTelPrincipal.Text = contato.TIPO_TEL_PRINCIPAL;
                }
                txtTelPrincipal.Text = contato.TEL_PRINCIPAL;
                if(contato.CEP_RESIDENCIAL != null)
                {
                    chkResidencial.Checked = true;
                    txtCepResidencial.Text = contato.CEP_RESIDENCIAL;
                    txtUFResidencial.Text = contato.UF_RESIDENCIAL;
                    txtLocalidadeResidencial.Text = contato.LOCALIDADE_RESIDENCIAL;
                    txtLogradouroResidencial.Text = contato.LOGRADOURO_RESIDENCIAL;
                    txtNumeroResidencial.Text = contato.NUMERO_RESIDENCIAL;
                    txtComplementoResidencial.Text = contato.COMPLEMENTO_RESIDENCIAL;
                    txtBairroResidencial.Text = contato.BAIRRO_RESIDENCIAL;
                }
                if(contato.NOME_EMPRESA != null || contato.CEP_EMPRESA != null)
                {
                    chkEmpresa.Checked = true;
                    txtNomeEmpresa.Text = contato.NOME_EMPRESA;
                    txtCargo.Text = contato.CARGO_EMPRESA;
                    txtCepEmpresa.Text = contato.CEP_EMPRESA;
                    txtUFEmpresa.Text = contato.UF_EMPRESA;
                    txtLocalidadeEmpresa.Text = contato.LOCALIDADE_EMPRESA;
                    txtLogradouroEmpresa.Text = contato.LOGRADOURO_EMPRESA;
                    txtNumeroEmpresa.Text = contato.NUMERO_EMPRESA;
                    txtComplementoEmpresa.Text = contato.COMPLEMENTO_EMPRESA;
                    txtBairroEmpresa.Text = contato.BAIRRO_EMPRESA;
                }
                gdvEmail.DataSource = db.EMAIL.Where(s => s.AGENDA_ID_AGENDA == contato.ID_AGENDA).Select(s => new
                {
                    ID = s.ID_EMAIL,
                    TIPO=  s.TIPO_EMAIL,
                    EMAIL = s.EMAIL1
                }).ToList();
                gdvTelefone.DataSource = db.TELEFONE.Where(s => s.AGENDA_ID_AGENDA == contato.ID_AGENDA).Select(s => new
                {
                    ID = s.ID_TELEFONE,
                    TIPO = s.TIPO_TEL,
                    EMAIL = s.TEL
                }).ToList();
            }
            catch(Exception ex)
            {

            }
            finally
            {
                db.Dispose();
            }
        }

        private void chkResidencial_CheckedChanged(object sender, EventArgs e)
        {
            if (chkResidencial.Checked)
            {
                lblCepResidencial.Visible = true;
                txtCepResidencial.Visible = true;
                lblUFResidencial.Visible = true;
                txtUFResidencial.Visible = true;
                lblLocalidadeResidencial.Visible = true;
                txtLocalidadeResidencial.Visible = true;
                lblLogradouroResidencial.Visible = true;
                txtLogradouroResidencial.Visible = true;
                lblNumeroResidencial.Visible = true;
                txtNumeroResidencial.Visible = true;
                lblComplementoResidencial.Visible = true;
                txtComplementoResidencial.Visible = true;
                lblBairroResidencial.Visible = true;
                txtBairroResidencial.Visible = true;
            }
            else
            {
                lblCepResidencial.Visible = false;
                txtCepResidencial.Visible = false;
                lblUFResidencial.Visible = false;
                txtUFResidencial.Visible = false;
                lblLocalidadeResidencial.Visible = false;
                txtLocalidadeResidencial.Visible = false;
                lblLogradouroResidencial.Visible = false;
                txtLogradouroResidencial.Visible = false;
                lblNumeroResidencial.Visible = false;
                txtNumeroResidencial.Visible = false;
                lblComplementoResidencial.Visible = false;
                txtComplementoResidencial.Visible = false;
                lblBairroResidencial.Visible = false;
                txtBairroResidencial.Visible = false;
            }
        }

        private void chkEmpresa_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEmpresa.Checked)
            {
                lblNomeEmpresa.Visible = true;
                txtNomeEmpresa.Visible = true;
                lblCargoEmpresa.Visible = true;
                txtCargo.Visible = true;
                lblCepEmpresa.Visible = true;
                txtCepEmpresa.Visible = true;
                lblUFEmpresa.Visible = true;
                txtUFEmpresa.Visible = true;
                lblLocalidadeEmpresa.Visible = true;
                txtLocalidadeEmpresa.Visible = true;
                lblLogradouroEmpresa.Visible = true;
                txtLogradouroEmpresa.Visible = true;
                lblNumeroEmpresa.Visible = true;
                txtNumeroEmpresa.Visible = true;
                lblComplementoEmpresa.Visible = true;
                txtComplementoEmpresa.Visible = true;
                lblBairroEmpresa.Visible = true;
                txtBairroEmpresa.Visible = true;
            }
            else
            {
                lblNomeEmpresa.Visible = false;
                txtNomeEmpresa.Visible = false;
                lblCargoEmpresa.Visible = false;
                txtCargo.Visible = false;
                lblCepEmpresa.Visible = false;
                txtCepEmpresa.Visible = false;
                lblUFEmpresa.Visible = false;
                txtUFEmpresa.Visible = false;
                lblLocalidadeEmpresa.Visible = false;
                txtLocalidadeEmpresa.Visible = false;
                lblLogradouroEmpresa.Visible = false;
                txtLogradouroEmpresa.Visible = false;
                lblNumeroEmpresa.Visible = false;
                txtNumeroEmpresa.Visible = false;
                lblComplementoEmpresa.Visible = false;
                txtComplementoEmpresa.Visible = false;
                lblBairroEmpresa.Visible = false;
                txtBairroEmpresa.Visible = false;
            }
        }

        public static int idTel;
        private void gdvTelefone_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            idTel = Convert.ToInt32(gdvTelefone.Rows[e.RowIndex].Cells[0].Value);
            AlterarTelOpcional at = new AlterarTelOpcional();
            at.ShowDialog();
        }
        public static int idEmail;
        private void gdvEmail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            idEmail = Convert.ToInt32(gdvEmail.Rows[e.RowIndex].Cells[0].Value);
            AlterarEmailOpcional ae = new AlterarEmailOpcional();
            ae.ShowDialog();
        }
        private void btnAddTel_Click(object sender, EventArgs e)
        {
            CadastrarTelOpcional ct = new CadastrarTelOpcional();
            ct.ShowDialog();
        }
        private void buscaCep(string CEP, int idResiEmp)
        {
            try
            {
                //cria a variavel BuscaCep para verificar no webService se o CEP existe
                XDocument Buscacep = new XDocument();
                //Busca o CEP no Webservice
                Buscacep = XDocument.Load("https://viacep.com.br/ws/" + CEP + "/xml/");
                //Busca todos os elementos que sao descendentes da TAG xmlcep da busca encontrada
                var xmlcep = Buscacep.Descendants("xmlcep").FirstOrDefault();
                //Caso for buscar para o endereço residencial será insetrido nos campos de texto referente ao endereço residencial
                if (idResiEmp == 1)
                {
                    txtCepResidencial.Text = xmlcep.Element("cep").Value;
                    txtLogradouroResidencial.Text = xmlcep.Element("logradouro").Value;
                    txtComplementoResidencial.Text = xmlcep.Element("complemento").Value;
                    txtUFResidencial.Text = xmlcep.Element("uf").Value;
                    txtBairroResidencial.Text = xmlcep.Element("bairro").Value;
                    txtLocalidadeResidencial.Text = xmlcep.Element("localidade").Value;
                }
                //Caso for buscar para o endereço da empresa será insetrido nos campos de texto referente ao endereço da empresa
                if (idResiEmp == 2)
                {
                    txtCepEmpresa.Text = xmlcep.Element("cep").Value;
                    txtLogradouroEmpresa.Text = xmlcep.Element("logradouro").Value;
                    txtComplementoEmpresa.Text = xmlcep.Element("complemento").Value;
                    txtUFEmpresa.Text = xmlcep.Element("uf").Value;
                    txtBairroEmpresa.Text = xmlcep.Element("bairro").Value;
                    txtLocalidadeEmpresa.Text = xmlcep.Element("localidade").Value;
                }

            }
            //Caso der erro de busca o catch ira para cá
            catch (WebException wx)
            {
                MessageBox.Show(wx.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtCepResidencial_Leave(object sender, EventArgs e)
        {
            try
            {
                //Passa o campo do Cep para a variavel
                string CEP = txtCepResidencial.Text;
                //Caso o cep contenha a quantidade de caracteres exigida entra dentro do if
                if (CEP.Count() == 8)
                {
                    buscaCep(CEP, 1);
                }
                //Caso não possua a quantidade de caracteres,nao ira ser feito a busca
                else
                {
                    MessageBox.Show("Quantidade de caracteres do Cep e maior ou menor que a quantidade exigida,digite novamente", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCepResidencial.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCepResidencial.Text = "";
            }
        }

        private void txtCepEmpresa_Leave(object sender, EventArgs e)
        {
            try
            {
                //Passa o campo do Cep para a variavel
                string CEP = txtCepEmpresa.Text;
                //Caso o cep contenha a quantidade de caracteres exigida entra dentro do if
                if (CEP.Count() == 8)
                {
                    buscaCep(CEP, 2);
                }
                //Caso não possua a quantidade de caracteres,nao ira ser feito a busca
                else
                {
                    MessageBox.Show("Quantidade de caracteres do Cep e maior ou menor que a quantidade exigida,digite novamente", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCepEmpresa.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCepEmpresa.Text = "";
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            AGENDAMENTOEntities db = new AGENDAMENTOEntities();
            try
            {
                var contato = db.AGENDA.Where(s => s.ID_AGENDA == VerAgendamento.idContato).FirstOrDefault();
                contato.NOME = txtNomeContato.Text;

                string tipoTelPrincipal = "";
                if (cbxTipoTelPrincipal.SelectedIndex == 2)
                {
                    tipoTelPrincipal = txtTipoTelPrincipal.Text;
                }
                if (cbxTipoTelPrincipal.SelectedIndex != 2)
                {
                    tipoTelPrincipal = cbxTipoTelPrincipal.SelectedItem.ToString();
                }               
                contato.TIPO_TEL_PRINCIPAL = tipoTelPrincipal;
                contato.TEL_PRINCIPAL = txtTelPrincipal.Text;
                if (chkResidencial.Checked)
                {
                    //passa todos os campos de texto para as variaveis
                    string cepResidencial = txtCepResidencial.Text;
                    string UFResidencial = txtUFResidencial.Text;
                    string localidadeResidencial = txtLocalidadeResidencial.Text;
                    string logradouroResidencial = txtLogradouroResidencial.Text;
                    string numeroResidencial = txtNumeroResidencial.Text;
                    string complementoResidencial = txtComplementoResidencial.Text;
                    string bairroResidencial = txtBairroResidencial.Text;

                    //insere os dados na tabela
                    contato.CEP_RESIDENCIAL = cepResidencial;
                    contato.UF_RESIDENCIAL = UFResidencial;
                    contato.LOCALIDADE_RESIDENCIAL = localidadeResidencial;
                    contato.LOGRADOURO_RESIDENCIAL = logradouroResidencial;
                    contato.NUMERO_RESIDENCIAL = numeroResidencial;
                    contato.COMPLEMENTO_RESIDENCIAL = complementoResidencial;
                    contato.BAIRRO_RESIDENCIAL = bairroResidencial;
                }
                else
                {
                    //passa todos os campos de texto para as variaveis
                    string cepResidencial = null;
                    string UFResidencial = null;
                    string localidadeResidencial = null;
                    string logradouroResidencial = null;
                    string numeroResidencial = null;
                    string complementoResidencial = null;
                    string bairroResidencial = null;

                    //insere os dados na tabela
                    contato.CEP_RESIDENCIAL = cepResidencial;
                    contato.UF_RESIDENCIAL = UFResidencial;
                    contato.LOCALIDADE_RESIDENCIAL = localidadeResidencial;
                    contato.LOGRADOURO_RESIDENCIAL = logradouroResidencial;
                    contato.NUMERO_RESIDENCIAL = numeroResidencial;
                    contato.COMPLEMENTO_RESIDENCIAL = complementoResidencial;
                    contato.BAIRRO_RESIDENCIAL = bairroResidencial;
                }
            
                //Caso a checkbox de inserir dados de endereço da empresa estiver selecionada sera incluido tambem no banco
                if (chkEmpresa.Checked)
                {
                    //passa todos os campos de texto para as variaveis
                    string nomeEmpresa = txtNomeEmpresa.Text;
                    string cargo = txtCargo.Text;
                    string cepEmpresa = txtCepEmpresa.Text;
                    string UFEmpresa = txtUFEmpresa.Text;
                    string localidadeEmpresa = txtLocalidadeEmpresa.Text;
                    string logradouroEmpresa = txtLogradouroEmpresa.Text;
                    string numeroEmpresa = txtNumeroEmpresa.Text;
                    string complementoEmpresa = txtComplementoEmpresa.Text;
                    string bairroEmpresa = txtBairroEmpresa.Text;

                    //insere os dados na tabela
                    contato.NOME_EMPRESA = nomeEmpresa;
                    contato.CARGO_EMPRESA = cargo;
                    contato.CEP_EMPRESA = cepEmpresa;
                    contato.UF_EMPRESA = UFEmpresa;
                    contato.LOCALIDADE_EMPRESA = localidadeEmpresa;
                    contato.LOGRADOURO_EMPRESA = logradouroEmpresa;
                    contato.NUMERO_EMPRESA = numeroEmpresa;
                    contato.COMPLEMENTO_EMPRESA = complementoEmpresa;
                    contato.BAIRRO_EMPRESA = bairroEmpresa;
                }
                else
                {
                    //passa todos os campos de texto para as variaveis
                    string nomeEmpresa = null;
                    string cargo = null;
                    string cepEmpresa = null;
                    string UFEmpresa = null;
                    string localidadeEmpresa = null;
                    string logradouroEmpresa = null;
                    string numeroEmpresa = null;
                    string complementoEmpresa = null;
                    string bairroEmpresa = null;

                    //insere os dados na tabela
                    contato.NOME_EMPRESA = nomeEmpresa;
                    contato.CARGO_EMPRESA = cargo;
                    contato.CEP_EMPRESA = cepEmpresa;
                    contato.UF_EMPRESA = UFEmpresa;
                    contato.LOCALIDADE_EMPRESA = localidadeEmpresa;
                    contato.LOGRADOURO_EMPRESA = logradouroEmpresa;
                    contato.NUMERO_EMPRESA = numeroEmpresa;
                    contato.COMPLEMENTO_EMPRESA = complementoEmpresa;
                    contato.BAIRRO_EMPRESA = bairroEmpresa;
                }
                db.SaveChanges();
                MessageBox.Show("Contato Alterado com sucesso", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                DialogResult deletar = MessageBox.Show("Deseja apagar esse contato", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (deletar == DialogResult.Yes)
                {
                    var contato = db.AGENDA.Where(s => s.ID_AGENDA == VerAgendamento.idContato).FirstOrDefault();
                    contato.FLAG_EXCLUIDO = "S";
                    db.SaveChanges();
                    MessageBox.Show("Contato Excluido com sucesso", "SUCESSO", MessageBoxButtons.OK,MessageBoxIcon.Information);

                    VerAgendamento va = new VerAgendamento();
                    va.carregarGrid();
                    this.Close();
                }
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

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            AGENDAMENTOEntities db = new AGENDAMENTOEntities();
            try
            {
                gdvEmail.DataSource = db.EMAIL.Where(s => s.AGENDA_ID_AGENDA == VerAgendamento.idContato).Select(s => new
                {
                    ID = s.ID_EMAIL,
                    TIPO = s.TIPO_EMAIL,
                    EMAIL = s.EMAIL1
                }).ToList();
                gdvTelefone.DataSource = db.TELEFONE.Where(s => s.AGENDA_ID_AGENDA == VerAgendamento.idContato).Select(s => new
                {
                    ID = s.ID_TELEFONE,
                    TIPO = s.TIPO_TEL,
                    EMAIL = s.TEL
                }).ToList();
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

        private void btnAddEmail_Click(object sender, EventArgs e)
        {
            CadastrarEmailOpcional ce = new CadastrarEmailOpcional();
            ce.ShowDialog();
        }
    }
}
