using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question
{
    public partial class Notification : Form
    {
        Send send;
        public Notification(Send _send)
        {
            InitializeComponent();
            this.send = _send;
            Pubbutton.Enabled = false;
        }

        public void push_notification()
        {
            if (send.Update_listBox())
            {
                Pubbutton.Enabled = true;
            }

            else
            {
                Pubbutton.Enabled = false;
            }
        }
        private void Exitbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Managebutton_Click(object sender, EventArgs e)
        {
            Program.subscription.Show();
            this.Hide();
        }

        private void Pubbutton_Click(object sender, EventArgs e)
        {
            Program.send.Show();
            this.Hide();
        }
    }
}
