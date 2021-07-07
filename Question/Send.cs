using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Question
{ 
    public partial class Send : Form
    {
        public delegate void Publisher(string url);
        public delegate void SendViaEmail(string email);
        public delegate void SendViaMobile(string mobile);
        public event Publisher sendMessage;
        public event SendViaEmail sendEmail;
        public event SendViaMobile sendMobile;

        Subscription subscription;

        public Send()
        {
            InitializeComponent();

        }

        private void BackToMbutton_Click(object sender, EventArgs e)
        {
            Program.notification.Show();
            this.Hide();
        }

        private void PUBbutton_Click(object sender, EventArgs e)
        {
            
        }

        public void UpdatedTextBox_add(string data)
        {
            SublistBox.Items.Add(data);
        }

        public void UpdatedTextBox_remove(string data)
        {
            if (SublistBox.Items.Contains(data))
            {
                SublistBox.Items.Remove(data);
            }
        }

        public bool Valid_Check(string data)
        {
            if (SublistBox.Items.Contains(data))
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        public bool Update_listBox()
        {
            if (SublistBox.Items.Count > 0)
            {
                return true;
            }

            else
            {
                return false;
            }
        }
    }
}