using Desafio02.Classes;
using System.Data;
using System.Threading;

using System.IO;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Kernel.Geom;
using iText.Layout.Element;

namespace Desafio02
{
    public partial class menu : Form
    {
        Thread nt;
        public menu()
        {
            InitializeComponent();
        }

        private void btn_cadastrarNotaFiscal_Click(object sender, EventArgs e)
        {
       
            NotaFiscal nf = new NotaFiscal(int.Parse(txt_notaFiscal_idCliente.Text), int.Parse(txt_notaFiscal_idProduto.Text), txt_quantidade.Text, txt_valor.Text);

            bool sucesso = nf.cadastrarNotaFiscal();
            if (sucesso = true)
            {
                MessageBox.Show("Salvo com sucesso!", "Atenção");
            }
            else
            {
                MessageBox.Show("Erro ao salvar", "Atenção");
            }



            var arquivo = @"C:\Users\eric_\OneDrive\Área de Trabalho\nota.pdf";

            using (PdfWriter wPdf = new PdfWriter(arquivo, new WriterProperties().SetPdfVersion(PdfVersion.PDF_2_0)))
            {
                NotaFiscal notaf = new NotaFiscal(int.Parse(txt_notaFiscal_idCliente.Text), int.Parse(txt_notaFiscal_idProduto.Text), txt_quantidade.Text, txt_valor.Text);

                var pdfDocument = new PdfDocument(wPdf);

                var document = new Document(pdfDocument, PageSize.A4);
                document.Add(new Paragraph("O Cliente com ID " + notaf.notaFiscal_idCliente + " comprou o produto com ID " + notaf.notaFiscal_idProduto + " com a quantidade de " + notaf.quantidade + " e seu valor total = " + notaf.valorTotal));

                pdfDocument.Close();



            }

        }

        private void formCliente(object? obj)
        {
            Application.Run(new form_cCliente());
        }

        private void btn_formCliente_Click_1(object sender, EventArgs e)
        {
            this.Close();
            nt = new Thread(formCliente);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void formFornecedor(object? obj)
        {
            Application.Run(new form_cFornecedor());
        }
        private void btn_formFornecedor_Click(object sender, EventArgs e)
        {
            this.Close();
            nt = new Thread(formFornecedor);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void formProduto(object? obj)
        {
            Application.Run(new CProduto());
        }

        private void btn_cProduto_Click(object sender, EventArgs e)
        {
            this.Close();
            nt = new Thread(formProduto);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }
    }
}