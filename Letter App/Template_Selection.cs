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

            templateArray[0] = temp0;

            Template temp1 = new Template();
            temp1.Name = "Scrisoare de garantie pt ambasada";

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
