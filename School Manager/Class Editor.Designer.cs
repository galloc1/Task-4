namespace School_Manager
{
    partial class Class_Editor
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
            components = new System.ComponentModel.Container();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            listBox1 = new ListBox();
            classBindingSource1 = new BindingSource(components);
            classBindingSource = new BindingSource(components);
            studentsBindingSource = new BindingSource(components);
            studentsBindingSource1 = new BindingSource(components);
            label3 = new Label();
            button3 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)classBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)classBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)studentsBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)studentsBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(45, 334);
            button1.Name = "button1";
            button1.Size = new Size(102, 33);
            button1.TabIndex = 0;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(189, 24);
            label1.Name = "label1";
            label1.Size = new Size(101, 25);
            label1.TabIndex = 6;
            label1.Text = "Class View";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(201, 79);
            label2.Name = "label2";
            label2.Size = new Size(74, 21);
            label2.TabIndex = 7;
            label2.Text = "Class List";
            // 
            // listBox1
            // 
            listBox1.DataSource = classBindingSource1;
            listBox1.DisplayMember = "name";
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(26, 103);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(420, 214);
            listBox1.TabIndex = 8;
            listBox1.ValueMember = "students";
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // classBindingSource1
            // 
            classBindingSource1.DataSource = typeof(Class);
            // 
            // classBindingSource
            // 
            classBindingSource.DataSource = typeof(Class);
            // 
            // studentsBindingSource
            // 
            studentsBindingSource.DataMember = "students";
            studentsBindingSource.DataSource = classBindingSource;
            // 
            // studentsBindingSource1
            // 
            studentsBindingSource1.DataMember = "students";
            studentsBindingSource1.DataSource = classBindingSource;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(99, 49);
            label3.Name = "label3";
            label3.Size = new Size(275, 15);
            label3.TabIndex = 9;
            label3.Text = "Choose a class from the list below to edit its details";
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(186, 334);
            button3.Name = "button3";
            button3.Size = new Size(102, 33);
            button3.TabIndex = 10;
            button3.Text = "Edit Class";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(323, 334);
            button2.Name = "button2";
            button2.Size = new Size(106, 33);
            button2.TabIndex = 11;
            button2.Text = "New Class";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // Class_Editor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(479, 385);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(label3);
            Controls.Add(listBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Class_Editor";
            Text = "Class Editor";
            FormClosing += Class_Editor_FormClosing;
            ((System.ComponentModel.ISupportInitialize)classBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)classBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)studentsBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)studentsBindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        public ListBox listBox1;
        private BindingSource classBindingSource;
        private BindingSource studentsBindingSource;
        private BindingSource studentsBindingSource1;
        private Label label3;
        private Button button3;
        private BindingSource classBindingSource1;
        private Button button2;
    }
}