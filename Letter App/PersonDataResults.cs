using System.Data;
using System.Text.RegularExpressions;
using Xceed.Words.NET;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Wordprocessing;
using DocumentFormat.OpenXml.ExtendedProperties;
using Word = Microsoft.Office.Interop.Word;
using Microsoft.Office.Interop.Word;
using System.Threading.Tasks;


namespace Letter_App
{
    public partial class PersonDataResults : Form
    {
        private List<Person> persons;
        // private Template template;
        private int numberofPeople;
        List<Template> templateArray;
        string templatepath;
        string templateName;

        public PersonDataResults()
        {
            InitializeComponent();

        }

        public PersonDataResults(List<Person> p, Template t, int numberofPeople)
        {
            InitializeComponent();
            this.persons = p;
            // this.template = t;
            this.numberofPeople = numberofPeople;
            templateArray = new List<Template>();
            templatepath = string.Empty;
            templateName = string.Empty;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void PersonDataResults_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = persons;

            checkBox2.Checked = true;

            //-------------------------------ENTER ALL TEMPLATES HERE-------------------------------------------------




            //-------------------------------SELECT COLUMN--------------------------------------------------------------


            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                // Access the checkbox cell in the "SelectColumn" column
                DataGridViewCheckBoxCell checkBox = row.Cells["Select"] as DataGridViewCheckBoxCell;

                // Set the value of the checkbox cell to true
                checkBox.Value = true;
            }




        }




        //---------------------------------------TEST CODE FOR BUTTONS---------------------------------------------------
/*
        private void Button_Testing(object sender, EventArgs e)
        {
            Async_Method();
        }
        private void Async_Method()
        {

            int count = 0;

            List<Person> selectedPersons = new List<Person>();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                DataGridViewCheckBoxCell checkBox = row.Cells["Select"] as DataGridViewCheckBoxCell;
                if (checkBox.Value != null && (bool)checkBox.Value)
                {
                    // If the checkbox is checked, include this Person object in the selection
                    Person person = (Person)row.DataBoundItem;
                    selectedPersons.Add(person);
                }
            }


            if (templatepath == string.Empty)
            {
                MessageBox.Show($"Please Select a template first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            // Ask the user for the destination folder
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            folderDialog.Description = "Select a folder to save the Word files";

            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFolder = folderDialog.SelectedPath;
                count = 0;

                // Open the Word document outside the loop
                using (var wordDocument = WordprocessingDocument.Open(templatepath, false))
                {
                    if (checkBox1.Checked)
                    {
                        // Create a new Word document based on the original template
                        string savePath = Path.Combine(selectedFolder, $"{templateName} {DateTime.Now} ({selectedPersons.Count} people).docx");
                        File.Copy(templatepath, savePath);

                        // Open the new document for modification
                        using (var newWordDocument = WordprocessingDocument.Open(savePath, true))
                        {
                            // Find and replace the content in the document
                            var body = newWordDocument.MainDocumentPart.Document.Body;
                            var paragraphs = body.Descendants<DocumentFormat.OpenXml.Wordprocessing.Paragraph>().ToList();

                            var person = persons.First();

                            var placeholderValues = new Dictionary<string, string>
                                {
                                    {"{1}", string.Join(" ", persons.Select(pers => $"{pers.Name} {pers.SurName}, "))},
                                    {"{2}", string.Empty},
                                    {"{3}", person.PassportNo},
                                    {"{3'}", person.PassportValidUntil},
                                    {"{4}", person.BornAt},
                                    {"{5}", person.Citizenship},
                                    {"{5'}", person.ResidentPermitNo},
                                    {"{5''}", person.RPValidUntil},
                                    {"{6}", person.CompanyName},
                                    {"{7}", person.ONRC},
                                    {"{8}", person.CUI},
                                    {"{9}", person.FirmAddress},
                                    {"{10}", person.RepresentsByName},
                                    {"{10'}", person.RepresentsBySurname},
                                    {"{10''}", person.Passport_IDNumber},
                                    {"{10'''}", person.PassportIDValidUntil},
                                    {"{11}", person.Profession},
                                    {"{12}", person.Salary},
                                    {"{13}", person.PlacetoWork},
                                    {"{14}", person.AccomodationAddress},
                                    {"{15}", person.CORNumber},
                                    {"{16}", person.Orgamigram},
                                    {"{17}", person.OccupiedByRomanianCitizen},
                                    {"{18}", person.OccupiedByImmigrationCitizen},
                                    {"{19}", person.JobsVacancies},
                                    {"{20}", person.AJOFMDate},
                                    {"{21}", person.AJOFMCity},
                                    {"{22}", person.NumberOfAJOFMPaper},
                                    {"{23}", person.DateofAJOFMPaper},
                                };

                            foreach (var paragraph in paragraphs)
                            {
                                foreach (var text in paragraph.Descendants<Text>())
                                {
                                    // Replace placeholders with specific details
                                    foreach (var placeholder in placeholderValues)
                                    {
                                        text.Text = text.Text.Replace(placeholder.Key, placeholder.Value);
                                    }
                                }
                            }

                            count++;
                        } //    end new document
                          // Convert Word document to PDF
                        ConvertToPdfAsync(savePath, selectedFolder);



                    }
                    else
                    {
                        foreach (Person person in selectedPersons)
                        {
                            // Create a new Word document based on the original template
                            string savePath = Path.Combine(selectedFolder, $"{person.Name} {person.SurName} ({person.PassportNo}).docx");
                            File.Copy(templatepath, savePath);

                            // Open the new document for modification
                            using (var newWordDocument = WordprocessingDocument.Open(savePath, true))
                            {
                                // Find and replace the content in the document
                                var body = newWordDocument.MainDocumentPart.Document.Body;
                                var paragraphs = body.Descendants<DocumentFormat.OpenXml.Wordprocessing.Paragraph>().ToList();

                                var placeholderValues = new Dictionary<string, string>
                                {
                                    {"{1}", person.Name},
                                    {"{2}", person.SurName},
                                    {"{3}", person.PassportNo},
                                    {"{3'}", person.PassportValidUntil},
                                    {"{4}", person.BornAt},
                                    {"{5}", person.Citizenship},
                                    {"{5'}", person.ResidentPermitNo},
                                    {"{5''}", person.RPValidUntil},
                                    {"{6}", person.CompanyName},
                                    {"{7}", person.ONRC},
                                    {"{8}", person.CUI},
                                    {"{9}", person.FirmAddress},
                                    {"{10}", person.RepresentsByName},
                                    {"{10'}", person.RepresentsBySurname},
                                    {"{10''}", person.Passport_IDNumber},
                                    {"{10'''}", person.PassportIDValidUntil},
                                    {"{11}", person.Profession},
                                    {"{12}", person.Salary},
                                    {"{13}", person.PlacetoWork},
                                    {"{14}", person.AccomodationAddress},
                                    {"{15}", person.CORNumber},
                                    {"{16}", person.Orgamigram},
                                    {"{17}", person.OccupiedByRomanianCitizen},
                                    {"{18}", person.OccupiedByImmigrationCitizen},
                                    {"{19}", person.JobsVacancies},
                                    {"{20}", person.AJOFMDate},
                                    {"{21}", person.AJOFMCity},
                                    {"{22}", person.NumberOfAJOFMPaper},
                                    {"{23}", person.DateofAJOFMPaper},
                                };

                                foreach (var paragraph in paragraphs)
                                {
                                    foreach (var text in paragraph.Descendants<Text>())
                                    {
                                        // Replace placeholders with specific details
                                        foreach (var placeholder in placeholderValues)
                                        {
                                            text.Text = text.Text.Replace(placeholder.Key, placeholder.Value);
                                        }
                                    }
                                }

                                count++;
                                // Convert Word document to PDF
                                ConvertToPdfAsync(savePath, selectedFolder);


                            } //    end new document


                        }   // end foreach loop

                    }   // end else

                    MessageBox.Show($"Word file saved successfully.\n\nTotal Files Saved: {count}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }


        static  void ConvertToPdfAsync(string wordFilePath, string outputFolder)
        {
            System.Threading.Tasks.Task.Run(() => ConvertToPdf(wordFilePath, outputFolder));
        }


*/




        //----------------------------------------SAVE AS WORD--------------------------------------------------------------------------

        private void button3_Click(object sender, EventArgs e)
        {
            int count = 0;

            List<Person> selectedPersons = new List<Person>();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                DataGridViewCheckBoxCell checkBox = row.Cells["Select"] as DataGridViewCheckBoxCell;
                if (checkBox.Value != null && (bool)checkBox.Value)
                {
                    // If the checkbox is checked, include this Person object in the selection
                    Person person = (Person)row.DataBoundItem;
                    selectedPersons.Add(person);
                }
            }


            if (templatepath == string.Empty)
            {
                MessageBox.Show($"Please Select a template first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            // Ask the user for the destination folder
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            folderDialog.Description = "Select a folder to save the Word files";

            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFolder = folderDialog.SelectedPath;
                count = 0;

                // Open the Word document outside the loop
                using (var wordDocument = WordprocessingDocument.Open(templatepath, false))
                {
                    if (checkBox1.Checked)
                    {
                        // Create a new Word document based on the original template
                        string savePath = Path.Combine(selectedFolder, $"{templateName} {DateTime.Now.ToString("dd-MM-yyyy")} ({selectedPersons.Count} people).docx");
                        File.Copy(templatepath, savePath);

                        // Open the new document for modification
                        using (var newWordDocument = WordprocessingDocument.Open(savePath, true))
                        {
                            // Find and replace the content in the document
                            var body = newWordDocument.MainDocumentPart.Document.Body;
                            var paragraphs = body.Descendants<DocumentFormat.OpenXml.Wordprocessing.Paragraph>().ToList();

                            var person = persons.First();

                            var fullNameList = persons.Select(pers => $"{pers.Name} {pers.SurName}");
                            var result = string.Join(" ", fullNameList.Take(fullNameList.Count() - 1)) +
                                (fullNameList.Count() > 1 ? $" {fullNameList.Last()}" : "");


                            var placeholderValues = new Dictionary<string, string>
                                {
                                    {"{1}", result},
                                    {"{2}", string.Empty},
                                    {"{3}", person.PassportNo},
                                    {"{3'}", person.PassportValidUntil},
                                    {"{4}", person.BornAt},
                                    {"{5}", person.Citizenship},
                                    {"{5'}", person.ResidentPermitNo},
                                    {"{5''}", person.RPValidUntil},
                                    {"{6}", person.CompanyName},
                                    {"{7}", person.ONRC},
                                    {"{8}", person.CUI},
                                    {"{9}", person.FirmAddress},
                                    {"{10}", person.RepresentsByName},
                                    {"{10'}", person.RepresentsBySurname},
                                    {"{10''}", person.Passport_IDNumber},
                                    {"{10'''}", person.PassportIDValidUntil},
                                    {"{11}", person.Profession},
                                    {"{12}", person.Salary},
                                    {"{13}", person.PlacetoWork},
                                    {"{14}", person.AccomodationAddress},
                                    {"{15}", person.CORNumber},
                                    {"{16}", person.Orgamigram},
                                    {"{17}", person.OccupiedByRomanianCitizen},
                                    {"{18}", person.OccupiedByImmigrationCitizen},
                                    {"{19}", person.JobsVacancies},
                                    {"{20}", person.AJOFMDate},
                                    {"{21}", person.AJOFMCity},
                                    {"{22}", person.NumberOfAJOFMPaper},
                                    {"{23}", person.DateofAJOFMPaper},
                                };

                            foreach (var paragraph in paragraphs)
                            {
                                foreach (var text in paragraph.Descendants<Text>())
                                {
                                    // Replace placeholders with specific details
                                    foreach (var placeholder in placeholderValues)
                                    {
                                        text.Text = text.Text.Replace(placeholder.Key, placeholder.Value);
                                    }
                                }
                            }

                            count++;
                        } //    end new document

                    }
                    else
                    {
                        foreach (Person person in selectedPersons)
                        {
                            // Create a new Word document based on the original template
                            string savePath = Path.Combine(selectedFolder, $"{person.Name} {person.SurName} ({person.PassportNo}).docx");
                            File.Copy(templatepath, savePath);

                            // Open the new document for modification
                            using (var newWordDocument = WordprocessingDocument.Open(savePath, true))
                            {
                                // Find and replace the content in the document
                                var body = newWordDocument.MainDocumentPart.Document.Body;
                                var paragraphs = body.Descendants<DocumentFormat.OpenXml.Wordprocessing.Paragraph>().ToList();

                                var placeholderValues = new Dictionary<string, string>
                                {
                                    {"{1}", person.Name},
                                    {"{2}", person.SurName},
                                    {"{3}", person.PassportNo},
                                    {"{3'}", person.PassportValidUntil},
                                    {"{4}", person.BornAt},
                                    {"{5}", person.Citizenship},
                                    {"{5'}", person.ResidentPermitNo},
                                    {"{5''}", person.RPValidUntil},
                                    {"{6}", person.CompanyName},
                                    {"{7}", person.ONRC},
                                    {"{8}", person.CUI},
                                    {"{9}", person.FirmAddress},
                                    {"{10}", person.RepresentsByName},
                                    {"{10'}", person.RepresentsBySurname},
                                    {"{10''}", person.Passport_IDNumber},
                                    {"{10'''}", person.PassportIDValidUntil},
                                    {"{11}", person.Profession},
                                    {"{12}", person.Salary},
                                    {"{13}", person.PlacetoWork},
                                    {"{14}", person.AccomodationAddress},
                                    {"{15}", person.CORNumber},
                                    {"{16}", person.Orgamigram},
                                    {"{17}", person.OccupiedByRomanianCitizen},
                                    {"{18}", person.OccupiedByImmigrationCitizen},
                                    {"{19}", person.JobsVacancies},
                                    {"{20}", person.AJOFMDate},
                                    {"{21}", person.AJOFMCity},
                                    {"{22}", person.NumberOfAJOFMPaper},
                                    {"{23}", person.DateofAJOFMPaper},
                                };

                                foreach (var paragraph in paragraphs)
                                {
                                    foreach (var text in paragraph.Descendants<Text>())
                                    {
                                        // Replace placeholders with specific details
                                        foreach (var placeholder in placeholderValues)
                                        {
                                            text.Text = text.Text.Replace(placeholder.Key, placeholder.Value);
                                        }
                                    }
                                }

                                count++;
                            } //    end new document

                        }   // end foreach loop

                    }   // end else

                    MessageBox.Show($"Word file saved successfully.\n\nTotal Files Saved: {count}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }




        //------------------------------------------SAVE AS PDF--------------------------------------------------------






        private void button1_Click(object sender, EventArgs e)
        {

            int count = 0;

            List<Person> selectedPersons = new List<Person>();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                DataGridViewCheckBoxCell checkBox = row.Cells["Select"] as DataGridViewCheckBoxCell;
                if (checkBox.Value != null && (bool)checkBox.Value)
                {
                    // If the checkbox is checked, include this Person object in the selection
                    Person person = (Person)row.DataBoundItem;
                    selectedPersons.Add(person);
                }
            }


            if (templatepath == string.Empty)
            {
                MessageBox.Show($"Please Select a template first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            // Ask the user for the destination folder
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            folderDialog.Description = "Select a folder to save the Word files";

            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFolder = folderDialog.SelectedPath;
                count = 0;

                // Open the Word document outside the loop
                using (var wordDocument = WordprocessingDocument.Open(templatepath, false))
                {
                    if (checkBox1.Checked)
                    {
                        // Create a new Word document based on the original template
                        string savePath = Path.Combine(selectedFolder, $"{templateName} {DateTime.Now.ToString("dd-MM-yyyy")} ({selectedPersons.Count} people).docx");
                        File.Copy(templatepath, savePath);

                        // Open the new document for modification
                        using (var newWordDocument = WordprocessingDocument.Open(savePath, true))
                        {
                            // Find and replace the content in the document
                            var body = newWordDocument.MainDocumentPart.Document.Body;
                            var paragraphs = body.Descendants<DocumentFormat.OpenXml.Wordprocessing.Paragraph>().ToList();

                            var person = persons.First();

                            var fullNameList = persons.Select(pers => $"{pers.Name} {pers.SurName}");
                            var result = string.Join(" ", fullNameList.Take(fullNameList.Count() - 1)) +
                                (fullNameList.Count() > 1 ? $" {fullNameList.Last()}" : "");


                            var placeholderValues = new Dictionary<string, string>
                                {
                                    {"{1}", result},
                                    {"{2}", string.Empty},
                                    {"{3}", person.PassportNo},
                                    {"{3'}", person.PassportValidUntil},
                                    {"{4}", person.BornAt},
                                    {"{5}", person.Citizenship},
                                    {"{5'}", person.ResidentPermitNo},
                                    {"{5''}", person.RPValidUntil},
                                    {"{6}", person.CompanyName},
                                    {"{7}", person.ONRC},
                                    {"{8}", person.CUI},
                                    {"{9}", person.FirmAddress},
                                    {"{10}", person.RepresentsByName},
                                    {"{10'}", person.RepresentsBySurname},
                                    {"{10''}", person.Passport_IDNumber},
                                    {"{10'''}", person.PassportIDValidUntil},
                                    {"{11}", person.Profession},
                                    {"{12}", person.Salary},
                                    {"{13}", person.PlacetoWork},
                                    {"{14}", person.AccomodationAddress},
                                    {"{15}", person.CORNumber},
                                    {"{16}", person.Orgamigram},
                                    {"{17}", person.OccupiedByRomanianCitizen},
                                    {"{18}", person.OccupiedByImmigrationCitizen},
                                    {"{19}", person.JobsVacancies},
                                    {"{20}", person.AJOFMDate},
                                    {"{21}", person.AJOFMCity},
                                    {"{22}", person.NumberOfAJOFMPaper},
                                    {"{23}", person.DateofAJOFMPaper},
                                };

                            foreach (var paragraph in paragraphs)
                            {
                                foreach (var text in paragraph.Descendants<Text>())
                                {
                                    // Replace placeholders with specific details
                                    foreach (var placeholder in placeholderValues)
                                    {
                                        text.Text = text.Text.Replace(placeholder.Key, placeholder.Value);
                                    }
                                }
                            }

                            count++;
                        } //    end new document
                          // Convert Word document to PDF
                        ConvertToPdf(savePath, selectedFolder);


                        // Delete the generated Word file
                        //File.Delete(savePath);

                    }
                    else
                    {
                        foreach (Person person in selectedPersons)
                        {
                            // Create a new Word document based on the original template
                            string savePath = Path.Combine(selectedFolder, $"{person.Name} {person.SurName} ({person.PassportNo}).docx");
                            File.Copy(templatepath, savePath);

                            // Open the new document for modification
                            using (var newWordDocument = WordprocessingDocument.Open(savePath, true))
                            {
                                // Find and replace the content in the document
                                var body = newWordDocument.MainDocumentPart.Document.Body;
                                var paragraphs = body.Descendants<DocumentFormat.OpenXml.Wordprocessing.Paragraph>().ToList();

                                var placeholderValues = new Dictionary<string, string>
                                {
                                    {"{1}", person.Name},
                                    {"{2}", person.SurName},
                                    {"{3}", person.PassportNo},
                                    {"{3'}", person.PassportValidUntil},
                                    {"{4}", person.BornAt},
                                    {"{5}", person.Citizenship},
                                    {"{5'}", person.ResidentPermitNo},
                                    {"{5''}", person.RPValidUntil},
                                    {"{6}", person.CompanyName},
                                    {"{7}", person.ONRC},
                                    {"{8}", person.CUI},
                                    {"{9}", person.FirmAddress},
                                    {"{10}", person.RepresentsByName},
                                    {"{10'}", person.RepresentsBySurname},
                                    {"{10''}", person.Passport_IDNumber},
                                    {"{10'''}", person.PassportIDValidUntil},
                                    {"{11}", person.Profession},
                                    {"{12}", person.Salary},
                                    {"{13}", person.PlacetoWork},
                                    {"{14}", person.AccomodationAddress},
                                    {"{15}", person.CORNumber},
                                    {"{16}", person.Orgamigram},
                                    {"{17}", person.OccupiedByRomanianCitizen},
                                    {"{18}", person.OccupiedByImmigrationCitizen},
                                    {"{19}", person.JobsVacancies},
                                    {"{20}", person.AJOFMDate},
                                    {"{21}", person.AJOFMCity},
                                    {"{22}", person.NumberOfAJOFMPaper},
                                    {"{23}", person.DateofAJOFMPaper},
                                };

                                foreach (var paragraph in paragraphs)
                                {
                                    foreach (var text in paragraph.Descendants<Text>())
                                    {
                                        // Replace placeholders with specific details
                                        foreach (var placeholder in placeholderValues)
                                        {
                                            text.Text = text.Text.Replace(placeholder.Key, placeholder.Value);
                                        }
                                    }
                                }

                                count++;
                                // Convert Word document to PDF
                                ConvertToPdf(savePath, selectedFolder);

                                // Delete the generated Word file
                                //File.Delete(savePath);
                            } //    end new document


                        }   // end foreach loop

                    }   // end else

                    MessageBox.Show($"Word file saved successfully.\n\nTotal Files Saved: {count}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }



        static void ConvertToPdf(string wordFilePath, string outputFolder)
        {
            Word.Application wordApp = new Word.Application();
            try
            {
                object missing = System.Reflection.Missing.Value;
                object filePath = wordFilePath;
                object savePath = Path.Combine(outputFolder, $"{Path.GetFileNameWithoutExtension(wordFilePath)}.pdf");

                Word.Document wordDoc = wordApp.Documents.Open(ref filePath, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing);

                // Save as PDF
                wordDoc.ExportAsFixedFormat((string)savePath, WdExportFormat.wdExportFormatPDF);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error converting to PDF: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                wordApp.Quit();
            }
        }


        //-----------------------------------------------------------------------------------------------------------------------

        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }



        //-------------------------------------SELECT ALL BUTTON-----------------------------------------------------------------
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    // Access the checkbox cell in the "SelectColumn" column
                    DataGridViewCheckBoxCell checkBox = row.Cells["Select"] as DataGridViewCheckBoxCell;

                    // Set the value of the checkbox cell to true
                    checkBox.Value = true;
                }
            }
            else
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    // Access the checkbox cell in the "SelectColumn" column
                    DataGridViewCheckBoxCell checkBox = row.Cells["Select"] as DataGridViewCheckBoxCell;

                    // Set the value of the checkbox cell to true
                    checkBox.Value = false;
                }
            }
        }



        //----------------------------------SELECT TEMPLATE BUTTON------------------------------------------------


        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Word Documents|*.docx";
            openFileDialog.Title = "Select a Word Document as Template";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                templatepath = openFileDialog.FileName;
                templateName = Path.GetFileNameWithoutExtension(templatepath);

                // You can use templateFilePath and templateFileName as needed
                label2.Text = templateName;
            }
        }
    }
}
