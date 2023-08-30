namespace School_Manager
{
    partial class EditClass
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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(184, 9);
            label1.Name = "label1";
            label1.Size = new Size(93, 25);
            label1.TabIndex = 0;
            label1.Text = "Edit Class";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 93);
            label2.Name = "label2";
            label2.Size = new Size(119, 15);
            label2.TabIndex = 1;
            label2.Text = "Add students to class";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(90, 37);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(368, 23);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 40);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 3;
            label3.Text = "Class Name:";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 111);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(220, 214);
            listBox1.TabIndex = 4;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(238, 111);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(220, 214);
            listBox2.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(268, 93);
            label4.Name = "label4";
            label4.Size = new Size(155, 15);
            label4.TabIndex = 6;
            label4.Text = "Remove students from class";
            // 
            // button1
            // 
            button1.Location = new Point(60, 331);
            button1.Name = "button1";
            button1.Size = new Size(118, 23);
            button1.TabIndex = 7;
            button1.Text = "Add Student";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(285, 331);
            button2.Name = "button2";
            button2.Size = new Size(119, 23);
            button2.TabIndex = 8;
            button2.Text = "Remove Student";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(184, 377);
            button3.Name = "button3";
            button3.Size = new Size(93, 23);
            button3.TabIndex = 9;
            button3.Text = "Save Changes";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // EditClass
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(470, 412);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EditClass";
            Text = "EditClass";
            FormClosing += EditClass_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private ListBox listBox1;
        private ListBox listBox2;
        private Label label4;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}