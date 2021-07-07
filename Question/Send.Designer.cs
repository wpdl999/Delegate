
namespace Question
{
    partial class Send
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
            this.label1 = new System.Windows.Forms.Label();
            this.notifiListBox = new System.Windows.Forms.ListBox();
            this.PUBbutton = new System.Windows.Forms.Button();
            this.BackToMbutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SublistBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Notification Details:";
            // 
            // notifiListBox
            // 
            this.notifiListBox.FormattingEnabled = true;
            this.notifiListBox.ItemHeight = 20;
            this.notifiListBox.Items.AddRange(new object[] {
            "hello, this is a test notification"});
            this.notifiListBox.Location = new System.Drawing.Point(25, 63);
            this.notifiListBox.Name = "notifiListBox";
            this.notifiListBox.Size = new System.Drawing.Size(763, 84);
            this.notifiListBox.TabIndex = 1;
            // 
            // PUBbutton
            // 
            this.PUBbutton.Location = new System.Drawing.Point(93, 191);
            this.PUBbutton.Name = "PUBbutton";
            this.PUBbutton.Size = new System.Drawing.Size(228, 82);
            this.PUBbutton.TabIndex = 2;
            this.PUBbutton.Text = "Publish";
            this.PUBbutton.UseVisualStyleBackColor = true;
            this.PUBbutton.Click += new System.EventHandler(this.PUBbutton_Click);
            // 
            // BackToMbutton
            // 
            this.BackToMbutton.Location = new System.Drawing.Point(465, 191);
            this.BackToMbutton.Name = "BackToMbutton";
            this.BackToMbutton.Size = new System.Drawing.Size(230, 82);
            this.BackToMbutton.TabIndex = 2;
            this.BackToMbutton.Text = "Back to Main Window";
            this.BackToMbutton.UseVisualStyleBackColor = true;
            this.BackToMbutton.Click += new System.EventHandler(this.BackToMbutton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(414, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Notification has been sent to following subscribers:";
            // 
            // SublistBox
            // 
            this.SublistBox.FormattingEnabled = true;
            this.SublistBox.ItemHeight = 20;
            this.SublistBox.Location = new System.Drawing.Point(25, 361);
            this.SublistBox.Name = "SublistBox";
            this.SublistBox.Size = new System.Drawing.Size(763, 204);
            this.SublistBox.TabIndex = 4;
            // 
            // Send
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 575);
            this.Controls.Add(this.SublistBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BackToMbutton);
            this.Controls.Add(this.PUBbutton);
            this.Controls.Add(this.notifiListBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Send";
            this.Text = "Send Notification";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox notifiListBox;
        private System.Windows.Forms.Button PUBbutton;
        private System.Windows.Forms.Button BackToMbutton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox SublistBox;
    }
}