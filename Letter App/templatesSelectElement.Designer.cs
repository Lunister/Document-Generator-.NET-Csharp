using Color = System.Drawing.Color;
using Point = System.Drawing.Point;
using Size = System.Drawing.Size;
using SizeF = System.Drawing.SizeF;
namespace Letter_App
{
    public partial class templatesSelectElement
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            create_letters_button = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(3, 140);
            button1.Name = "button1";
            button1.Size = new Size(152, 35);
            button1.TabIndex = 4;
            button1.Text = "View";
            button1.UseVisualStyleBackColor = false;
            // 
            // create_letters_button
            // 
            create_letters_button.AllowDrop = true;
            create_letters_button.AutoSize = true;
            create_letters_button.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            create_letters_button.BackColor = Color.Transparent;
            create_letters_button.BackgroundImageLayout = ImageLayout.None;
            create_letters_button.FlatAppearance.BorderSize = 0;
            create_letters_button.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 224, 192);
            create_letters_button.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 0);
            create_letters_button.FlatStyle = FlatStyle.Flat;
            create_letters_button.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            create_letters_button.ForeColor = SystemColors.ButtonHighlight;
            create_letters_button.Location = new Point(3, 5);
            create_letters_button.Name = "create_letters_button";
            create_letters_button.RightToLeft = RightToLeft.Yes;
            create_letters_button.Size = new Size(112, 29);
            create_letters_button.TabIndex = 3;
            create_letters_button.Text = "Create Letters";
            create_letters_button.UseVisualStyleBackColor = false;
            create_letters_button.Click += create_letters_button_Click;
            // 
            // templatesSelectElement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Salmon;
            Controls.Add(button1);
            Controls.Add(create_letters_button);
            Name = "templatesSelectElement";
            Size = new Size(158, 177);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Button button1;
        public Button create_letters_button;
    }
}
