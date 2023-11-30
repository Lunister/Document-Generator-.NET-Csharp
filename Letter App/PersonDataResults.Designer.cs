using Color = System.Drawing.Color;
using Point = System.Drawing.Point;
using Size = System.Drawing.Size;
using SizeF = System.Drawing.SizeF;

namespace Letter_App
{
    partial class PersonDataResults
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
            dataGridView1 = new DataGridView();
            Select = new DataGridViewCheckBoxColumn();
            button3 = new Button();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label3 = new Label();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            label2 = new Label();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Select });
            dataGridView1.Location = new Point(12, 142);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(656, 513);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Select
            // 
            Select.HeaderText = "Select";
            Select.Name = "Select";
            // 
            // button3
            // 
            button3.Location = new Point(762, 142);
            button3.Name = "button3";
            button3.Size = new Size(196, 42);
            button3.TabIndex = 7;
            button3.Text = "Export as Word File";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.Location = new Point(762, 214);
            button1.Name = "button1";
            button1.Size = new Size(196, 42);
            button1.TabIndex = 8;
            button1.Text = "Export as PDF";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button2.BackColor = Color.Red;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(762, 573);
            button2.Name = "button2";
            button2.Padding = new Padding(10);
            button2.Size = new Size(196, 42);
            button2.TabIndex = 9;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 57);
            label1.Name = "label1";
            label1.Size = new Size(290, 21);
            label1.TabIndex = 10;
            label1.Text = "Review the details of the entered people:";
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(589, 57);
            label3.Name = "label3";
            label3.Size = new Size(75, 21);
            label3.TabIndex = 12;
            label3.Text = "Template:";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.Location = new Point(470, 97);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(103, 29);
            checkBox1.TabIndex = 14;
            checkBox1.Text = "Combine";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(12, 117);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(74, 19);
            checkBox2.TabIndex = 15;
            checkBox2.Text = "Select All";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(670, 57);
            label2.Name = "label2";
            label2.Size = new Size(48, 21);
            label2.TabIndex = 16;
            label2.Text = "None";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // button4
            // 
            button4.Location = new Point(589, 98);
            button4.Name = "button4";
            button4.Size = new Size(79, 29);
            button4.TabIndex = 17;
            button4.Text = "Select";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // PersonDataResults
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1028, 667);
            Controls.Add(button4);
            Controls.Add(label2);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(button3);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PersonDataResults";
            Text = "PersonDataResults";
            Load += PersonDataResults_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button3;
        private Button button1;
        private Button button2;
        private Label label1;
        private Label label3;
        private CheckBox checkBox1;
        private DataGridViewCheckBoxColumn Select;
        private CheckBox checkBox2;
        private Label label2;
        private Button button4;
    }
}