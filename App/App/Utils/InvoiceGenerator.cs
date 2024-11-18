using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Utils
{
    public static class InvoiceGenerator
    {
        public static MemoryStream GenerateInvoice(string fileName,string customerName, IEnumerable<dynamic> ZboziItems, IEnumerable<dynamic> AkceItems)
        {
            string invoiceNumber = fileName;

            MemoryStream stream = new MemoryStream();
            Document document = new Document(PageSize.A4);

            PdfWriter writer = PdfWriter.GetInstance(document, stream);
            writer.CloseStream = false;

            document.Open();

            document.Add(new Paragraph("FAKTURA", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18)));
            document.Add(new Paragraph($"Číslo faktury: {invoiceNumber}"));
            document.Add(new Paragraph($"Zákazník: {customerName}"));
            document.Add(new Paragraph($"Datum: {DateTime.Now.ToShortDateString()}"));
            document.Add(new Paragraph("\n"));
            document.Add(new Paragraph("Zbozi"));

            PdfPTable table1 = new PdfPTable(4);
            table1.AddCell("Popis");
            table1.AddCell("Počet");
            table1.AddCell("Cena/ks");
            table1.AddCell("Celkem");

            double total = 0;

            foreach (var item in ZboziItems)
            {
                table1.AddCell(item.Description);
                table1.AddCell(item.Quantity.ToString());
                table1.AddCell($"{item.Price:Kc}");
                double subtotal = item.Quantity * item.Price;
                table1.AddCell($"{subtotal:Kc}");
                total += subtotal;
            }

            document.Add(table1);
            if (AkceItems != null && AkceItems.Any()) {
                document.Add(new Paragraph("\n"));
                document.Add(new Paragraph("Akce"));
                PdfPTable table2 = new PdfPTable(3);
                table2.AddCell("Popis");
                table2.AddCell("Pocet osob");
                table2.AddCell("Celkem");

                foreach (var item in AkceItems)
                {
                    table2.AddCell(item.Description);
                    table2.AddCell(item.Quantity.ToString());
                    table2.AddCell("0 Kc");
                }

                document.Add(table2);
            }

            document.Add(new Paragraph($"\nCelkem k úhradě: {total:Kc}", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 14)));

            document.Close();

            stream.Position = 0;

            return stream;
        }

        public static string GenerateInvoiceNumber()
        {
            Random random = new Random();
            return $"INV-{DateTime.Now:yyyyMMdd}-{random.Next(1000, 9999)}";
        }
    }
}
