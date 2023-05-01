namespace myHomeWorkForm
{
    partial class Form3
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
            btn_deleteSubjectById = new Button();
            btn_update = new Button();
            btn_findSubjectById = new Button();
            findSubject = new TextBox();
            button2 = new Button();
            txt_Year = new TextBox();
            txt_Term = new TextBox();
            txt_MinimumDegree = new TextBox();
            txt_Subjectname = new TextBox();
            txt_SubjectID = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label16 = new Label();
            richTextBox1 = new RichTextBox();
            btn_showAllSubject = new Button();
            txt_show_subjectYear = new TextBox();
            txt_show_subjectTerm = new TextBox();
            txt_show_subjectMinim = new TextBox();
            txt_show_subjectName = new TextBox();
            txt_show_subjectid = new TextBox();
            label3 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(246, -1);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 0;
            label1.Text = "The Subjects";
            // 
            // btn_deleteSubjectById
            // 
            btn_deleteSubjectById.Location = new Point(410, 292);
            btn_deleteSubjectById.Name = "btn_deleteSubjectById";
            btn_deleteSubjectById.Size = new Size(161, 23);
            btn_deleteSubjectById.TabIndex = 70;
            btn_deleteSubjectById.Text = "Delete Student By Id";
            btn_deleteSubjectById.UseVisualStyleBackColor = true;
            btn_deleteSubjectById.Click += btn_deleteSubjectById_Click;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(226, 418);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(161, 23);
            btn_update.TabIndex = 69;
            btn_update.Text = "Save the Change";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // btn_findSubjectById
            // 
            btn_findSubjectById.Location = new Point(226, 292);
            btn_findSubjectById.Name = "btn_findSubjectById";
            btn_findSubjectById.Size = new Size(161, 23);
            btn_findSubjectById.TabIndex = 54;
            btn_findSubjectById.Text = "find student by id";
            btn_findSubjectById.UseVisualStyleBackColor = true;
            btn_findSubjectById.Click += btn_findSubjectById_Click;
            // 
            // findSubject
            // 
            findSubject.Location = new Point(14, 293);
            findSubject.Name = "findSubject";
            findSubject.Size = new Size(183, 23);
            findSubject.TabIndex = 53;
            // 
            // button2
            // 
            button2.Location = new Point(199, 249);
            button2.Name = "button2";
            button2.Size = new Size(161, 23);
            button2.TabIndex = 52;
            button2.Text = "Add New Subject";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txt_Year
            // 
            txt_Year.Location = new Point(398, 205);
            txt_Year.Name = "txt_Year";
            txt_Year.Size = new Size(100, 23);
            txt_Year.TabIndex = 50;
            // 
            // txt_Term
            // 
            txt_Term.Location = new Point(398, 176);
            txt_Term.Name = "txt_Term";
            txt_Term.Size = new Size(100, 23);
            txt_Term.TabIndex = 49;
            // 
            // txt_MinimumDegree
            // 
            txt_MinimumDegree.Location = new Point(398, 145);
            txt_MinimumDegree.Name = "txt_MinimumDegree";
            txt_MinimumDegree.Size = new Size(100, 23);
            txt_MinimumDegree.TabIndex = 48;
            // 
            // txt_Subjectname
            // 
            txt_Subjectname.Location = new Point(116, 205);
            txt_Subjectname.Name = "txt_Subjectname";
            txt_Subjectname.Size = new Size(100, 23);
            txt_Subjectname.TabIndex = 46;
            // 
            // txt_SubjectID
            // 
            txt_SubjectID.Location = new Point(116, 157);
            txt_SubjectID.Name = "txt_SubjectID";
            txt_SubjectID.Size = new Size(100, 23);
            txt_SubjectID.TabIndex = 45;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(328, 213);
            label6.Name = "label6";
            label6.Size = new Size(29, 15);
            label6.TabIndex = 43;
            label6.Text = "Year";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(324, 184);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 42;
            label5.Text = "Term";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(275, 148);
            label4.Name = "label4";
            label4.Size = new Size(100, 15);
            label4.TabIndex = 41;
            label4.Text = "Minimum Degree";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 213);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 39;
            label2.Text = "Name";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(20, 160);
            label16.Name = "label16";
            label16.Size = new Size(66, 15);
            label16.TabIndex = 38;
            label16.Text = "Subject ID :";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(-1, 17);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(588, 76);
            richTextBox1.TabIndex = 37;
            richTextBox1.Text = "";
            // 
            // btn_showAllSubject
            // 
            btn_showAllSubject.Location = new Point(199, 111);
            btn_showAllSubject.Name = "btn_showAllSubject";
            btn_showAllSubject.Size = new Size(161, 23);
            btn_showAllSubject.TabIndex = 36;
            btn_showAllSubject.Text = "Show All Subject";
            btn_showAllSubject.UseVisualStyleBackColor = true;
            btn_showAllSubject.Click += btn_showAllSubject_Click;
            // 
            // txt_show_subjectYear
            // 
            txt_show_subjectYear.Location = new Point(410, 389);
            txt_show_subjectYear.Name = "txt_show_subjectYear";
            txt_show_subjectYear.Size = new Size(100, 23);
            txt_show_subjectYear.TabIndex = 80;
            // 
            // txt_show_subjectTerm
            // 
            txt_show_subjectTerm.Location = new Point(410, 360);
            txt_show_subjectTerm.Name = "txt_show_subjectTerm";
            txt_show_subjectTerm.Size = new Size(100, 23);
            txt_show_subjectTerm.TabIndex = 79;
            // 
            // txt_show_subjectMinim
            // 
            txt_show_subjectMinim.Location = new Point(410, 329);
            txt_show_subjectMinim.Name = "txt_show_subjectMinim";
            txt_show_subjectMinim.Size = new Size(100, 23);
            txt_show_subjectMinim.TabIndex = 78;
            // 
            // txt_show_subjectName
            // 
            txt_show_subjectName.Location = new Point(128, 389);
            txt_show_subjectName.Name = "txt_show_subjectName";
            txt_show_subjectName.Size = new Size(100, 23);
            txt_show_subjectName.TabIndex = 77;
            // 
            // txt_show_subjectid
            // 
            txt_show_subjectid.Location = new Point(128, 341);
            txt_show_subjectid.Name = "txt_show_subjectid";
            txt_show_subjectid.Size = new Size(100, 23);
            txt_show_subjectid.TabIndex = 76;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(340, 397);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 75;
            label3.Text = "Year";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(336, 368);
            label7.Name = "label7";
            label7.Size = new Size(33, 15);
            label7.TabIndex = 74;
            label7.Text = "Term";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(287, 332);
            label8.Name = "label8";
            label8.Size = new Size(100, 15);
            label8.TabIndex = 73;
            label8.Text = "Minimum Degree";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(52, 397);
            label9.Name = "label9";
            label9.Size = new Size(39, 15);
            label9.TabIndex = 72;
            label9.Text = "Name";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(32, 344);
            label10.Name = "label10";
            label10.Size = new Size(66, 15);
            label10.TabIndex = 71;
            label10.Text = "Subject ID :";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(628, 450);
            Controls.Add(txt_show_subjectYear);
            Controls.Add(txt_show_subjectTerm);
            Controls.Add(txt_show_subjectMinim);
            Controls.Add(txt_show_subjectName);
            Controls.Add(txt_show_subjectid);
            Controls.Add(label3);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(btn_deleteSubjectById);
            Controls.Add(btn_update);
            Controls.Add(btn_findSubjectById);
            Controls.Add(findSubject);
            Controls.Add(button2);
            Controls.Add(txt_Year);
            Controls.Add(txt_Term);
            Controls.Add(txt_MinimumDegree);
            Controls.Add(txt_Subjectname);
            Controls.Add(txt_SubjectID);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label16);
            Controls.Add(richTextBox1);
            Controls.Add(btn_showAllSubject);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btn_deleteSubjectById;
        private Button btn_update;
        private Button btn_findSubjectById;
        private TextBox findSubject;
        private Button button2;
        private TextBox txt_department;
        private TextBox txt_Year;
        private TextBox txt_Term;
        private TextBox txt_MinimumDegree;
        private TextBox txt_lastname;
        private TextBox txt_Subjectname;
        private TextBox txt_SubjectID;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label16;
        private RichTextBox richTextBox1;
        private Button btn_showAllSubject;
        private TextBox txt_show_subjectYear;
        private TextBox txt_show_subjectTerm;
        private TextBox txt_show_subjectMinim;
        private TextBox txt_show_subjectName;
        private TextBox txt_show_subjectid;
        private Label label8;
        private Label label9;
        private Label label10;
    }
}