namespace myHomeWorkForm
{
    partial class Form5
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
            btn_deleteStudentExamById = new Button();
            btn_findStudentExamById = new Button();
            txt_show_mark = new TextBox();
            txt_show_StudentId = new TextBox();
            txt_show_ExamtId = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btn_update = new Button();
            findStudentExam = new TextBox();
            btn_AddStudentMark = new Button();
            txt_Mark = new TextBox();
            txt_ExamId = new TextBox();
            txt_StudentID = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label16 = new Label();
            richTextBox1 = new RichTextBox();
            btn_showAllStudentMarks = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btn_deleteStudentExamById
            // 
            btn_deleteStudentExamById.Location = new Point(427, 283);
            btn_deleteStudentExamById.Name = "btn_deleteStudentExamById";
            btn_deleteStudentExamById.Size = new Size(161, 23);
            btn_deleteStudentExamById.TabIndex = 126;
            btn_deleteStudentExamById.Text = "Delete Student Exam By Id";
            btn_deleteStudentExamById.UseVisualStyleBackColor = true;
            btn_deleteStudentExamById.Click += btn_deleteStudentExamById_Click;
            // 
            // btn_findStudentExamById
            // 
            btn_findStudentExamById.Location = new Point(240, 283);
            btn_findStudentExamById.Name = "btn_findStudentExamById";
            btn_findStudentExamById.Size = new Size(161, 23);
            btn_findStudentExamById.TabIndex = 125;
            btn_findStudentExamById.Text = "Find Student ExamBy Id";
            btn_findStudentExamById.UseVisualStyleBackColor = true;
            btn_findStudentExamById.Click += btn_findStudentExamById_Click;
            // 
            // txt_show_mark
            // 
            txt_show_mark.Location = new Point(511, 335);
            txt_show_mark.Name = "txt_show_mark";
            txt_show_mark.Size = new Size(100, 23);
            txt_show_mark.TabIndex = 124;
            // 
            // txt_show_StudentId
            // 
            txt_show_StudentId.Location = new Point(337, 335);
            txt_show_StudentId.Name = "txt_show_StudentId";
            txt_show_StudentId.Size = new Size(100, 23);
            txt_show_StudentId.TabIndex = 123;
            // 
            // txt_show_ExamtId
            // 
            txt_show_ExamtId.Location = new Point(147, 335);
            txt_show_ExamtId.Name = "txt_show_ExamtId";
            txt_show_ExamtId.Size = new Size(100, 23);
            txt_show_ExamtId.TabIndex = 122;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(460, 343);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 121;
            label2.Text = "Mark";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(262, 343);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 120;
            label3.Text = "Student ID :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(75, 343);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 119;
            label4.Text = "Exam ID :";
            // 
            // btn_update
            // 
            btn_update.Location = new Point(249, 386);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(161, 23);
            btn_update.TabIndex = 118;
            btn_update.Text = "Save the Change";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // findStudentExam
            // 
            findStudentExam.Location = new Point(37, 284);
            findStudentExam.Name = "findStudentExam";
            findStudentExam.Size = new Size(183, 23);
            findStudentExam.TabIndex = 117;
            // 
            // btn_AddStudentMark
            // 
            btn_AddStudentMark.Location = new Point(249, 233);
            btn_AddStudentMark.Name = "btn_AddStudentMark";
            btn_AddStudentMark.Size = new Size(161, 23);
            btn_AddStudentMark.TabIndex = 116;
            btn_AddStudentMark.Text = "Add New Student Mark";
            btn_AddStudentMark.UseVisualStyleBackColor = true;
            btn_AddStudentMark.Click += btn_AddStudentMark_Click;
            // 
            // txt_Mark
            // 
            txt_Mark.Location = new Point(478, 187);
            txt_Mark.Name = "txt_Mark";
            txt_Mark.Size = new Size(100, 23);
            txt_Mark.TabIndex = 115;
            // 
            // txt_ExamId
            // 
            txt_ExamId.Location = new Point(310, 187);
            txt_ExamId.Name = "txt_ExamId";
            txt_ExamId.Size = new Size(100, 23);
            txt_ExamId.TabIndex = 114;
            // 
            // txt_StudentID
            // 
            txt_StudentID.Location = new Point(138, 187);
            txt_StudentID.Name = "txt_StudentID";
            txt_StudentID.Size = new Size(100, 23);
            txt_StudentID.TabIndex = 113;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(427, 195);
            label6.Name = "label6";
            label6.Size = new Size(34, 15);
            label6.TabIndex = 112;
            label6.Text = "Mark";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(249, 190);
            label5.Name = "label5";
            label5.Size = new Size(56, 15);
            label5.TabIndex = 111;
            label5.Text = "Exam ID :";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(64, 195);
            label16.Name = "label16";
            label16.Size = new Size(68, 15);
            label16.TabIndex = 110;
            label16.Text = "Student ID :";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(49, 46);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(588, 76);
            richTextBox1.TabIndex = 109;
            richTextBox1.Text = "";
            // 
            // btn_showAllStudentMarks
            // 
            btn_showAllStudentMarks.Location = new Point(219, 140);
            btn_showAllStudentMarks.Name = "btn_showAllStudentMarks";
            btn_showAllStudentMarks.Size = new Size(218, 23);
            btn_showAllStudentMarks.TabIndex = 108;
            btn_showAllStudentMarks.Text = "Show All Student Marks";
            btn_showAllStudentMarks.UseVisualStyleBackColor = true;
            btn_showAllStudentMarks.Click += btn_showAllStudentMarks_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(277, 18);
            label1.Name = "label1";
            label1.Size = new Size(105, 15);
            label1.TabIndex = 107;
            label1.Text = "The Student Marks";
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_deleteStudentExamById);
            Controls.Add(btn_findStudentExamById);
            Controls.Add(txt_show_mark);
            Controls.Add(txt_show_StudentId);
            Controls.Add(txt_show_ExamtId);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(btn_update);
            Controls.Add(findStudentExam);
            Controls.Add(btn_AddStudentMark);
            Controls.Add(txt_Mark);
            Controls.Add(txt_ExamId);
            Controls.Add(txt_StudentID);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label16);
            Controls.Add(richTextBox1);
            Controls.Add(btn_showAllStudentMarks);
            Controls.Add(label1);
            Name = "Form5";
            Text = "Form5";
            Load += Form5_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_deleteStudentExamById;
        private Button btn_findStudentExamById;
        private TextBox txt_show_mark;
        private TextBox txt_show_StudentId;
        private TextBox txt_show_ExamtId;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btn_update;
        private TextBox findStudentExam;
        private Button btn_AddStudentMark;
        private TextBox txt_Mark;
        private TextBox txt_ExamId;
        private TextBox txt_StudentID;
        private Label label6;
        private Label label5;
        private Label label16;
        private RichTextBox richTextBox1;
        private Button btn_showAllStudentMarks;
        private Label label1;
    }
}