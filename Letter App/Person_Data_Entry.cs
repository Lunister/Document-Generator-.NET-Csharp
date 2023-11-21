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
    public partial class Person_Data_Entry : Form
    {

        public List<Person> persons;
        public Template template;
        public int currentPerson;
        public int numberofPeople;

        public Person_Data_Entry()
        {
            InitializeComponent();
            this.persons = new List<Person>();
            template = new Template();
            this.numberofPeople = 0;
            this.currentPerson = 0;

        }

        public Person_Data_Entry(List<Person> persons, Template t, int i, int numberofPeople)
        {
            InitializeComponent();

            label2.Text = "Person " + i.ToString();

            if (i == 1)
            {
                button3.Enabled = false;
            }

            this.template = t;
            this.currentPerson = i;
            this.numberofPeople = numberofPeople;
            this.persons = persons;
        }

        public Person_Data_Entry(List<Person> persons, int i, int numberofPeople)
        {
            InitializeComponent();

            label2.Text = "Person " + i.ToString();

            if (i == 1)
            {
                button3.Enabled = false;
            }

            this.template = null;
            this.currentPerson = i;
            this.numberofPeople = numberofPeople;
            this.persons = persons;
        }




        private void Person_Data_Entry_Load(object sender, EventArgs e)
        {
            if (persons.Count != 0)
            {
                textBox1.Text = persons.Last().Name;
                textBox2.Text = persons.Last().SurName;
                textBox3.Text = persons.Last().PassportNo;
                dateTimePicker1.Text = persons.Last().PassportValidUntil;
                dateTimePicker2.Text = persons.Last().BornAt;
                textBox4.Text = persons.Last().Citizenship;
                textBox5.Text = persons.Last().ResidentPermitNo;
                dateTimePicker3.Text = persons.Last().RPValidUntil;
                textBox10.Text = persons.Last().CompanyName;
                textBox9.Text = persons.Last().ONRC;
                textBox8.Text = persons.Last().CUI;
                textBox11.Text = persons.Last().FirmAddress;
                textBox7.Text = persons.Last().RepresentsByName;
                textBox6.Text = persons.Last().RepresentsBySurname;
                textBox12.Text = persons.Last().Passport_IDNumber;
                dateTimePicker6.Text = persons.Last().PassportIDValidUntil;
                textBox16.Text = persons.Last().Profession;
                textBox15.Text = persons.Last().Salary;
                textBox18.Text = persons.Last().PlacetoWork;
                textBox17.Text = persons.Last().AccomodationAddress;
                textBox14.Text = persons.Last().CORNumber;
                textBox13.Text = persons.Last().Orgamigram;
                textBox22.Text = persons.Last().OccupiedByRomanianCitizen;
                textBox21.Text = persons.Last().OccupiedByImmigrationCitizen;
                textBox20.Text = persons.Last().JobsVacancies;
                dateTimePicker5.Text = persons.Last().AJOFMDate;
                textBox24.Text = persons.Last().AJOFMCity;
                textBox23.Text = persons.Last().NumberOfAJOFMPaper;
                dateTimePicker4.Text = persons.Last().DateofAJOFMPaper;

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Person newPerson = new Person();
            newPerson.Name = textBox1.Text;
            newPerson.SurName = textBox2.Text;
            newPerson.PassportNo = textBox3.Text;
            newPerson.PassportValidUntil = dateTimePicker1.Text.ToString();
            newPerson.BornAt = dateTimePicker2.Text.ToString();
            newPerson.Citizenship = textBox4.Text;
            newPerson.ResidentPermitNo = textBox5.Text;
            newPerson.RPValidUntil = dateTimePicker3.Text.ToString();
            newPerson.CompanyName = textBox10.Text;
            newPerson.ONRC = textBox9.Text;
            newPerson.CUI = textBox8.Text;
            newPerson.FirmAddress = textBox11.Text;
            newPerson.RepresentsByName = textBox7.Text;
            newPerson.RepresentsBySurname = textBox6.Text;
            newPerson.Passport_IDNumber = textBox12.Text;
            newPerson.PassportIDValidUntil = dateTimePicker6.Text;
            newPerson.Profession = textBox16.Text;
            newPerson.Salary = textBox15.Text;
            newPerson.PlacetoWork = textBox18.Text;
            newPerson.AccomodationAddress = textBox17.Text;
            newPerson.CORNumber = textBox14.Text;
            newPerson.Orgamigram = textBox13.Text;
            newPerson.OccupiedByRomanianCitizen = textBox22.Text;
            newPerson.OccupiedByImmigrationCitizen = textBox21.Text;
            newPerson.JobsVacancies = textBox20.Text;
            newPerson.AJOFMDate = dateTimePicker5.Text;
            newPerson.AJOFMCity = textBox24.Text;
            newPerson.NumberOfAJOFMPaper = textBox23.Text;
            newPerson.DateofAJOFMPaper = dateTimePicker4.Text;

            persons.Add(newPerson);

            if (currentPerson == numberofPeople)
            {
                PersonDataResults personDataResults = new PersonDataResults(persons, template, numberofPeople);
                personDataResults.StartPosition = FormStartPosition.CenterScreen;
                personDataResults.Show();
                this.Close();
            }
            else
            {
                Person_Data_Entry person_Data_Entry = new Person_Data_Entry(persons, template, currentPerson + 1, numberofPeople);
                person_Data_Entry.StartPosition = FormStartPosition.CenterScreen;
                person_Data_Entry.Show();
                this.Close();
            }

        }


    }
}
