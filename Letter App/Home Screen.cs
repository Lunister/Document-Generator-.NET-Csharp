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

        }
    }
}
