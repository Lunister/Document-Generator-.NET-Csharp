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
    public partial class CustomDialog : Form
    {
        public CustomDialog()
        {
            InitializeComponent();
        }

        public CustomDialog(int numberofpeople)
        {
            InitializeComponent();
            textBox1.Text = numberofpeople.ToString();
        }

        private void CustomDialog_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int numberOfPeople))
            {
                //Template_Selection template_Selection = new Template_Selection(numberOfPeople);
                //template_Selection.StartPosition = FormStartPosition.CenterParent;
                //this.Close();
                //template_Selection.ShowDialog();


                //Button button = (Button)sender;

                //Template selectedTemplate = (Template)button.Tag;


                List<Person> persons = new List<Person>();

                Person_Data_Entry person_Data_Entry = new Person_Data_Entry(persons, 1, numberOfPeople);

                person_Data_Entry.StartPosition = FormStartPosition.CenterParent;

                person_Data_Entry.Show();

                this.Close();

            }
            else
            {
                MessageBox.Show("Invalid input. Please enter a valid number.");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
