namespace myHomeWorkForm
{
    partial class Form4
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
            btn_update = new Button();
            findExam = new TextBox();
            btn_AddExam = new Button();
            txt_Date = new TextBox();
            txt_SubjectID = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label16 = new Label();
            richTextBox1 = new RichTextBox();
            btn_showAllExam = new Button();
            label1 = new Label();
            txt_Term = new TextBox();
            txt_show_date = new TextBox();
            txt_show_term = new TextBox();
            txt_show_ExamtId = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btn_findExamById = new Button();
            btn_deleteExamById = new Button();
            SuspendLayout();
            // 
            // btn_update
            // 
            btn_update.Location = new Point(235, 354);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(161, 23);
            btn_update.TabIndex = 97;
            btn_update.Text = "Save the Change";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // findExam
            // 
            findExam.Location = new Point(23, 252);
            findExam.Name = "findExam";
            findExam.Size = new Size(183, 23);
            findExam.TabIndex = 95;
            // 
            // btn_AddExam
            // 
            btn_AddExam.Location = new Point(235, 201);
            btn_AddExam.Name = "btn_AddExam";
            btn_AddExam.Size = new Size(161, 23);
            btn_AddExam.TabIndex = 94;
            btn_AddExam.Text = "Add New Exam";
            btn_AddExam.UseVisualStyleBackColor = true;
            btn_AddExam.Click += btn_AddExam_Click;
            // 
            // txt_Date
            // 
            txt_Date.Location = new Point(464, 155);
            txt_Date.Name = "txt_Date";
            txt_Date.Size = new Size(100, 23);
            txt_Date.TabIndex = 93;
            txt_Date.TextChanged += txt_Year_TextChanged;
            // 
            // txt_SubjectID
            // 
            txt_SubjectID.Location = new Point(133, 155);
            txt_SubjectID.Name = "txt_SubjectID";
            txt_SubjectID.Size = new Size(100, 23);
            txt_SubjectID.TabIndex = 89;
            txt_SubjectID.TextChanged += txt_SubjectID_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(413, 163);
            label6.Name = "label6";
            label6.Size = new Size(31, 15);
            label6.TabIndex = 88;
            label6.Text = "Date";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(248, 163);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 87;
            label5.Text = "Term";
            label5.Click += label5_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(61, 163);
            label16.Name = "label16";
            label16.Size = new Size(66, 15);
            label16.TabIndex = 84;
            label16.Text = "Subject ID :";
            label16.Click += label16_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(35, 14);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(588, 76);
            richTextBox1.TabIndex = 83;
            richTextBox1.Text = "";
            // 
            // btn_showAllExam
            // 
            btn_showAllExam.Location = new Point(235, 109);
            btn_showAllExam.Name = "btn_showAllExam";
            btn_showAllExam.Size = new Size(161, 23);
            btn_showAllExam.TabIndex = 82;
            btn_showAllExam.Text = "Show All Subject";
            btn_showAllExam.UseVisualStyleBackColor = true;
            btn_showAllExam.Click += btn_showAllExam_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(282, -4);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 81;
            label1.Text = "The Exams";
            // 
            // txt_Term
            // 
            txt_Term.Location = new Point(287, 155);
            txt_Term.Name = "txt_Term";
            txt_Term.Size = new Size(100, 23);
            txt_Term.TabIndex = 92;
            txt_Term.TextChanged += txt_Term_TextChanged;
            // 
            // txt_show_date
            // 
            txt_show_date.Location = new Point(464, 303);
            txt_show_date.Name = "txt_show_date";
            txt_show_date.Size = new Size(100, 23);
            txt_show_date.TabIndex = 104;
            // 
            // txt_show_term
            // 
            txt_show_term.Location = new Point(287, 303);
            txt_show_term.Name = "txt_show_term";
            txt_show_term.Size = new Size(100, 23);
            txt_show_term.TabIndex = 103;
            // 
            // txt_show_ExamtId
            // 
            txt_show_ExamtId.Location = new Point(133, 303);
            txt_show_ExamtId.Name = "txt_show_ExamtId";
            txt_show_ExamtId.Size = new Size(100, 23);
            txt_show_ExamtId.TabIndex = 102;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(413, 311);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 101;
            label2.Text = "Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(248, 311);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 100;
            label3.Text = "Term";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(61, 311);
            label4.Name = "label4";
            label4.Size = new Size(66, 15);
            label4.TabIndex = 99;
            label4.Text = "Subject ID :";
            // 
            // btn_findExamById
            // 
            btn_findExamById.Location = new Point(226, 251);
            btn_findExamById.Name = "btn_findExamById";
            btn_findExamById.Size = new Size(161, 23);
            btn_findExamById.TabIndex = 105;
            btn_findExamById.Text = "Find Exam By Id";
            btn_findExamById.UseVisualStyleBackColor = true;
            btn_findExamById.Click += btn_findExamById_Click_1;
            // 
            // btn_deleteExamById
            // 
            btn_deleteExamById.Location = new Point(413, 251);
            btn_deleteExamById.Name = "btn_deleteExamById";
            btn_deleteExamById.Size = new Size(161, 23);
            btn_deleteExamById.TabIndex = 106;
            btn_deleteExamById.Text = "Delete Exam By Id";
            btn_deleteExamById.UseVisualStyleBackColor = true;
            btn_deleteExamById.Click += btn_deleteExamById_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_deleteExamById);
            Controls.Add(btn_findExamById);
            Controls.Add(txt_show_date);
            Controls.Add(txt_show_term);
            Controls.Add(txt_show_ExamtId);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(btn_update);
            Controls.Add(findExam);
            Controls.Add(btn_AddExam);
            Controls.Add(txt_Date);
            Controls.Add(txt_Term);
            Controls.Add(txt_SubjectID);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label16);
            Controls.Add(richTextBox1);
            Controls.Add(btn_showAllExam);
            Controls.Add(label1);
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_show_subjectYear;
        private TextBox txt_show_subjectTerm;
        private TextBox txt_show_subjectMinim;
        private TextBox txt_show_subjectName;
        private TextBox txt_show_subjectid;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Button btn_deleteSubjectById;
        private Button btn_update;
        private Button btn_findSubjectById;
        private TextBox findExam;
        private Button btn_AddExam;
        private TextBox txt_Date;
        private TextBox txt_SubjectID;
        private Label label6;
        private Label label5;
        private Label label16;
        private RichTextBox richTextBox1;
        private Button btn_showAllExam;
        private Label label1;
        private TextBox txt_Term;
        private TextBox txt_show_date;
        private TextBox txt_show_term;
        private TextBox txt_show_ExamtId;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btn_findExamById;
        private Button btn_deleteExamById;
    }
}