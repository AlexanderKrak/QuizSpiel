using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizSpiel
{
    public partial class StartScreen : Form
    {
        public StartScreen()
        {
            InitializeComponent();
        }

        private int counter;
        private void StartScreen_Load(object sender, EventArgs e)
        {
            counter = 0;
            timerMillionaire.Interval = 700;
            timerMillionaire.Enabled = true;
            this.timerMillionaire.Tick += new EventHandler(this.timerMillionaire_Tick);
        }

        private void timerMillionaire_Tick(object sender, EventArgs e)
        {
            if (counter >= 10)
            {
                timerMillionaire.Enabled = false;
                counter = 0;
                this.Hide();
            }
            else
            {
                counter += 1;
            }
        }
    }
}
