using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Letter_App
{
    public partial class Home_Screen : Form
    {
        public Home_Screen()
        {
            InitializeComponent();
        }

        private void create_letters_button_Click(object sender, EventArgs e)
        {
            CustomDialog dlg = new CustomDialog();
            dlg.StartPosition = FormStartPosition.CenterScreen;
            dlg.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Exit_Confirm exit_Confirm = new Exit_Confirm
            {
                StartPosition = FormStartPosition.CenterScreen,
            };
            exit_Confirm.ShowDialog();
        }

        private void Home_Screen_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string formattedText = @"Denumire angajator: SC PENTA FLOOR SRL
Cod fiscal: 30626759
Nr. R.C.: J35/2151/2012
Adresa: loc. Ciacova, oras Ciacova, str. Ghiladului, nr. 1, jud. Timis.
Nr: / 

ACORD PENTRU SCHIMBARE ANGAJATOR CONFORM OUG NR. 143/28.10.2022

Subscrisa SC SC PENTA FLOOR SRL  SRL, număr de ordine în Registrul Comerțului J35/2151/2012,  CUI: 30626759, cu sediul în loc. Ciacova, oras Ciacova, str. Ghiladului, nr. 1, jud. Timis. reprezentată legal de MANENTI MARIA LOREDANA , în calitate de administrator si fost angajator al cetățeanului:
-	WARNAKULASURIYA SAMEERA SANJEEWA, cetățenie Sri Lanka, ns. 02.09.1993, în Sri Lanka, identificat cu pașaportul nr. N9075495, val. 13.10.2031;
Îmi exprim prin prezenta acordul in scris de a se angaja la un alt angajator.

                                                                    Administrator,";

            // Create a new PDF document
            Document document = new Document();

            // Open a Save File Dialog
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Save PDF file";
            sfd.Filter = "PDF files (*.pdf)|*.pdf";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                // Get the path to the selected folder
                string savePath = sfd.FileName;

                // Create a PdfWriter and add the document to it
                using (FileStream fs = new FileStream(savePath, FileMode.Create))
                {
                    PdfWriter writer = PdfWriter.GetInstance(document, fs);

                    // Open the document for writing
                    document.Open();

                    // Create a paragraph and add the formatted text to it
                    Paragraph paragraph = new Paragraph(formattedText);
                    document.Add(paragraph);

                    // Close the document
                    document.Close();
                }

                MessageBox.Show("PDF file saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
