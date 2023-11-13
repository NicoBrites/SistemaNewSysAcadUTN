using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace Logic
{
    public class PDF
    {
        public PDF() { }

        public void CrearPDF(string texto)
        {
            Document document = new Document();
            PdfWriter.GetInstance(document, new FileStream("Informe.pdf", FileMode.Create));
            document.Open();
            document.Add(new Paragraph(texto));
            document.Close();
        }
    }
}
