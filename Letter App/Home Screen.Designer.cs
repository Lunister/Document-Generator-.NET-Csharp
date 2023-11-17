using Color = System.Drawing.Color;
using Point = System.Drawing.Point;
using Size = System.Drawing.Size;
using SizeF = System.Drawing.SizeF;

namespace Letter_App
{
    partial class Home_Screen
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
            create_letters_button = new Button();
            button1 = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // create_letters_button
            // 
            create_letters_button.AllowDrop = true;
            create_letters_button.AutoSize = true;
            create_letters_button.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            create_letters_button.BackColor = Color.OrangeRed;
            create_letters_button.FlatAppearance.BorderSize = 0;
            create_letters_button.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 224, 192);
            create_letters_button.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 0);
            create_letters_button.FlatStyle = FlatStyle.Flat;
            create_letters_button.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            create_letters_button.ForeColor = SystemColors.ButtonHighlight;
            create_letters_button.Location = new Point(12, 130);
            create_letters_button.Name = "create_letters_button";
            create_letters_button.Padding = new Padding(20, 70, 20, 70);
            create_letters_button.Size = new Size(184, 175);
            create_letters_button.TabIndex = 0;
            create_letters_button.Text = "Create Letters";
            create_letters_button.UseVisualStyleBackColor = false;
            create_letters_button.Click += create_letters_button_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Control;
            button1.BackgroundImage = Properties.Resources.shutdown;
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(12, 513);
            button1.Name = "button1";
            button1.Size = new Size(46, 40);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(179, 43);
            label1.Name = "label1";
            label1.Size = new Size(109, 25);
            label1.TabIndex = 2;
            label1.Text = "Dashboard";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.Trans_Logo;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(139, 78);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // Home_Screen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(877, 565);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(create_letters_button);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Home_Screen";
            Text = "Home_Screen";
            Load += Home_Screen_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button create_letters_button;
        private Button button1;
        private Label label1;
        private PictureBox pictureBox1;
    }
}