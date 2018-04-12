using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Agendamento.Database;

namespace Agendamento
{
    public partial class CadastroContato : Form
    {
        public CadastroContato()
        {
            InitializeComponent();
        }
        //Ao carregar a pagina o form sera inserido os items da combobox
        private void Agendamento_Load(object sender, EventArgs e)
        {
            //Adiciona os tipos de Telefone na combobox cbxTipoTelPrincipal
            cbxTipoTelPrincipal.Items.Add("Casa");
            cbxTipoTelPrincipal.Items.Add("Trabalho");
            cbxTipoTelPrincipal.Items.Add("Outros");
            //Adiciona os tipos de Telefone na combobox cbxTipoTelOpicional
            cbxTipoTelOpcional.Items.Add("Casa");
            cbxTipoTelOpcional.Items.Add("Trabalho");
            cbxTipoTelOpcional.Items.Add("Outros");
            //Adiciona os tipos de Email na combobox cbxTipoEmail
            cbxTipoEmail.Items.Add("Casa");
            cbxTipoEmail.Items.Add("Trabalho");
            cbxTipoEmail.Items.Add("Outros");

        }
        //Ao selecionar a combobox ira verificar que tipo de contato é
        private void cbxTipoTelOpcional_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Caso a combobox for igual a outros aparecera um campo de texto para informar um texto sobre outros
            if (cbxTipoTelOpcional.SelectedIndex == 2)
            {
                txtTipoTelOpcional.Visible = true;
            }
            //caso for diferente de outros oculta novamente o campo de texto
            if (cbxTipoTelOpcional.SelectedIndex != 2)
            {
                txtTipoTelOpcional.Text = "";
                txtTipoTelOpcional.Visible = false;

            }
        }
        //Ao selecionar a combobox ira verificar que tipo de contato é
        private void cbxTipoTelPrincipal_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Caso a combobox for igual a outros aparecera um campo de texto para informar um texto sobre outros
            if (cbxTipoTelPrincipal.SelectedIndex == 2)
            {
                txtTipoTelPrincipal.Visible = true;
            }
            //caso for diferente de outros oculta novamente o campo de texto
            if (cbxTipoTelPrincipal.SelectedIndex != 2)
            {
                txtTipoTelPrincipal.Text = "";
                txtTipoTelPrincipal.Visible = false;

            }
        }
        //Ao selecionar a combobox ira verificar que tipo de contato é
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
        //Ira adicionar os telefones Opcionais na lista de telefones]
        private void btnAddListTel_Click(object sender, EventArgs e)
        {
            //Declara as variaveis
            string tipoTel = "";
            string tel = txtTelOpcional.Text;
            //Caso a combobox for igual a outros o tipo de telefone sera customizado
            if (cbxTipoTelOpcional.SelectedIndex == 2)
            {
                tipoTel = txtTipoTelOpcional.Text;
            }
            //caso for diferente de outros o tipo de telefone sera o tipo selecionado na combox
            if (cbxTipoTelOpcional.SelectedIndex != 2)
            {
                tipoTel = cbxTipoTelOpcional.SelectedItem.ToString();
            }
            listTelOpcional.Items.Add(tipoTel + ";" + tel);
        }
        //Ira apagar o item selecionado da lista de telefone opcional
        private void btnExListTel_Click(object sender, EventArgs e)
        {
            if(this.listTelOpcional.Items.Count > 0)
            {
                this.listTelOpcional.Items.Remove(this.listTelOpcional.SelectedItem);
            }
            else
            {
                MessageBox.Show("Adicione um item a lista", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //Ira adicionar os emails Opcionais na lista de emails
        private void btnAddListEmail_Click(object sender, EventArgs e)
        {
            //Declara as variaveis
            string tipoEmail = "";
            string email = txtEmail.Text;
            //Caso a combobox for igual a outros o tipo de telefone sera customizado
            if (cbxTipoEmail.SelectedIndex == 2)
            {
                tipoEmail = txtTipoEmail.Text;
            }
            //caso for diferente de outros o tipo de telefone sera o tipo selecionado na combox
            if (cbxTipoEmail.SelectedIndex != 2)
            {
                tipoEmail = cbxTipoEmail.SelectedItem.ToString();
            }
            ListEmail.Items.Add(tipoEmail + ";" + email);
        }
        //Ira apagar o item selecionado da lista de emails opcional
        private void btnexListEmail_Click(object sender, EventArgs e)
        {
            if (this.ListEmail.Items.Count > 0)
            {
                this.ListEmail.Items.Remove(this.ListEmail.SelectedItem);
            }
            else
            {
                MessageBox.Show("Adicione um item a lista de emails", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //Ao sair do campo txtCepResidencial irá verificar quantos caracteres possui o campo para fazer a busca do cep
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"ERRO",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtCepResidencial.Text = "";
            }
        }
        //Ao sair do campo txtCepEmpresairá verificar quantos caracteres possui o campo para fazer a busca do cep
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
        /*Função essa que ira verificar o cep atraves do portal https://viacep.com.br/
        e nessa função sera informado dois parametros, um que seria o cep para busca e outro que seria
        um id pra saber se o cep precisa ir para campo de endereço residencial ou de empresa 
        */
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
        //Ira verificar se a checkbox de dados residenciais esta ativa ou nao, caso ativa mostra os campos para preenchimento
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
        //Ira verificar se a checkbox de dados da empresa esta ativa ou nao, caso ativa mostra os campos para preenchimento
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
        //insere os dados no banco
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            AGENDAMENTOEntities db = new AGENDAMENTOEntities();
            try
            {
                AGENDA agen = new AGENDA();
                //Atribui em variaveis osc campo do nome de contato e o telefone principal
                string nomeContato = txtNomeContato.Text;
                string tipoTelPrincipal = "";
                if (cbxTipoTelPrincipal.SelectedIndex == 2)
                {
                    tipoTelPrincipal = txtTipoTelPrincipal.Text;
                }
                if (cbxTipoTelPrincipal.SelectedIndex != 2)
                {
                    tipoTelPrincipal = cbxTipoTelPrincipal.SelectedItem.ToString();
                }
                string telPrincipal = txtTelPrincipal.Text;

                //passa os obrigatorios para a tabela
                agen.NOME = nomeContato;
                agen.TEL_PRINCIPAL = telPrincipal;
                agen.TIPO_TEL_PRINCIPAL = tipoTelPrincipal;
               
                //Caso a checkbox de inserir dados de endereço residencial estiver selecionada sera incluido tambem no banco
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
                    agen.CEP_RESIDENCIAL = cepResidencial;
                    agen.UF_RESIDENCIAL = UFResidencial;
                    agen.LOCALIDADE_RESIDENCIAL = localidadeResidencial;
                    agen.LOGRADOURO_RESIDENCIAL = logradouroResidencial;
                    agen.NUMERO_RESIDENCIAL = numeroResidencial;
                    agen.COMPLEMENTO_RESIDENCIAL = complementoResidencial;
                    agen.BAIRRO_RESIDENCIAL = bairroResidencial;
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
                    agen.NOME_EMPRESA = nomeEmpresa;
                    agen.CARGO_EMPRESA = cargo;
                    agen.CEP_EMPRESA = cepEmpresa;
                    agen.UF_EMPRESA = UFEmpresa;
                    agen.LOCALIDADE_EMPRESA = localidadeEmpresa;
                    agen.LOGRADOURO_EMPRESA = logradouroEmpresa;
                    agen.NUMERO_EMPRESA = numeroEmpresa;
                    agen.COMPLEMENTO_EMPRESA = complementoEmpresa;
                    agen.BAIRRO_EMPRESA = bairroEmpresa;
                }
                //adciona na agenda
                db.AGENDA.Add(agen);
                db.SaveChanges();
                //busca o contato que foi cadastrado para relacionar o contato com a lista de telefones e emails opcionais
                var ContatoCadastrado = db.AGENDA.OrderByDescending(s=>s.ID_AGENDA).FirstOrDefault();

                //Cria variaveis list para atribuir todos os telefones e emails cadastrados nas listbox
                List<TELEFONE> telOp = new List<TELEFONE>();
                List<EMAIL> emailOp = new List<EMAIL>();

                if(listTelOpcional.Items.Count > 0|| ListEmail.Items.Count > 0)
                {
                    //se a lista de telefones Opcionais possui a quantidade de registros maior que 0 sera atribuido a lista
                    if (listTelOpcional.Items.Count > 0)
                    {
                        //percorre pela listbox e insere cada um no banco
                        foreach (var item in listTelOpcional.Items)
                        {
                            //Salva os dados do telefone na string
                            string teletipo = item.ToString();
                            //separa a string de acordo com a quantidade de char que possui 
                            string[] teletipoSep = teletipo.Split(new char[1] { ';' });
                            string tipoTel = teletipoSep[0];
                            string Tel = teletipoSep[1];
                            telOp.Add(new TELEFONE
                            {
                                AGENDA_ID_AGENDA = ContatoCadastrado.ID_AGENDA,
                                TIPO_TEL = tipoTel,
                                TEL = Tel
                            });
                        }
                        db.TELEFONE.AddRange(telOp);
                    }
                    //Caso se a lista com os emails for > 0 ira entrar no if
                    if (ListEmail.Items.Count > 0)
                    {
                        //percorre toda listBox para inserir na lista de emails
                        foreach (var item in ListEmail.Items)
                        {

                            string emailTipo = item.ToString();
                            string[] emailtipoSep = emailTipo.Split(new char[1] { ';' });
                            string tipoEmail = emailtipoSep[0];
                            string email = emailtipoSep[1];
                            //insere na lista o email
                            emailOp.Add(new EMAIL
                            {
                                AGENDA_ID_AGENDA = ContatoCadastrado.ID_AGENDA,
                                TIPO_EMAIL = tipoEmail,
                                EMAIL1 = email
                            });
                        }
                        //Adiciona todos os email na tabela de email
                        db.EMAIL.AddRange(emailOp);
                    }
                    //adiciona os telefones e emails opcionais no banco
                    db.SaveChanges();
                }
                MessageBox.Show("Cadastro Efetuado com sucesso", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception er)
            {
                MessageBox.Show(er.Message);
            }
            finally
            {
                
                db.Dispose();
            }
        }
    }
}
