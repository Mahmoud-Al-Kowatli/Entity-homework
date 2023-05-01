namespace myHomeWorkForm
{
    partial class Form6
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
            btn_deleteExamById = new Button();
            btn_findSubjectLecturesById = new Button();
            txt_show_content = new TextBox();
            txt_show_title = new TextBox();
            txt_show_SubjectId = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btn_update = new Button();
            findSubjectLectures = new TextBox();
            btn_AddExam = new Button();
            txt_content = new TextBox();
            txt_Title = new TextBox();
            txt_SubjectID = new TextBox();
            label6 = new Label();
            la = new Label();
            label16 = new Label();
            richTextBox1 = new RichTextBox();
            btn_showAllSubjectLectures = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btn_deleteExamById
            // 
            btn_deleteExamById.Location = new Point(425, 280);
            btn_deleteExamById.Name = "btn_deleteExamById";
            btn_deleteExamById.Size = new Size(161, 23);
            btn_deleteExamById.TabIndex = 126;
            btn_deleteExamById.Text = "Delete Exam By Id";
            btn_deleteExamById.UseVisualStyleBackColor = true;
            btn_deleteExamById.Click += btn_deleteExamById_Click;
            // 
            // btn_findSubjectLecturesById
            // 
            btn_findSubjectLecturesById.Location = new Point(238, 280);
            btn_findSubjectLecturesById.Name = "btn_findSubjectLecturesById";
            btn_findSubjectLecturesById.Size = new Size(161, 23);
            btn_findSubjectLecturesById.TabIndex = 125;
            btn_findSubjectLecturesById.Text = "Find Subject Lectures By Id";
            btn_findSubjectLecturesById.UseVisualStyleBackColor = true;
            btn_findSubjectLecturesById.Click += btn_findSubjectLecturesById_Click;
            // 
            // txt_show_content
            // 
            txt_show_content.Location = new Point(476, 332);
            txt_show_content.Name = "txt_show_content";
            txt_show_content.Size = new Size(100, 23);
            txt_show_content.TabIndex = 124;
            // 
            // txt_show_title
            // 
            txt_show_title.Location = new Point(299, 332);
            txt_show_title.Name = "txt_show_title";
            txt_show_title.Size = new Size(100, 23);
            txt_show_title.TabIndex = 123;
            // 
            // txt_show_SubjectId
            // 
            txt_show_SubjectId.Location = new Point(145, 332);
            txt_show_SubjectId.Name = "txt_show_SubjectId";
            txt_show_SubjectId.Size = new Size(100, 23);
            txt_show_SubjectId.TabIndex = 122;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(425, 340);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 121;
            label2.Text = "Content";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(260, 340);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 120;
            label3.Text = "Title";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(73, 340);
            label4.Name = "label4";
            label4.Size = new Size(66, 15);
            label4.TabIndex = 119;
            label4.Text = "Subject ID :";
            // 
            // btn_update
            // 
            btn_update.Location = new Point(247, 383);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(161, 23);
            btn_update.TabIndex = 118;
            btn_update.Text = "Save the Change";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // findSubjectLectures
            // 
            findSubjectLectures.Location = new Point(35, 281);
            findSubjectLectures.Name = "findSubjectLectures";
            findSubjectLectures.Size = new Size(183, 23);
            findSubjectLectures.TabIndex = 117;
            // 
            // btn_AddExam
            // 
            btn_AddExam.Location = new Point(247, 230);
            btn_AddExam.Name = "btn_AddExam";
            btn_AddExam.Size = new Size(161, 23);
            btn_AddExam.TabIndex = 116;
            btn_AddExam.Text = "Add New Exam";
            btn_AddExam.UseVisualStyleBackColor = true;
            btn_AddExam.Click += btn_AddExam_Click;
            // 
            // txt_content
            // 
            txt_content.Location = new Point(481, 184);
            txt_content.Name = "txt_content";
            txt_content.Size = new Size(100, 23);
            txt_content.TabIndex = 115;
            // 
            // txt_Title
            // 
            txt_Title.Location = new Point(299, 184);
            txt_Title.Name = "txt_Title";
            txt_Title.Size = new Size(100, 23);
            txt_Title.TabIndex = 114;
            // 
            // txt_SubjectID
            // 
            txt_SubjectID.Location = new Point(145, 184);
            txt_SubjectID.Name = "txt_SubjectID";
            txt_SubjectID.Size = new Size(100, 23);
            txt_SubjectID.TabIndex = 113;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(425, 192);
            label6.Name = "label6";
            label6.Size = new Size(50, 15);
            label6.TabIndex = 112;
            label6.Text = "Content";
            // 
            // la
            // 
            la.AutoSize = true;
            la.Location = new Point(260, 192);
            la.Name = "la";
            la.Size = new Size(29, 15);
            la.TabIndex = 111;
            la.Text = "Title";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(73, 192);
            label16.Name = "label16";
            label16.Size = new Size(66, 15);
            label16.TabIndex = 110;
            label16.Text = "Subject ID :";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(47, 43);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(588, 76);
            richTextBox1.TabIndex = 109;
            richTextBox1.Text = "";
            // 
            // btn_showAllSubjectLectures
            // 
            btn_showAllSubjectLectures.Location = new Point(201, 139);
            btn_showAllSubjectLectures.Name = "btn_showAllSubjectLectures";
            btn_showAllSubjectLectures.Size = new Size(271, 23);
            btn_showAllSubjectLectures.TabIndex = 108;
            btn_showAllSubjectLectures.Text = "Show All Subject Lectures";
            btn_showAllSubjectLectures.UseVisualStyleBackColor = true;
            btn_showAllSubjectLectures.Click += btn_showAllSubjectLectures_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(294, 25);
            label1.Name = "label1";
            label1.Size = new Size(116, 15);
            label1.TabIndex = 107;
            label1.Text = "The Subject Luctures";
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_deleteExamById);
            Controls.Add(btn_findSubjectLecturesById);
            Controls.Add(txt_show_content);
            Controls.Add(txt_show_title);
            Controls.Add(txt_show_SubjectId);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(btn_update);
            Controls.Add(findSubjectLectures);
            Controls.Add(btn_AddExam);
            Controls.Add(txt_content);
            Controls.Add(txt_Title);
            Controls.Add(txt_SubjectID);
            Controls.Add(label6);
            Controls.Add(la);
            Controls.Add(label16);
            Controls.Add(richTextBox1);
            Controls.Add(btn_showAllSubjectLectures);
            Controls.Add(label1);
            Name = "Form6";
            Text = "Form6";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_deleteExamById;
        private Button btn_findSubjectLecturesById;
        private TextBox txt_show_content;
        private TextBox txt_show_title;
        private TextBox txt_show_SubjectId;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btn_update;
        private TextBox findSubjectLectures;
        private Button btn_AddExam;
        private TextBox txt_content;
        private TextBox txt_Title;
        private TextBox txt_SubjectID;
        private Label label6;
        private Label la;
        private Label label16;
        private RichTextBox richTextBox1;
        private Button btn_showAllSubjectLectures;
        private Label label1;
    }
}