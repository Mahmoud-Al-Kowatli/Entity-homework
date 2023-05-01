namespace myHomeWorkForm
{
    partial class Form7
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
            richTextBox1 = new RichTextBox();
            button1 = new Button();
            label1 = new Label();
            txt_findStudentSameDept = new TextBox();
            button2 = new Button();
            txt_findStudentGetExam = new TextBox();
            button3 = new Button();
            txt_findStudentNotGetExam = new TextBox();
            button4 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txt_findSubjectStudent = new TextBox();
            button5 = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(39, 29);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(669, 103);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // button1
            // 
            button1.Location = new Point(342, 148);
            button1.Name = "button1";
            button1.Size = new Size(234, 23);
            button1.TabIndex = 1;
            button1.Text = "show student the same department";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(167, 156);
            label1.Name = "label1";
            label1.Size = new Size(153, 15);
            label1.TabIndex = 2;
            label1.Text = "الطلاب المتواجدة في كل قسم";
            // 
            // txt_findStudentSameDept
            // 
            txt_findStudentSameDept.Location = new Point(170, 190);
            txt_findStudentSameDept.Name = "txt_findStudentSameDept";
            txt_findStudentSameDept.Size = new Size(150, 23);
            txt_findStudentSameDept.TabIndex = 3;
            // 
            // button2
            // 
            button2.Location = new Point(342, 190);
            button2.Name = "button2";
            button2.Size = new Size(234, 23);
            button2.TabIndex = 4;
            button2.Text = "show student the same department";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txt_findStudentGetExam
            // 
            txt_findStudentGetExam.Location = new Point(170, 231);
            txt_findStudentGetExam.Name = "txt_findStudentGetExam";
            txt_findStudentGetExam.Size = new Size(150, 23);
            txt_findStudentGetExam.TabIndex = 5;
            // 
            // button3
            // 
            button3.Location = new Point(342, 230);
            button3.Name = "button3";
            button3.Size = new Size(234, 23);
            button3.TabIndex = 6;
            button3.Text = "show student who get Exam";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // txt_findStudentNotGetExam
            // 
            txt_findStudentNotGetExam.Location = new Point(170, 272);
            txt_findStudentNotGetExam.Name = "txt_findStudentNotGetExam";
            txt_findStudentNotGetExam.Size = new Size(150, 23);
            txt_findStudentNotGetExam.TabIndex = 7;
            // 
            // button4
            // 
            button4.Location = new Point(342, 272);
            button4.Name = "button4";
            button4.Size = new Size(234, 23);
            button4.TabIndex = 8;
            button4.Text = "show student who not get Exam";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 194);
            label2.Name = "label2";
            label2.Size = new Size(120, 15);
            label2.TabIndex = 9;
            label2.Text = "Put Id Of Department";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(69, 239);
            label3.Name = "label3";
            label3.Size = new Size(86, 15);
            label3.TabIndex = 10;
            label3.Text = "Put Id Of Exam";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(69, 276);
            label4.Name = "label4";
            label4.Size = new Size(86, 15);
            label4.TabIndex = 11;
            label4.Text = "Put Id Of Exam";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(57, 315);
            label5.Name = "label5";
            label5.Size = new Size(98, 15);
            label5.TabIndex = 12;
            label5.Text = "Put Id Of Student";
            // 
            // txt_findSubjectStudent
            // 
            txt_findSubjectStudent.Location = new Point(167, 307);
            txt_findSubjectStudent.Name = "txt_findSubjectStudent";
            txt_findSubjectStudent.Size = new Size(150, 23);
            txt_findSubjectStudent.TabIndex = 13;
            // 
            // button5
            // 
            button5.Location = new Point(342, 311);
            button5.Name = "button5";
            button5.Size = new Size(234, 23);
            button5.TabIndex = 14;
            button5.Text = "show List Subject of Student";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(249, 367);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 23);
            textBox1.TabIndex = 15;
            textBox1.Leave += textBox1_Leave;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(button5);
            Controls.Add(txt_findSubjectStudent);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button4);
            Controls.Add(txt_findStudentNotGetExam);
            Controls.Add(button3);
            Controls.Add(txt_findStudentGetExam);
            Controls.Add(button2);
            Controls.Add(txt_findStudentSameDept);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(richTextBox1);
            Name = "Form7";
            Text = "Form7";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private Button button1;
        private Label label1;
        private TextBox txt_findStudentSameDept;
        private Button button2;
        private TextBox txt_findStudentGetExam;
        private Button button3;
        private TextBox txt_findStudentNotGetExam;
        private Button button4;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txt_findSubjectStudent;
        private Button button5;
        private TextBox textBox1;
    }
}