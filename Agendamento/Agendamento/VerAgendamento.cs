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
using ClosedXML.Excel;

namespace Agendamento
{
    public partial class VerAgendamento : Form
    {
        public VerAgendamento()
        {
            InitializeComponent();
        }

        private void VerAgendamento_Load(object sender, EventArgs e)
        {
            carregarGrid();
        }
        public static int idContato;
        private void gdvContatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            idContato = Convert.ToInt32(gdvContatos.Rows[e.RowIndex].Cells[0].Value);
            VerContatos vc = new VerContatos();
            vc.ShowDialog();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CadastroContato ca = new CadastroContato();
            ca.ShowDialog();
        }

        private void btnOrdemAlfa_Click(object sender, EventArgs e)
        {
            AGENDAMENTOEntities db = new AGENDAMENTOEntities();
            try
            {
                gdvContatos.DataSource = db.AGENDA.Where(s => s.FLAG_EXCLUIDO != "S").OrderBy(s => s.NOME).Select(s => new
                {
                    ID = s.ID_AGENDA,
                    Contato = s.NOME,
                    Telefone_principal = s.TEL_PRINCIPAL,
                    Logradouro = s.LOCALIDADE_RESIDENCIAL
                }).ToList();
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

        private void btnUltimosContatos_Click(object sender, EventArgs e)
        {
            AGENDAMENTOEntities db = new AGENDAMENTOEntities();
            try
            {
                gdvContatos.DataSource = db.AGENDA.Where(s => s.FLAG_EXCLUIDO != "S").OrderByDescending(s=>s.ID_AGENDA).Select(s => new
                {
                    ID = s.ID_AGENDA,
                    Contato = s.NOME,
                    Telefone_principal = s.TEL_PRINCIPAL,
                    Logradouro = s.LOCALIDADE_RESIDENCIAL
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
        public void carregarGrid()
        {
            AGENDAMENTOEntities db = new AGENDAMENTOEntities();
            try
            {
                gdvContatos.DataSource = db.AGENDA.Where(s=>s.FLAG_EXCLUIDO !="S").OrderBy(s => s.NOME).Select(s => new
                {
                    ID = s.ID_AGENDA,
                    Contato = s.NOME,
                    Telefone_principal = s.TEL_PRINCIPAL,
                    Logradouro = s.LOCALIDADE_RESIDENCIAL
                }).ToList();
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

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
                AGENDAMENTOEntities db = new AGENDAMENTOEntities();
            try
            {
                saveFileDialog1.InitialDirectory = "c:";
                saveFileDialog1.Title = "Contatos";
                saveFileDialog1.FileName = "";
                saveFileDialog1.Filter = "Excel (2007)|*.xlsx";
                if (saveFileDialog1.ShowDialog() != DialogResult.Cancel)
                {
                    var contatos = db.AGENDA.Where(s => s.FLAG_EXCLUIDO != "S").OrderBy(s => s.NOME).ToList();

                    Console.WriteLine("Gerando arquivo Excel...");

                    var wb = new XLWorkbook();
                    //Cria a Planilha com o Nome
                    var ws = wb.Worksheets.Add("CONTATOS DA AGENDA");
                    ws.Cell("A1").Value = "CONTATOS DA AGENDA";
                    var range = ws.Range("A1:T2");
                    range.Merge().Style.Font.SetBold().Font.FontSize = 33;
                    // Cabeçalhos do Relatório
                    ws.Cell("A3").Value = "ID NO SISTEMA";
                    ws.Cell("B3").Value = "NOME DO CONTATO";
                    ws.Cell("C3").Value = "TIPO DE TELEFONE PRINCIPAL";
                    ws.Cell("D3").Value = "TELEFONE PRINCIPAL";
                    ws.Cell("E3").Value = "CEP RESIDENCIAL";
                    ws.Cell("F3").Value = "UF RESIDENCIAL";
                    ws.Cell("G3").Value = "LOCALIDADE RESIDENCIAL";
                    ws.Cell("H3").Value = "LOGRADOURO RESIDENCIAL";
                    ws.Cell("I3").Value = "NUMERO RESIDENCIAL";
                    ws.Cell("J3").Value = "BAIRRO RESIDENCIAL";
                    ws.Cell("K3").Value = "NOME DA EMPRESA";
                    ws.Cell("L3").Value = "CARGO NA EMPRESA";
                    ws.Cell("M3").Value = "CEP EMPRESA";
                    ws.Cell("N3").Value = "UF EMPRESA";
                    ws.Cell("O3").Value = "LOCALIDADE EMPRESA";
                    ws.Cell("P3").Value = "LOGRADOURO EMPRESA";
                    ws.Cell("Q3").Value = "NUMERO EMPRESA";
                    ws.Cell("R3").Value = "BAIRRO EMPRESA";
                    ws.Cell("S3").Value = "TELEFONES OPCIONAIS";
                    ws.Cell("T3").Value = "EMAIS OPCIONAIS";

                    int linha = 4;
                    foreach (var c in contatos)
                    {
                        ws.Cell("A" + linha.ToString()).Value = c.ID_AGENDA.ToString();
                        ws.Cell("B" + linha.ToString()).Value = c.NOME.ToString();
                        ws.Cell("C" + linha.ToString()).Value = c.TIPO_TEL_PRINCIPAL.ToString();
                        ws.Cell("D" + linha.ToString()).Value = c.TEL_PRINCIPAL.ToString();
                        if (c.CEP_RESIDENCIAL != null) { ws.Cell("E" + linha.ToString()).Value = c.CEP_RESIDENCIAL.ToString(); }
                        if (c.UF_RESIDENCIAL != null) { ws.Cell("F" + linha.ToString()).Value = c.UF_RESIDENCIAL.ToString(); }
                        if (c.LOCALIDADE_RESIDENCIAL != null) { ws.Cell("G" + linha.ToString()).Value = c.LOCALIDADE_RESIDENCIAL.ToString(); }
                        if (c.LOGRADOURO_RESIDENCIAL != null) { ws.Cell("H" + linha.ToString()).Value = c.LOGRADOURO_RESIDENCIAL.ToString(); }
                        if (c.NUMERO_RESIDENCIAL != null) { ws.Cell("I" + linha.ToString()).Value = c.NUMERO_RESIDENCIAL.ToString(); }
                        if (c.BAIRRO_RESIDENCIAL != null) { ws.Cell("J" + linha.ToString()).Value = c.BAIRRO_RESIDENCIAL.ToString(); }
                        if (c.NOME_EMPRESA != null) { ws.Cell("K" + linha.ToString()).Value = c.NOME_EMPRESA.ToString(); }
                        if (c.CARGO_EMPRESA != null) { ws.Cell("L" + linha.ToString()).Value = c.CARGO_EMPRESA.ToString(); }
                        if (c.CEP_EMPRESA != null) { ws.Cell("M" + linha.ToString()).Value = c.CEP_EMPRESA.ToString(); }
                        if (c.UF_RESIDENCIAL != null) { ws.Cell("N" + linha.ToString()).Value = c.UF_RESIDENCIAL.ToString(); }
                        if (c.LOCALIDADE_EMPRESA != null) { ws.Cell("O" + linha.ToString()).Value = c.LOCALIDADE_EMPRESA.ToString(); }
                        if (c.LOGRADOURO_EMPRESA != null) { ws.Cell("P" + linha.ToString()).Value = c.LOGRADOURO_EMPRESA.ToString(); }
                        if (c.NUMERO_EMPRESA != null) { ws.Cell("Q" + linha.ToString()).Value = c.NUMERO_EMPRESA.ToString(); }
                        if (c.BAIRRO_EMPRESA != null) { ws.Cell("R" + linha.ToString()).Value = c.BAIRRO_EMPRESA.ToString(); }

                        string telefoneOpcional = "";
                        string emailOpcional = "";
                        var telOP = db.TELEFONE.Where(s => s.AGENDA_ID_AGENDA == c.ID_AGENDA).ToList();
                        foreach (var t in telOP)
                        {
                            if (telefoneOpcional == "")
                            {
                                telefoneOpcional = t.TIPO_TEL + ":" + t.TEL + "\n";
                            } else
                            {
                                telefoneOpcional = telefoneOpcional + t.TIPO_TEL + ":" + t.TEL + "\n";
                            }
                        }
                        var emOP = db.EMAIL.Where(s => s.AGENDA_ID_AGENDA == c.ID_AGENDA).ToList();
                        foreach (var em in emOP)
                        {
                            if (emailOpcional == "")
                            {
                                emailOpcional = em.TIPO_EMAIL + ":" + em.EMAIL1 + "\n";
                            }
                            else
                            {
                                emailOpcional = emailOpcional + em.TIPO_EMAIL + ":" + em.EMAIL1 + "\n";
                            }
                        }
                        if (telefoneOpcional != "") { ws.Cell("S" + linha.ToString()).Value = telefoneOpcional; }
                        if (emailOpcional != null) { ws.Cell("T" + linha.ToString()).Value = emailOpcional; }
                        linha++;
                    }
                    range.CreateTable();
                    wb.SaveAs(saveFileDialog1.FileName.ToString());
                    ws.Dispose();
                }
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
