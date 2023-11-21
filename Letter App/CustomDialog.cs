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
                List<Person> persons = new List<Person>();

                Person_Data_Entry person_Data_Entry = new Person_Data_Entry(persons, 1, numberOfPeople);

                // Set the StartPosition to CenterScreen
                person_Data_Entry.StartPosition = FormStartPosition.CenterScreen;

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
