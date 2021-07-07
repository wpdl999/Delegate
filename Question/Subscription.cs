using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Question
{
    public partial class Subscription : Form
    {
        Send send;
        Notification notification;
        public Subscription(Send _send,Notification _notification)
        {
            InitializeComponent();
            Subbutton.Enabled = false;
            UnSubbutton.Enabled = false;
            this.send = _send;
            this.notification = _notification;
        }

        private void BTMbutton_Click(object sender, EventArgs e)
        {
            Program.notification.Show();
            notification.push_notification();
            this.Hide();
        }

        private void Subbutton_Click(object sender, EventArgs e)
        {

            if (EmailcheckBox.Checked)
            {
                if (!send.Valid_Check(EmailtextBox.Text))
                {
                    send.UpdatedTextBox_add(EmailtextBox.Text);
                    MessageBox.Show("You subscribe Email!!");
                }
                else
                {
                    MessageBox.Show("You cannot enter duplicate email");
                }               
            }

            if (NumcheckBox.Checked)
            {
                if (!send.Valid_Check(NumtextBox.Text))
                {
                    send.UpdatedTextBox_add(NumtextBox.Text);
                    MessageBox.Show("You subscribe Phone Number!");
                } 
                
                else
                {
                    MessageBox.Show("You cannot enter duplicate phone number");
                }            
            }
        }

        private void EmailtextBox_TextChanged(object sender, EventArgs e)
        {
            if (EmailcheckBox.Checked)
            {
                string email = EmailtextBox.Text;
                Regex regex = new Regex(@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
                if (regex.IsMatch(email))
                {
                    Subbutton.Enabled = true;
                    UnSubbutton.Enabled = true;
                    Invlabel.Hide();                    
                }
                else
                {
                    Invlabel.Show();
                }
            }
        }

        public string getItem()
        {
            return EmailtextBox.Text;
        }

        private void NumtextBox_TextChanged(object sender, EventArgs e)
        {
            string contactNum = NumtextBox.Text;
            Regex rx = new Regex("\\d{3}-\\d{3}-\\d{4}");
            if (rx.IsMatch(contactNum))
            {
                InvNlabel.Hide();
            }

            else {
                InvNlabel.Show();
            }
        }

        private void UnSubbutton_Click(object sender, EventArgs e)
        {
            if (EmailcheckBox.Checked)
            {
                send.UpdatedTextBox_remove(EmailtextBox.Text);
                MessageBox.Show("You unsubscribe Email!!");
            }

            if (NumcheckBox.Checked)
            {
                send.UpdatedTextBox_remove(NumtextBox.Text);
                MessageBox.Show("You Unsubscribe Phone Number!");
            }
        }
    }
}
