namespace myHomeWorkForm
{
    partial class Form2
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
            richTextBox1 = new RichTextBox();
            btn_show_allDepartment = new Button();
            txt_departmentname = new TextBox();
            label2 = new Label();
            btn_addDepartment = new Button();
            txt_idDepartment = new TextBox();
            btn_findId = new Button();
            txt_show_idDepartment = new TextBox();
            label3 = new Label();
            txt_show_nameDepartment = new TextBox();
            label4 = new Label();
            btn_deleteDepartment = new Button();
            btn_update = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(208, 9);
            label1.Name = "label1";
            label1.Size = new Size(92, 15);
            label1.TabIndex = 0;
            label1.Text = "The Department";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(16, 47);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(474, 69);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // btn_show_allDepartment
            // 
            btn_show_allDepartment.Location = new Point(161, 132);
            btn_show_allDepartment.Name = "btn_show_allDepartment";
            btn_show_allDepartment.Size = new Size(201, 23);
            btn_show_allDepartment.TabIndex = 2;
            btn_show_allDepartment.Text = "Show All Department";
            btn_show_allDepartment.UseVisualStyleBackColor = true;
            btn_show_allDepartment.Click += btn_show_allDepartment_Click;
            // 
            // txt_departmentname
            // 
            txt_departmentname.Location = new Point(261, 170);
            txt_departmentname.Name = "txt_departmentname";
            txt_departmentname.Size = new Size(172, 23);
            txt_departmentname.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(121, 178);
            label2.Name = "label2";
            label2.Size = new Size(108, 15);
            label2.TabIndex = 12;
            label2.Text = "Department  Name";
            // 
            // btn_addDepartment
            // 
            btn_addDepartment.Location = new Point(161, 199);
            btn_addDepartment.Name = "btn_addDepartment";
            btn_addDepartment.Size = new Size(201, 23);
            btn_addDepartment.TabIndex = 15;
            btn_addDepartment.Text = "Add New Department";
            btn_addDepartment.UseVisualStyleBackColor = true;
            btn_addDepartment.Click += btn_addDepartment_Click;
            // 
            // txt_idDepartment
            // 
            txt_idDepartment.Location = new Point(12, 243);
            txt_idDepartment.Name = "txt_idDepartment";
            txt_idDepartment.Size = new Size(172, 23);
            txt_idDepartment.TabIndex = 16;
            // 
            // btn_findId
            // 
            btn_findId.Location = new Point(190, 242);
            btn_findId.Name = "btn_findId";
            btn_findId.Size = new Size(150, 23);
            btn_findId.TabIndex = 17;
            btn_findId.Text = "Find Department By Id";
            btn_findId.UseVisualStyleBackColor = true;
            btn_findId.Click += btn_findId_Click;
            // 
            // txt_show_idDepartment
            // 
            txt_show_idDepartment.Location = new Point(208, 285);
            txt_show_idDepartment.Name = "txt_show_idDepartment";
            txt_show_idDepartment.Size = new Size(172, 23);
            txt_show_idDepartment.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(80, 293);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 18;
            label3.Text = "Id Department";
            // 
            // txt_show_nameDepartment
            // 
            txt_show_nameDepartment.Location = new Point(208, 314);
            txt_show_nameDepartment.Name = "txt_show_nameDepartment";
            txt_show_nameDepartment.Size = new Size(172, 23);
            txt_show_nameDepartment.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(80, 322);
            label4.Name = "label4";
            label4.Size = new Size(108, 15);
            label4.TabIndex = 20;
            label4.Text = "Department  Name";
            // 
            // btn_deleteDepartment
            // 
            btn_deleteDepartment.Location = new Point(366, 242);
            btn_deleteDepartment.Name = "btn_deleteDepartment";
            btn_deleteDepartment.Size = new Size(150, 23);
            btn_deleteDepartment.TabIndex = 22;
            btn_deleteDepartment.Text = "Delete Department By Id";
            btn_deleteDepartment.UseVisualStyleBackColor = true;
            btn_deleteDepartment.Click += btn_deleteDepartment_Click;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(190, 358);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(208, 32);
            btn_update.TabIndex = 34;
            btn_update.Text = "Update and Save the Change";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(574, 429);
            Controls.Add(btn_update);
            Controls.Add(btn_deleteDepartment);
            Controls.Add(txt_show_nameDepartment);
            Controls.Add(label4);
            Controls.Add(txt_show_idDepartment);
            Controls.Add(label3);
            Controls.Add(btn_findId);
            Controls.Add(txt_idDepartment);
            Controls.Add(btn_addDepartment);
            Controls.Add(txt_departmentname);
            Controls.Add(label2);
            Controls.Add(btn_show_allDepartment);
            Controls.Add(richTextBox1);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RichTextBox richTextBox1;
        private Button btn_show_allDepartment;
        private TextBox txt_departmentname;
        private Label label2;
        private Button btn_addDepartment;
        private TextBox txt_idDepartment;
        private Button btn_findId;
        private TextBox txt_show_idDepartment;
        private Label label3;
        private TextBox txt_show_nameDepartment;
        private Label label4;
        private Button btn_deleteDepartment;
        private Button btn_update;
    }
}