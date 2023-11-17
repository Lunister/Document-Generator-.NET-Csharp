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
    public partial class Load_Screen : Form
    {
        private System.Windows.Forms.Timer _timer;
        public Load_Screen()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            _timer = new System.Windows.Forms.Timer();
            _timer.Interval = 5000;
            _timer.Tick += _timer_Tick;
            _timer.Start();
        }

        private void _timer_Tick(object? sender, EventArgs e)
        {
            _timer.Stop();
            Home_Screen home_Screen = new Home_Screen();
            home_Screen.StartPosition = FormStartPosition.CenterScreen;
            home_Screen.Show();
            this.Hide();
        }

        private void Load_Screen_Load(object sender, EventArgs e)
        {

        }
    }
}
