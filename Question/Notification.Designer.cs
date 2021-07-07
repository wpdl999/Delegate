
namespace Question
{
    partial class Notification
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Managebutton = new System.Windows.Forms.Button();
            this.Pubbutton = new System.Windows.Forms.Button();
            this.Exitbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Managebutton
            // 
            this.Managebutton.Location = new System.Drawing.Point(71, 72);
            this.Managebutton.Name = "Managebutton";
            this.Managebutton.Size = new System.Drawing.Size(175, 55);
            this.Managebutton.TabIndex = 0;
            this.Managebutton.Text = "Manage Subscription";
            this.Managebutton.UseVisualStyleBackColor = true;
            this.Managebutton.Click += new System.EventHandler(this.Managebutton_Click);
            // 
            // Pubbutton
            // 
            this.Pubbutton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Pubbutton.Location = new System.Drawing.Point(325, 72);
            this.Pubbutton.Name = "Pubbutton";
            this.Pubbutton.Size = new System.Drawing.Size(164, 55);
            this.Pubbutton.TabIndex = 0;
            this.Pubbutton.Text = "Publish Notification";
            this.Pubbutton.UseVisualStyleBackColor = false;
            this.Pubbutton.Click += new System.EventHandler(this.Pubbutton_Click);
            // 
            // Exitbutton
            // 
            this.Exitbutton.Location = new System.Drawing.Point(568, 72);
            this.Exitbutton.Name = "Exitbutton";
            this.Exitbutton.Size = new System.Drawing.Size(171, 55);
            this.Exitbutton.TabIndex = 0;
            this.Exitbutton.Text = "Exit";
            this.Exitbutton.UseVisualStyleBackColor = true;
            this.Exitbutton.Click += new System.EventHandler(this.Exitbutton_Click);
            // 
            // Notification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(830, 210);
            this.Controls.Add(this.Exitbutton);
            this.Controls.Add(this.Pubbutton);
            this.Controls.Add(this.Managebutton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Notification";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notification Manager";
            this.TransparencyKey = System.Drawing.Color.DimGray;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Managebutton;
        private System.Windows.Forms.Button Pubbutton;
        private System.Windows.Forms.Button Exitbutton;
    }
}

