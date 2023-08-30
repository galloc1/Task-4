namespace School_Manager
{
    partial class Teacher_Home_Page
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
            button1 = new Button();
            label2 = new Label();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(121, 9);
            label1.Name = "label1";
            label1.Size = new Size(199, 32);
            label1.TabIndex = 0;
            label1.Text = "Welcome to SMS";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(146, 167);
            button1.Name = "button1";
            button1.Size = new Size(151, 32);
            button1.TabIndex = 1;
            button1.Text = "Log Out";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(121, 52);
            label2.Name = "label2";
            label2.Size = new Size(196, 15);
            label2.TabIndex = 4;
            label2.Text = "Take the roll using the button below";
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(146, 104);
            button3.Name = "button3";
            button3.Size = new Size(151, 33);
            button3.TabIndex = 3;
            button3.Text = "Take Roll";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Teacher_Home_Page
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(455, 231);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Teacher_Home_Page";
            Text = "Teacher Home Page";
            FormClosing += Teacher_Home_Page_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Label label2;
        private Button button3;
    }
}