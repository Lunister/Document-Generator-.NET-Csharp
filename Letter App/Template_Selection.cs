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
using System.Threading.Tasks.Sources;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Color = System.Drawing.Color;
using Button = System.Windows.Forms.Button;

namespace Letter_App
{
    public partial class Template_Selection : Form
    {
        private int numberofpeople;

        public Template_Selection(int numberofpeople)
        {
            InitializeComponent();
            this.numberofpeople = numberofpeople;
        }

        private void Template_Selection_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.WrapContents = true;


            //-------------------------------ENTER ALL TEMPLATES HERE-------------------------------------------------

            

            int template_number = 2;



            Template[] templateArray = new Template[template_number];


            Template temp0 = new Template();
            temp0.Name = "Acord Angajator";
            //temp0.Content = "<p style='margin-top:0cm;margin-right:0cm;margin-bottom:10.0pt;margin-left:0cm;line-height:115%;font-size:15px;font-family:\"Calibri\",sans-serif;text-align:justify;'><span style='font-family:\"Palatino Linotype\",serif;'>Denumire angajator:<strong>&nbsp;</strong></span><span style='font-family:\"Palatino Linotype\",serif;'><strong>{0}&nbsp;</strong></span><span style='font-family:\"Palatino Linotype\",serif;'>&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;</span></p>\r\n<p style='margin-top:0cm;margin-right:0cm;margin-bottom:10.0pt;margin-left:0cm;line-height:115%;font-size:15px;font-family:\"Calibri\",sans-serif;text-align:justify;'><span style='font-family:\"Palatino Linotype\",serif;'>Cod fiscal:&nbsp;</span><span style='font-family:\"Palatino Linotype\",serif;'><strong>{1}</strong></span><strong><span style='font-family:\"Palatino Linotype\",serif;'>&nbsp;</span></strong></p>\r\n<p style='margin-top:0cm;margin-right:0cm;margin-bottom:10.0pt;margin-left:0cm;line-height:115%;font-size:15px;font-family:\"Calibri\",sans-serif;text-align:justify;'><span style='font-family:\"Palatino Linotype\",serif;'>Nr. R.C.:&nbsp;</span><span style='font-family:\"Palatino Linotype\",serif;'><strong>{2}</strong></span></p>\r\n<p style='margin-top:0cm;margin-right:0cm;margin-bottom:10.0pt;margin-left:0cm;line-height:115%;font-size:15px;font-family:\"Calibri\",sans-serif;text-align:justify;'><span style='font-family:\"Palatino Linotype\",serif;'>Adresa:&nbsp;</span><strong><span style='font-family:\"Palatino Linotype\",serif;'>{3}</span></strong></p>\r\n<p style='margin-top:0cm;margin-right:0cm;margin-bottom:10.0pt;margin-left:0cm;line-height:normal;font-size:15px;font-family:\"Calibri\",sans-serif;'><strong><span style='font-size:16px;font-family:\"Palatino Linotype\",serif;'>Nr: &nbsp; &nbsp; &nbsp;/&nbsp;</span></strong></p>\r\n<p style='margin-top:0cm;margin-right:0cm;margin-bottom:10.0pt;margin-left:0cm;line-height:normal;font-size:15px;font-family:\"Calibri\",sans-serif;'><span style='font-size:16px;font-family:\"Palatino Linotype\",serif;'>&nbsp;</span></p>\r\n<p style='margin-top:0cm;margin-right:0cm;margin-bottom:10.0pt;margin-left:0cm;line-height:normal;font-size:15px;font-family:\"Calibri\",sans-serif;'><span style='font-size:16px;font-family:\"Palatino Linotype\",serif;'>&nbsp;</span></p>\r\n<p style='margin-top:0cm;margin-right:0cm;margin-bottom:10.0pt;margin-left:0cm;line-height:normal;font-size:15px;font-family:\"Calibri\",sans-serif;text-align:center;'><strong><span style='font-size:16px;font-family:\"Palatino Linotype\",serif;'>ACORD PENTRU SCHIMBARE ANGAJATOR CONFORM OUG NR. 143/28.10.2022</span></strong></p>\r\n<p style='margin-top:0cm;margin-right:0cm;margin-bottom:10.0pt;margin-left:0cm;line-height:normal;font-size:15px;font-family:\"Calibri\",sans-serif;'><span style='font-size:16px;font-family:\"Palatino Linotype\",serif;'>&nbsp;</span></p>\r\n<p style='margin-top:0cm;margin-right:0cm;margin-bottom:10.0pt;margin-left:0cm;line-height:150%;font-size:15px;font-family:\"Calibri\",sans-serif;text-align:justify;'><span style='font-size:16px;line-height:150%;font-family:\"Palatino Linotype\",serif;'>&nbsp; &nbsp; &nbsp; &nbsp; &nbsp;Subscrisa&nbsp;</span><span style='font-family:\"Palatino Linotype\",serif;'><strong>{4}</strong></span><span style='font-family:\"Palatino Linotype\",serif;'>, număr de ordine &icirc;n Registrul Comerțului {5}, &nbsp;CUI: {6}, cu sediul &icirc;n&nbsp;</span><span style='font-family:\"Palatino Linotype\",serif;'>{7}</span><span style='font-family:\"Palatino Linotype\",serif;'>&nbsp;</span><span style='font-family:\"Palatino Linotype\",serif;'>reprezentată legal de <strong>{8}</strong>,&nbsp;</span><span style='font-size:16px;line-height:150%;font-family:\"Palatino Linotype\",serif;'>&icirc;n calitate de administrator si fost angajator al cetățeanului:</span></p>\r\n<div style='margin-top:0cm;margin-right:0cm;margin-bottom:10.0pt;margin-left:0cm;line-height:115%;font-size:15px;font-family:\"Calibri\",sans-serif;'>\r\n    <ul style=\"margin-bottom:0cm;list-style-type: undefined;margin-left:44px;\">\r\n        <li style='margin-top:0cm;margin-right:0cm;margin-bottom:10.0pt;margin-left:0cm;line-height:115%;font-size:15px;font-family:\"Calibri\",sans-serif;'><strong><span style='font-family:\"Palatino Linotype\",serif;'>{9},&nbsp;</span></strong><span style='font-family:\"Palatino Linotype\",serif;'>cetățenie {10}, ns. {11}, &icirc;n {12}, identificat cu pașaportul nr. {13}, val. {14};</span></li>\r\n    </ul>\r\n</div>\r\n<p style='margin-top:0cm;margin-right:0cm;margin-bottom:10.0pt;margin-left:0cm;line-height:150%;font-size:15px;font-family:\"Calibri\",sans-serif;text-align:justify;'><span style='font-size:16px;line-height:150%;font-family:\"Palatino Linotype\",serif;'>&Icirc;mi exprim prin prezenta acordul in scris de a se angaja la un alt angajator.&nbsp;</span></p>\r\n<p style='margin-top:0cm;margin-right:0cm;margin-bottom:10.0pt;margin-left:0cm;line-height:150%;font-size:15px;font-family:\"Calibri\",sans-serif;text-align:justify;'><span style='font-size:16px;line-height:150%;font-family:\"Palatino Linotype\",serif;'>&nbsp;</span></p>\r\n<p style='margin-top:0cm;margin-right:0cm;margin-bottom:10.0pt;margin-left:0cm;line-height:150%;font-size:15px;font-family:\"Calibri\",sans-serif;text-align:justify;'><span style='font-size:16px;line-height:150%;font-family:\"Palatino Linotype\",serif;'>&nbsp;</span></p>\r\n<p style='margin-top:0cm;margin-right:0cm;margin-bottom:10.0pt;margin-left:0cm;line-height:150%;font-size:15px;font-family:\"Calibri\",sans-serif;text-align:justify;'><strong><span style='font-size:16px;line-height:150%;font-family:\"Palatino Linotype\",serif;'>&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;Administrator,</span></strong></p>";
            temp0.Content = @"
**Denumire angajator:** {0}
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
            templateArray[0] = temp0;

            Template temp1 = new Template();
            temp1.Name = "Scrisoare de garantie pt ambasada";
            //temp1.Content = "<p style='margin-top:0cm;margin-right:0cm;margin-bottom:10.0pt;margin-left:0cm;line-height:115%;font-size:15px;font-family:\"Calibri\",sans-serif;text-align:justify;'><strong><span style='font-family:\"Palatino Linotype\",serif;'>{0}</span></strong></p>\r\n<p style='margin-top:0cm;margin-right:0cm;margin-bottom:10.0pt;margin-left:0cm;line-height:115%;font-size:15px;font-family:\"Calibri\",sans-serif;text-align:justify;'><strong><span style='font-family:\"Palatino Linotype\",serif;'>CUI: &nbsp;{1}, &nbsp;{2}</span></strong></p>\r\n<p style='margin-top:0cm;margin-right:0cm;margin-bottom:10.0pt;margin-left:0cm;line-height:115%;font-size:15px;font-family:\"Calibri\",sans-serif;'><strong><span style='font-family:\"Palatino Linotype\",serif;'>Nr. &nbsp; &nbsp; &nbsp; &nbsp;/&nbsp;</span></strong></p>\r\n<p style='margin-top:0cm;margin-right:0cm;margin-bottom:10.0pt;margin-left:0cm;line-height:115%;font-size:15px;font-family:\"Calibri\",sans-serif;'><span style='font-family:\"Palatino Linotype\",serif;'>&nbsp;</span></p>\r\n<p style='margin-top:0cm;margin-right:0cm;margin-bottom:10.0pt;margin-left:0cm;line-height:115%;font-size:15px;font-family:\"Calibri\",sans-serif;text-align:center;'><strong><span style='font-family:\"Palatino Linotype\",serif;'>SCRISOARE DE GARANȚIE</span></strong></p>\r\n<p style='margin-top:0cm;margin-right:0cm;margin-bottom:10.0pt;margin-left:0cm;line-height:115%;font-size:15px;font-family:\"Calibri\",sans-serif;text-align:justify;'><strong><span style='font-family:\"Palatino Linotype\",serif;'>&nbsp;</span></strong></p>\r\n<p style='margin-top:0cm;margin-right:0cm;margin-bottom:10.0pt;margin-left:0cm;line-height:115%;font-size:15px;font-family:\"Calibri\",sans-serif;text-align:justify;'><strong><span style='font-family:\"Palatino Linotype\",serif;'>&nbsp; &nbsp;{3}&nbsp;</span></strong><span style='font-family:\"Palatino Linotype\",serif;'>cu sediul &icirc;n Rom&acirc;nia,&nbsp;</span><span style='font-family:\"Palatino Linotype\",serif;'>mun. {4}</span><span style='font-family:\"Palatino Linotype\",serif;'>, &icirc;nregistrată la registrul comerțului sub numărul<strong>&nbsp;{5}</strong>, cod fiscal <strong>{6},&nbsp;</strong>reprezentată legal prin <strong>{7}&nbsp;</strong>&icirc;n calitate de <strong>administrator,&nbsp;</strong>prin prezenta vă solicităm sprijinul pentru obținerea vizei rom&acirc;ne de lungă ședere &icirc;n scop de muncă, simbol D/AM pentru domnul <strong>{8}</strong>, cetățenie {9}, nascut</span><span style='font-family:\"Palatino Linotype\",serif;'>&nbsp;</span><span style='font-family:\"Palatino Linotype\",serif;'>{10}</span><span style='font-family:\"Palatino Linotype\",serif;'>, &icirc;n Bangladesh, identificat cu pașaport nr. {11}, val. {12};</span></p>\r\n<p style='margin-top:0cm;margin-right:0cm;margin-bottom:10.0pt;margin-left:0cm;line-height:115%;font-size:15px;font-family:\"Calibri\",sans-serif;text-align:justify;'><span style='font-family:\"Palatino Linotype\",serif;'>Menționăm că obținerea vizei este necesară &icirc;n scopul angajării &icirc;n baza <strong>avizului de muncă nr. eliberat de IGI la data</strong>.</span></p>\r\n<p style='margin-top:0cm;margin-right:0cm;margin-bottom:10.0pt;margin-left:0cm;line-height:115%;font-size:15px;font-family:\"Calibri\",sans-serif;text-align:justify;'><span style='font-family:\"Palatino Linotype\",serif;'>Subscrisa &icirc;și asumă obligația suportării cheltuielilor privind asistența materială, medicală și a celor de executare a masurilor de &icirc;ndepărtare, conform art. 44 alin. (2) lit. b) sau 44^1 alin. (2) lit. b), după caz, din Ordonanța de urgență nr.194/2002 republicată, cu modificările si completările ulterioare. Cazarea v-a fi asigurată<strong>&nbsp;</strong>&icirc;n <strong>&nbsp;{13}.</strong></span></p>\r\n<p style='margin-top:0cm;margin-right:0cm;margin-bottom:0cm;margin-left:252.0pt;line-height:normal;font-size:15px;font-family:\"Calibri\",sans-serif;text-align:justify;text-indent:36.0pt;'><strong><span style='font-family:\"Palatino Linotype\",serif;'>&nbsp;</span></strong></p>\r\n<p style='margin-top:0cm;margin-right:0cm;margin-bottom:0cm;margin-left:252.0pt;line-height:normal;font-size:15px;font-family:\"Calibri\",sans-serif;text-align:justify;text-indent:36.0pt;'><strong><span style='font-family:\"Palatino Linotype\",serif;'>&nbsp;</span></strong></p>\r\n<p style='margin-top:0cm;margin-right:0cm;margin-bottom:0cm;margin-left:252.0pt;line-height:normal;font-size:15px;font-family:\"Calibri\",sans-serif;text-align:justify;text-indent:36.0pt;'><strong><span style='font-family:\"Palatino Linotype\",serif;'>Administrator,&nbsp;</span></strong></p>\r\n<p style='margin-top:0cm;margin-right:0cm;margin-bottom:0cm;margin-left:252.0pt;line-height:normal;font-size:15px;font-family:\"Calibri\",sans-serif;text-align:justify;text-indent:36.0pt;'><strong><span style='font-family:\"Palatino Linotype\",serif;'>&nbsp;</span></strong></p>\r\n<p style='margin-top:0cm;margin-right:0cm;margin-bottom:0cm;margin-left:252.0pt;line-height:normal;font-size:15px;font-family:\"Calibri\",sans-serif;text-align:justify;text-indent:36.0pt;'><strong><span style='font-family:\"Palatino Linotype\",serif;'>{14}</span></strong></p>";
            temp1.Content = @"
**{0}**
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
            templateArray[1] = temp1;



            //---------------------------PRINTING ALL THE BUTTONS-------------------------------------------------------

            for (int i = 0; i < template_number; i++)
            {

                int red, green, blue;
                Random rnd = new Random();
                red = rnd.Next(0, 255);
                blue = rnd.Next(0, 255);
                green = rnd.Next(0, 255);

                templatesSelectElement element = new templatesSelectElement();
                element.create_letters_button.BackColor = Color.FromArgb(red, green, blue);
                element.create_letters_button.FlatAppearance.MouseDownBackColor = Color.FromArgb(red, green, blue + 30 > 255 ? 255 : blue + 30);
                element.create_letters_button.FlatAppearance.MouseOverBackColor = Color.FromArgb(red, green, 0);
                element.create_letters_button.Name = "create_letters_button" + i.ToString();
                element.create_letters_button.Text = templateArray[i].Name;
                element.create_letters_button.Click += selected_Template_Click;
                element.create_letters_button.Tag = templateArray[i];


                element.button1.Click += button1_Click;
                element.button1.Tag = templateArray[i];

                flowLayoutPanel1.Controls.Add(element);

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            // Access the Tag property, which should contain the associated template
            Template selectedTemplate = (Template)button.Tag;




            
        }

        private void selected_Template_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            Template selectedTemplate = (Template)button.Tag;


            List<Person> persons = new List<Person>();

            Person_Data_Entry person_Data_Entry = new Person_Data_Entry(persons, selectedTemplate, 1, numberofpeople);

            person_Data_Entry.StartPosition = FormStartPosition.CenterParent;

            person_Data_Entry.Show();

            this.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            CustomDialog customDialog = new CustomDialog(numberofpeople);
            customDialog.StartPosition = FormStartPosition.CenterScreen;
            this.Close();
            customDialog.TopMost = true;
            customDialog.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }


    }
}
