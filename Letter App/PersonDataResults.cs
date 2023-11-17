using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.qrcode;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xceed.Document.NET;
using Xceed.Words.NET;

namespace Letter_App
{
    public partial class PersonDataResults : Form
    {
        private List<Person> persons;
        // private Template template;
        private int numberofPeople;
        List<Template> templateArray;

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



            int template_number = 2;



             


            Template temp0 = new Template();
            temp0.Name = "Acord Angajator";
            //temp0.Content = "<p style='margin-top:0cm;margin-right:0cm;margin-bottom:10.0pt;margin-left:0cm;line-height:115%;font-size:15px;font-family:\"Calibri\",sans-serif;text-align:justify;'><span style='font-family:\"Palatino Linotype\",serif;'>Denumire angajator:<strong>&nbsp;</strong></span><span style='font-family:\"Palatino Linotype\",serif;'><strong>{0}&nbsp;</strong></span><span style='font-family:\"Palatino Linotype\",serif;'>&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;</span></p>\r\n<p style='margin-top:0cm;margin-right:0cm;margin-bottom:10.0pt;margin-left:0cm;line-height:115%;font-size:15px;font-family:\"Calibri\",sans-serif;text-align:justify;'><span style='font-family:\"Palatino Linotype\",serif;'>Cod fiscal:&nbsp;</span><span style='font-family:\"Palatino Linotype\",serif;'><strong>{1}</strong></span><strong><span style='font-family:\"Palatino Linotype\",serif;'>&nbsp;</span></strong></p>\r\n<p style='margin-top:0cm;margin-right:0cm;margin-bottom:10.0pt;margin-left:0cm;line-height:115%;font-size:15px;font-family:\"Calibri\",sans-serif;text-align:justify;'><span style='font-family:\"Palatino Linotype\",serif;'>Nr. R.C.:&nbsp;</span><span style='font-family:\"Palatino Linotype\",serif;'><strong>{2}</strong></span></p>\r\n<p style='margin-top:0cm;margin-right:0cm;margin-bottom:10.0pt;margin-left:0cm;line-height:115%;font-size:15px;font-family:\"Calibri\",sans-serif;text-align:justify;'><span style='font-family:\"Palatino Linotype\",serif;'>Adresa:&nbsp;</span><strong><span style='font-family:\"Palatino Linotype\",serif;'>{3}</span></strong></p>\r\n<p style='margin-top:0cm;margin-right:0cm;margin-bottom:10.0pt;margin-left:0cm;line-height:normal;font-size:15px;font-family:\"Calibri\",sans-serif;'><strong><span style='font-size:16px;font-family:\"Palatino Linotype\",serif;'>Nr: &nbsp; &nbsp; &nbsp;/&nbsp;</span></strong></p>\r\n<p style='margin-top:0cm;margin-right:0cm;margin-bottom:10.0pt;margin-left:0cm;line-height:normal;font-size:15px;font-family:\"Calibri\",sans-serif;'><span style='font-size:16px;font-family:\"Palatino Linotype\",serif;'>&nbsp;</span></p>\r\n<p style='margin-top:0cm;margin-right:0cm;margin-bottom:10.0pt;margin-left:0cm;line-height:normal;font-size:15px;font-family:\"Calibri\",sans-serif;'><span style='font-size:16px;font-family:\"Palatino Linotype\",serif;'>&nbsp;</span></p>\r\n<p style='margin-top:0cm;margin-right:0cm;margin-bottom:10.0pt;margin-left:0cm;line-height:normal;font-size:15px;font-family:\"Calibri\",sans-serif;text-align:center;'><strong><span style='font-size:16px;font-family:\"Palatino Linotype\",serif;'>ACORD PENTRU SCHIMBARE ANGAJATOR CONFORM OUG NR. 143/28.10.2022</span></strong></p>\r\n<p style='margin-top:0cm;margin-right:0cm;margin-bottom:10.0pt;margin-left:0cm;line-height:normal;font-size:15px;font-family:\"Calibri\",sans-serif;'><span style='font-size:16px;font-family:\"Palatino Linotype\",serif;'>&nbsp;</span></p>\r\n<p style='margin-top:0cm;margin-right:0cm;margin-bottom:10.0pt;margin-left:0cm;line-height:150%;font-size:15px;font-family:\"Calibri\",sans-serif;text-align:justify;'><span style='font-size:16px;line-height:150%;font-family:\"Palatino Linotype\",serif;'>&nbsp; &nbsp; &nbsp; &nbsp; &nbsp;Subscrisa&nbsp;</span><span style='font-family:\"Palatino Linotype\",serif;'><strong>{4}</strong></span><span style='font-family:\"Palatino Linotype\",serif;'>, număr de ordine &icirc;n Registrul Comerțului {5}, &nbsp;CUI: {6}, cu sediul &icirc;n&nbsp;</span><span style='font-family:\"Palatino Linotype\",serif;'>{7}</span><span style='font-family:\"Palatino Linotype\",serif;'>&nbsp;</span><span style='font-family:\"Palatino Linotype\",serif;'>reprezentată legal de <strong>{8}</strong>,&nbsp;</span><span style='font-size:16px;line-height:150%;font-family:\"Palatino Linotype\",serif;'>&icirc;n calitate de administrator si fost angajator al cetățeanului:</span></p>\r\n<div style='margin-top:0cm;margin-right:0cm;margin-bottom:10.0pt;margin-left:0cm;line-height:115%;font-size:15px;font-family:\"Calibri\",sans-serif;'>\r\n    <ul style=\"margin-bottom:0cm;list-style-type: undefined;margin-left:44px;\">\r\n        <li style='margin-top:0cm;margin-right:0cm;margin-bottom:10.0pt;margin-left:0cm;line-height:115%;font-size:15px;font-family:\"Calibri\",sans-serif;'><strong><span style='font-family:\"Palatino Linotype\",serif;'>{9},&nbsp;</span></strong><span style='font-family:\"Palatino Linotype\",serif;'>cetățenie {10}, ns. {11}, &icirc;n {12}, identificat cu pașaportul nr. {13}, val. {14};</span></li>\r\n    </ul>\r\n</div>\r\n<p style='margin-top:0cm;margin-right:0cm;margin-bottom:10.0pt;margin-left:0cm;line-height:150%;font-size:15px;font-family:\"Calibri\",sans-serif;text-align:justify;'><span style='font-size:16px;line-height:150%;font-family:\"Palatino Linotype\",serif;'>&Icirc;mi exprim prin prezenta acordul in scris de a se angaja la un alt angajator.&nbsp;</span></p>\r\n<p style='margin-top:0cm;margin-right:0cm;margin-bottom:10.0pt;margin-left:0cm;line-height:150%;font-size:15px;font-family:\"Calibri\",sans-serif;text-align:justify;'><span style='font-size:16px;line-height:150%;font-family:\"Palatino Linotype\",serif;'>&nbsp;</span></p>\r\n<p style='margin-top:0cm;margin-right:0cm;margin-bottom:10.0pt;margin-left:0cm;line-height:150%;font-size:15px;font-family:\"Calibri\",sans-serif;text-align:justify;'><span style='font-size:16px;line-height:150%;font-family:\"Palatino Linotype\",serif;'>&nbsp;</span></p>\r\n<p style='margin-top:0cm;margin-right:0cm;margin-bottom:10.0pt;margin-left:0cm;line-height:150%;font-size:15px;font-family:\"Calibri\",sans-serif;text-align:justify;'><strong><span style='font-size:16px;line-height:150%;font-family:\"Palatino Linotype\",serif;'>&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;Administrator,</span></strong></p>";
            temp0.Content = @"**Denumire angajator:** {0}
**Cod fiscal:** {1}
**Nr. R.C.:** {2}
**Adresa:** {3}
**Nr:**      /


**ACORD PENTRU SCHIMBARE ANGAJATOR CONFORM OUG NR. 143/28.10.2022**


**Subscrisa {4}, număr de ordine în Registrul Comerțului {5}, CUI: {6}, cu sediul în {7} reprezentată legal de {8}, în calitate de administrator si fost angajator al cetățeanului:**


-     {9}, cetățenie {10}, ns. {11}, în {12}, identificat cu pașaportul nr. {13}, val. {14};


**Îmi exprim prin prezenta acordul in scris de a se angaja la un alt angajator.**


                                                                                                        **Administrator,**
";
            templateArray.Add(temp0);

            Template temp1 = new Template();
            temp1.Name = "Scrisoare de garantie pt ambasada";
            //temp1.Content = "<p style='margin-top:0cm;margin-right:0cm;margin-bottom:10.0pt;margin-left:0cm;line-height:115%;font-size:15px;font-family:\"Calibri\",sans-serif;text-align:justify;'><strong><span style='font-family:\"Palatino Linotype\",serif;'>{0}</span></strong></p>\r\n<p style='margin-top:0cm;margin-right:0cm;margin-bottom:10.0pt;margin-left:0cm;line-height:115%;font-size:15px;font-family:\"Calibri\",sans-serif;text-align:justify;'><strong><span style='font-family:\"Palatino Linotype\",serif;'>CUI: &nbsp;{1}, &nbsp;{2}</span></strong></p>\r\n<p style='margin-top:0cm;margin-right:0cm;margin-bottom:10.0pt;margin-left:0cm;line-height:115%;font-size:15px;font-family:\"Calibri\",sans-serif;'><strong><span style='font-family:\"Palatino Linotype\",serif;'>Nr. &nbsp; &nbsp; &nbsp; &nbsp;/&nbsp;</span></strong></p>\r\n<p style='margin-top:0cm;margin-right:0cm;margin-bottom:10.0pt;margin-left:0cm;line-height:115%;font-size:15px;font-family:\"Calibri\",sans-serif;'><span style='font-family:\"Palatino Linotype\",serif;'>&nbsp;</span></p>\r\n<p style='margin-top:0cm;margin-right:0cm;margin-bottom:10.0pt;margin-left:0cm;line-height:115%;font-size:15px;font-family:\"Calibri\",sans-serif;text-align:center;'><strong><span style='font-family:\"Palatino Linotype\",serif;'>SCRISOARE DE GARANȚIE</span></strong></p>\r\n<p style='margin-top:0cm;margin-right:0cm;margin-bottom:10.0pt;margin-left:0cm;line-height:115%;font-size:15px;font-family:\"Calibri\",sans-serif;text-align:justify;'><strong><span style='font-family:\"Palatino Linotype\",serif;'>&nbsp;</span></strong></p>\r\n<p style='margin-top:0cm;margin-right:0cm;margin-bottom:10.0pt;margin-left:0cm;line-height:115%;font-size:15px;font-family:\"Calibri\",sans-serif;text-align:justify;'><strong><span style='font-family:\"Palatino Linotype\",serif;'>&nbsp; &nbsp;{3}&nbsp;</span></strong><span style='font-family:\"Palatino Linotype\",serif;'>cu sediul &icirc;n Rom&acirc;nia,&nbsp;</span><span style='font-family:\"Palatino Linotype\",serif;'>mun. {4}</span><span style='font-family:\"Palatino Linotype\",serif;'>, &icirc;nregistrată la registrul comerțului sub numărul<strong>&nbsp;{5}</strong>, cod fiscal <strong>{6},&nbsp;</strong>reprezentată legal prin <strong>{7}&nbsp;</strong>&icirc;n calitate de <strong>administrator,&nbsp;</strong>prin prezenta vă solicităm sprijinul pentru obținerea vizei rom&acirc;ne de lungă ședere &icirc;n scop de muncă, simbol D/AM pentru domnul <strong>{8}</strong>, cetățenie {9}, nascut</span><span style='font-family:\"Palatino Linotype\",serif;'>&nbsp;</span><span style='font-family:\"Palatino Linotype\",serif;'>{10}</span><span style='font-family:\"Palatino Linotype\",serif;'>, &icirc;n Bangladesh, identificat cu pașaport nr. {11}, val. {12};</span></p>\r\n<p style='margin-top:0cm;margin-right:0cm;margin-bottom:10.0pt;margin-left:0cm;line-height:115%;font-size:15px;font-family:\"Calibri\",sans-serif;text-align:justify;'><span style='font-family:\"Palatino Linotype\",serif;'>Menționăm că obținerea vizei este necesară &icirc;n scopul angajării &icirc;n baza <strong>avizului de muncă nr. eliberat de IGI la data</strong>.</span></p>\r\n<p style='margin-top:0cm;margin-right:0cm;margin-bottom:10.0pt;margin-left:0cm;line-height:115%;font-size:15px;font-family:\"Calibri\",sans-serif;text-align:justify;'><span style='font-family:\"Palatino Linotype\",serif;'>Subscrisa &icirc;și asumă obligația suportării cheltuielilor privind asistența materială, medicală și a celor de executare a masurilor de &icirc;ndepărtare, conform art. 44 alin. (2) lit. b) sau 44^1 alin. (2) lit. b), după caz, din Ordonanța de urgență nr.194/2002 republicată, cu modificările si completările ulterioare. Cazarea v-a fi asigurată<strong>&nbsp;</strong>&icirc;n <strong>&nbsp;{13}.</strong></span></p>\r\n<p style='margin-top:0cm;margin-right:0cm;margin-bottom:0cm;margin-left:252.0pt;line-height:normal;font-size:15px;font-family:\"Calibri\",sans-serif;text-align:justify;text-indent:36.0pt;'><strong><span style='font-family:\"Palatino Linotype\",serif;'>&nbsp;</span></strong></p>\r\n<p style='margin-top:0cm;margin-right:0cm;margin-bottom:0cm;margin-left:252.0pt;line-height:normal;font-size:15px;font-family:\"Calibri\",sans-serif;text-align:justify;text-indent:36.0pt;'><strong><span style='font-family:\"Palatino Linotype\",serif;'>&nbsp;</span></strong></p>\r\n<p style='margin-top:0cm;margin-right:0cm;margin-bottom:0cm;margin-left:252.0pt;line-height:normal;font-size:15px;font-family:\"Calibri\",sans-serif;text-align:justify;text-indent:36.0pt;'><strong><span style='font-family:\"Palatino Linotype\",serif;'>Administrator,&nbsp;</span></strong></p>\r\n<p style='margin-top:0cm;margin-right:0cm;margin-bottom:0cm;margin-left:252.0pt;line-height:normal;font-size:15px;font-family:\"Calibri\",sans-serif;text-align:justify;text-indent:36.0pt;'><strong><span style='font-family:\"Palatino Linotype\",serif;'>&nbsp;</span></strong></p>\r\n<p style='margin-top:0cm;margin-right:0cm;margin-bottom:0cm;margin-left:252.0pt;line-height:normal;font-size:15px;font-family:\"Calibri\",sans-serif;text-align:justify;text-indent:36.0pt;'><strong><span style='font-family:\"Palatino Linotype\",serif;'>{14}</span></strong></p>";
            temp1.Content = @"**{0}**
**CUI: {1}, {2}**
**Nr.       /**


**SCRISOARE DE GARANȚIE**


**{3}** cu sediul în România, mun. {4}, înregistrată la registrul comerțului sub numărul {5}, cod fiscal {6}, reprezentată legal prin {7} în calitate de administrator,**


**prin prezenta vă solicităm sprijinul pentru obținerea vizei române de lungă ședere în scop de muncă, simbol D/AM pentru domnul {8}, cetățenie {9}, nascut {10}, în Bangladesh, identificat cu pașaport nr. {11}, val. {12};**


**Menționăm că obținerea vizei este necesară în scopul angajării în baza avizului de muncă nr. {13} eliberat de IGI la data {14}.**


**Subscrisa își asumă obligația suportării cheltuielilor privind asistența materială, medicală și a celor de executare a masurilor de îndepărtare, conform art. 44 alin. (2) lit. b) sau 44^1 alin. (2) lit. b), după caz, din Ordonanța de urgență nr.194/2002 republicată, cu modificările si completările ulterioare. Cazarea v-a fi asigurată în  {13}.**


                                                                                                        **Administrator,**


                                                                                                        **{14}**
";
            templateArray.Add(temp1);




            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                // Access the checkbox cell in the "SelectColumn" column
                DataGridViewCheckBoxCell checkBox = row.Cells["Select"] as DataGridViewCheckBoxCell;

                // Set the value of the checkbox cell to true
                checkBox.Value = true;
            }





            for (int i = 0; i < templateArray.Count; i++)
            {
                comboBox1.Items.Add(templateArray[i].Name);
            }
            // Optionally, set a default selected item
            comboBox1.SelectedIndex = 0;



        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int count = 0;
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            folderDialog.Description = "Select a folder to save the Word file";

            if (folderDialog.ShowDialog() == DialogResult.OK)
            {

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


                string selectedFolder = folderDialog.SelectedPath;
                //if(!checkBox1.Checked)
                //{

                    foreach (Person person in selectedPersons)
                    {
                        string savePath = System.IO.Path.Combine(selectedFolder, (person.Name + ".docx"));

                        string filecontent;

                        switch (comboBox1.SelectedValue)
                        {
                            case "Scrisoare de garantie pt ambasada":
                                filecontent = string.Format(this.templateArray[1].Content, person.CompanyName, person.CUI, person.ONRC, person.CompanyName, person.FirmAddress, person.ONRC, person.CUI, person.RepresentsByName + " " + person.RepresentsBySurname, person.Name, person.Citizenship, person.BornAt, person.Citizenship, person.PassportNo, person.PassportValidUntil, person.AccomodationAddress, person.RepresentsByName + " " + person.RepresentsBySurname);
                                break;
                            case "Acord Angajator":
                                filecontent = string.Format(this.templateArray[0].Content, person.CompanyName, person.CUI, person.ONRC, person.FirmAddress, person.CompanyName, person.ONRC, person.CUI, person.FirmAddress, person.RepresentsByName + " " + person.RepresentsBySurname, person.Name + " " + person.SurName, person.Citizenship, person.BornAt, person.Citizenship, person.PassportNo, person.PassportValidUntil, person.RepresentsByName + " " + person.RepresentsBySurname);
                                break;
                            default:
                                filecontent = string.Format(this.templateArray[0].Content, person.CompanyName, person.CUI, person.ONRC, person.FirmAddress, person.CompanyName, person.ONRC, person.CUI, person.FirmAddress, person.RepresentsByName + " " + person.RepresentsBySurname, person.Name + " " + person.SurName, person.Citizenship, person.BornAt, person.Citizenship, person.PassportNo, person.PassportValidUntil, person.RepresentsByName + " " + person.RepresentsBySurname);
                                break;
                        }

                        using (DocX document = DocX.Create(savePath))
                        {
                            var paragraph = document.InsertParagraph();
                            string pattern = @"\*\*(.*?)\*\*";
                            int startIndex = 0;

                            // Use a regular expression to find matches
                            foreach (Match match in Regex.Matches(filecontent, pattern))
                            {
                                // Append the text before the match
                                paragraph.Append(filecontent.Substring(startIndex, match.Index - startIndex));

                                // Append the matched text with bold formatting
                                paragraph.Append(match.Groups[1].Value).Bold();

                                // Update the starting index for the next iteration
                                startIndex = match.Index + match.Length;
                            }

                            // Append any remaining text
                            if (startIndex < filecontent.Length)
                            {
                                paragraph.Append(filecontent.Substring(startIndex));
                            }

                            // Save the Word document
                            document.Save();
                            count++;
                        }


                    }
                    MessageBox.Show($"Word file saved successfully.\n\nTotal Files Saved: {count}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
                //else
                //{
                //    string savePath = System.IO.Path.Combine(selectedFolder, (persons.First().Name + " " + comboBox1.SelectedValue + ".docx"));

                //    string filecontent;

                //    string concatenatedNames = string.Empty;
                //    foreach (var person in persons)
                //    {
                //        concatenatedNames += person.Name + " " + person.SurName + ", ";
                //    }

                //    switch (comboBox1.SelectedValue)
                //    {
                //        case "Scrisoare de garantie pt ambasada":
                //            filecontent = string.Format(this.templateArray[1].Content, persons.First().CompanyName , persons.First().CUI, persons.First().ONRC, persons.First().CompanyName, persons.First().FirmAddress, persons.First().ONRC, persons.First().CUI, persons.First().RepresentsByName + " " + persons.First().RepresentsBySurname, concatenatedNames, persons.First().Citizenship, persons.First().BornAt, persons.First().Citizenship, persons.First().PassportNo, persons.First().PassportValidUntil, persons.First().AccomodationAddress, persons.First().RepresentsByName + " " + persons.First().RepresentsBySurname);
                //            break;
                //        case "Acord Angajator":
                //            filecontent = string.Format(this.templateArray[0].Content, persons.First().CompanyName, persons.First().CUI, persons.First().ONRC, persons.First().FirmAddress, persons.First().CompanyName, persons.First().ONRC, persons.First().CUI, persons.First().FirmAddress, persons.First().RepresentsByName + " " + persons.First().RepresentsBySurname, concatenatedNames , persons.First().Citizenship, persons.First().BornAt, persons.First().Citizenship, persons.First().PassportNo, persons.First().PassportValidUntil, persons.First().RepresentsByName + " " + persons.First().RepresentsBySurname);
                //            break;
                //        default:
                //            filecontent = string.Format(this.templateArray[0].Content, persons.First().CompanyName, persons.First().CUI, persons.First().ONRC, persons.First().FirmAddress, persons.First().CompanyName, persons.First().ONRC, persons.First().CUI, persons.First().FirmAddress, persons.First().RepresentsByName + " " + persons.First().RepresentsBySurname, concatenatedNames , persons.First().Citizenship, persons.First().BornAt, persons.First().Citizenship, persons.First().PassportNo, persons.First().PassportValidUntil, persons.First().RepresentsByName + " " + persons.First().RepresentsBySurname);
                //            break;
                //    }
                //}
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int count = 0;
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            folderDialog.Description = "Select a folder to save the Word file";
            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
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


                string selectedFolder = folderDialog.SelectedPath;
                //if (!checkBox1.Checked)
                //{
                    foreach (Person person in selectedPersons)
                    {
                        
                        string savePath = Path.Combine(selectedFolder, person.Name + ".pdf");
                        string filecontent;
                        switch (comboBox1.SelectedValue)
                        {
                            case "Scrisoare de garantie pt ambasada":
                                filecontent = string.Format(this.templateArray[1].Content, person.CompanyName, person.CUI, person.ONRC, person.CompanyName, person.FirmAddress, person.ONRC, person.CUI, person.RepresentsByName + " " + person.RepresentsBySurname, person.Name, person.Citizenship, person.BornAt, person.Citizenship, person.PassportNo, person.PassportValidUntil, person.AccomodationAddress, person.RepresentsByName + " " + person.RepresentsBySurname);
                                break;
                            case "Acord Angajator":
                                filecontent = string.Format(this.templateArray[0].Content, person.CompanyName, person.CUI, person.ONRC, person.FirmAddress, person.CompanyName, person.ONRC, person.CUI, person.FirmAddress, person.RepresentsByName + " " + person.RepresentsBySurname, person.Name + " " + person.SurName, person.Citizenship, person.BornAt, person.Citizenship, person.PassportNo, person.PassportValidUntil, person.RepresentsByName + " " + person.RepresentsBySurname);
                                break;
                            default:
                                filecontent = string.Format(this.templateArray[0].Content, person.CompanyName, person.CUI, person.ONRC, person.FirmAddress, person.CompanyName, person.ONRC, person.CUI, person.FirmAddress, person.RepresentsByName + " " + person.RepresentsBySurname, person.Name + " " + person.SurName, person.Citizenship, person.BornAt, person.Citizenship, person.PassportNo, person.PassportValidUntil, person.RepresentsByName + " " + person.RepresentsBySurname);
                                break;
                        }
                        iTextSharp.text.Document document = new iTextSharp.text.Document();
                        // Create a PdfWriter and add the document to it
                        using (FileStream fs = new FileStream(savePath, FileMode.Create))
                        {
                            PdfWriter writer = PdfWriter.GetInstance(document, fs);
                            document.Open();
                            iTextSharp.text.Paragraph paragraph = new iTextSharp.text.Paragraph(filecontent);
                            document.Add(paragraph);
                            document.Close();
                            count++;
                        }
                    }
                    MessageBox.Show($"PDF file saved successfully.\n\nTotal Files Saved: {count}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
                //else
                //{
                //    string savePath = Path.Combine(selectedFolder, (persons.First().Name + " " + comboBox1.SelectedValue + ".pdf"));
                //    string filecontent;
                //    switch (comboBox1.SelectedValue)
                //    {
                //        case "Scrisoare de garantie pt ambasada":
                //            filecontent = string.Format(this.templateArray[1].Content, persons.First().CompanyName, persons.First().CUI, persons.First().ONRC, persons.First().CompanyName, persons.First().FirmAddress, persons.First().ONRC, persons.First().CUI, persons.First().RepresentsByName + " " + persons.First().RepresentsBySurname, persons.First().Name, persons.First().Citizenship, persons.First().BornAt, persons.First().Citizenship, persons.First().PassportNo, persons.First().PassportValidUntil, persons.First().AccomodationAddress, persons.First().RepresentsByName + " " + persons.First().RepresentsBySurname);
                //            break;
                //        case "Acord Angajator":
                //            filecontent = string.Format(this.templateArray[0].Content, persons.First().CompanyName, persons.First().CUI, persons.First().ONRC, persons.First().FirmAddress, persons.First().CompanyName, persons.First().ONRC, persons.First().CUI, persons.First().FirmAddress, persons.First().RepresentsByName + " " + persons.First().RepresentsBySurname, persons.First().Name + " " + persons.First().SurName, persons.First().Citizenship, persons.First().BornAt, persons.First().Citizenship, persons.First().PassportNo, persons.First().PassportValidUntil, persons.First().RepresentsByName + " " + persons.First().RepresentsBySurname);
                //            break;
                //        default:
                //            filecontent = string.Format(this.templateArray[0].Content, persons.First().CompanyName, persons.First().CUI, persons.First().ONRC, persons.First().FirmAddress, persons.First().CompanyName, persons.First().ONRC, persons.First().CUI, persons.First().FirmAddress, persons.First().RepresentsByName + " " + persons.First().RepresentsBySurname, persons.First().Name + " " + persons.First().SurName, persons.First().Citizenship, persons.First().BornAt, persons.First().Citizenship, persons.First().PassportNo, persons.First().PassportValidUntil, persons.First().RepresentsByName + " " + persons.First().RepresentsBySurname);
                //            break;
                //    }


                //    iTextSharp.text.Document document = new iTextSharp.text.Document();
                //    // Create a PdfWriter and add the document to it
                //    using (FileStream fs = new FileStream(savePath, FileMode.Create))
                //    {
                //        PdfWriter writer = PdfWriter.GetInstance(document, fs);
                //        document.Open();
                //        iTextSharp.text.Paragraph paragraph = new iTextSharp.text.Paragraph(filecontent);
                //        document.Add(paragraph);
                //        document.Close();
                //    }
                //    MessageBox.Show($"PDF file saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox2.Checked)
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
    }
}
