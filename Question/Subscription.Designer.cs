
namespace Question
{
    partial class Subscription
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.EmailcheckBox = new System.Windows.Forms.CheckBox();
            this.NumcheckBox = new System.Windows.Forms.CheckBox();
            this.Subbutton = new System.Windows.Forms.Button();
            this.UnSubbutton = new System.Windows.Forms.Button();
            this.BTMbutton = new System.Windows.Forms.Button();
            this.EmailtextBox = new System.Windows.Forms.TextBox();
            this.NumtextBox = new System.Windows.Forms.TextBox();
            this.Invlabel = new System.Windows.Forms.Label();
            this.InvNlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EmailcheckBox
            // 
            this.EmailcheckBox.AutoSize = true;
            this.EmailcheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmailcheckBox.Location = new System.Drawing.Point(46, 70);
            this.EmailcheckBox.Name = "EmailcheckBox";
            this.EmailcheckBox.Size = new System.Drawing.Size(192, 26);
            this.EmailcheckBox.TabIndex = 0;
            this.EmailcheckBox.Text = "Email Notification to:";
            this.EmailcheckBox.UseVisualStyleBackColor = true;
            // 
            // NumcheckBox
            // 
            this.NumcheckBox.AutoSize = true;
            this.NumcheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NumcheckBox.Location = new System.Drawing.Point(46, 234);
            this.NumcheckBox.Name = "NumcheckBox";
            this.NumcheckBox.Size = new System.Drawing.Size(184, 26);
            this.NumcheckBox.TabIndex = 0;
            this.NumcheckBox.Text = "Text Notification to:";
            this.NumcheckBox.UseVisualStyleBackColor = true;
            // 
            // Subbutton
            // 
            this.Subbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Subbutton.Location = new System.Drawing.Point(46, 378);
            this.Subbutton.Name = "Subbutton";
            this.Subbutton.Size = new System.Drawing.Size(205, 41);
            this.Subbutton.TabIndex = 2;
            this.Subbutton.Text = "Subscribe";
            this.Subbutton.UseVisualStyleBackColor = true;
            this.Subbutton.Click += new System.EventHandler(this.Subbutton_Click);
            // 
            // UnSubbutton
            // 
            this.UnSubbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UnSubbutton.Location = new System.Drawing.Point(313, 378);
            this.UnSubbutton.Name = "UnSubbutton";
            this.UnSubbutton.Size = new System.Drawing.Size(193, 41);
            this.UnSubbutton.TabIndex = 2;
            this.UnSubbutton.Text = "Unsubscribe";
            this.UnSubbutton.UseVisualStyleBackColor = true;
            this.UnSubbutton.Click += new System.EventHandler(this.UnSubbutton_Click);
            // 
            // BTMbutton
            // 
            this.BTMbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BTMbutton.Location = new System.Drawing.Point(550, 378);
            this.BTMbutton.Name = "BTMbutton";
            this.BTMbutton.Size = new System.Drawing.Size(222, 41);
            this.BTMbutton.TabIndex = 2;
            this.BTMbutton.Text = "Back to Main Window";
            this.BTMbutton.UseVisualStyleBackColor = true;
            this.BTMbutton.Click += new System.EventHandler(this.BTMbutton_Click);
            // 
            // EmailtextBox
            // 
            this.EmailtextBox.Location = new System.Drawing.Point(331, 75);
            this.EmailtextBox.Name = "EmailtextBox";
            this.EmailtextBox.Size = new System.Drawing.Size(384, 21);
            this.EmailtextBox.TabIndex = 3;
            this.EmailtextBox.TextChanged += new System.EventHandler(this.EmailtextBox_TextChanged);
            // 
            // NumtextBox
            // 
            this.NumtextBox.Location = new System.Drawing.Point(331, 236);
            this.NumtextBox.Name = "NumtextBox";
            this.NumtextBox.Size = new System.Drawing.Size(384, 21);
            this.NumtextBox.TabIndex = 3;
            this.NumtextBox.TextChanged += new System.EventHandler(this.NumtextBox_TextChanged);
            // 
            // Invlabel
            // 
            this.Invlabel.AutoSize = true;
            this.Invlabel.ForeColor = System.Drawing.Color.Red;
            this.Invlabel.Location = new System.Drawing.Point(345, 130);
            this.Invlabel.Name = "Invlabel";
            this.Invlabel.Size = new System.Drawing.Size(76, 15);
            this.Invlabel.TabIndex = 4;
            this.Invlabel.Text = "Invalid email";
            this.Invlabel.Visible = false;
            // 
            // InvNlabel
            // 
            this.InvNlabel.AutoSize = true;
            this.InvNlabel.ForeColor = System.Drawing.Color.Red;
            this.InvNlabel.Location = new System.Drawing.Point(345, 288);
            this.InvNlabel.Name = "InvNlabel";
            this.InvNlabel.Size = new System.Drawing.Size(96, 15);
            this.InvNlabel.TabIndex = 5;
            this.InvNlabel.Text = "Invalid Number!!";
            this.InvNlabel.Visible = false;
            // 
            // Subscription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.InvNlabel);
            this.Controls.Add(this.Invlabel);
            this.Controls.Add(this.NumtextBox);
            this.Controls.Add(this.EmailtextBox);
            this.Controls.Add(this.BTMbutton);
            this.Controls.Add(this.UnSubbutton);
            this.Controls.Add(this.Subbutton);
            this.Controls.Add(this.NumcheckBox);
            this.Controls.Add(this.EmailcheckBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Subscription";
            this.Text = "Manage Notification Subscription";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox EmailcheckBox;
        private System.Windows.Forms.CheckBox NumcheckBox;
        private System.Windows.Forms.Button Subbutton;
        private System.Windows.Forms.Button UnSubbutton;
        private System.Windows.Forms.Button BTMbutton;
        private System.Windows.Forms.TextBox EmailtextBox;
        private System.Windows.Forms.TextBox NumtextBox;
        private System.Windows.Forms.Label Invlabel;
        private System.Windows.Forms.Label InvNlabel;
    }
}