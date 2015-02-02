namespace WindowsFormsAssignment5
{
    partial class FormAddStudent
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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelStudentID = new System.Windows.Forms.Label();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.buttonAddStudent = new System.Windows.Forms.Button();
            this.textBoxDOB = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelDOB = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.labelAdd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(110, 34);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(200, 21);
            this.textBoxName.TabIndex = 1;
            // 
            // labelStudentID
            // 
            this.labelStudentID.AutoSize = true;
            this.labelStudentID.Location = new System.Drawing.Point(108, 129);
            this.labelStudentID.Name = "labelStudentID";
            this.labelStudentID.Size = new System.Drawing.Size(83, 12);
            this.labelStudentID.TabIndex = 6;
            this.labelStudentID.Text = "Auto generate";
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(110, 174);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(279, 21);
            this.textBoxAddress.TabIndex = 8;
            // 
            // buttonAddStudent
            // 
            this.buttonAddStudent.Location = new System.Drawing.Point(141, 256);
            this.buttonAddStudent.Name = "buttonAddStudent";
            this.buttonAddStudent.Size = new System.Drawing.Size(126, 44);
            this.buttonAddStudent.TabIndex = 9;
            this.buttonAddStudent.Text = "Add student";
            this.buttonAddStudent.UseVisualStyleBackColor = true;
            this.buttonAddStudent.Click += new System.EventHandler(this.buttonAddStudent_Click);
            // 
            // textBoxDOB
            // 
            this.textBoxDOB.Location = new System.Drawing.Point(110, 81);
            this.textBoxDOB.Name = "textBoxDOB";
            this.textBoxDOB.Size = new System.Drawing.Size(200, 21);
            this.textBoxDOB.TabIndex = 10;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(12, 37);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(29, 12);
            this.labelName.TabIndex = 11;
            this.labelName.Text = "Name";
            this.labelName.Click += new System.EventHandler(this.labelName_Click);
            // 
            // labelDOB
            // 
            this.labelDOB.AutoSize = true;
            this.labelDOB.Location = new System.Drawing.Point(12, 84);
            this.labelDOB.Name = "labelDOB";
            this.labelDOB.Size = new System.Drawing.Size(83, 12);
            this.labelDOB.TabIndex = 12;
            this.labelDOB.Text = "Date of Birth";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(12, 129);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(65, 12);
            this.labelID.TabIndex = 13;
            this.labelID.Text = "Student ID";
            // 
            // labelAdd
            // 
            this.labelAdd.AutoSize = true;
            this.labelAdd.Location = new System.Drawing.Point(12, 174);
            this.labelAdd.Name = "labelAdd";
            this.labelAdd.Size = new System.Drawing.Size(47, 12);
            this.labelAdd.TabIndex = 14;
            this.labelAdd.Text = "Address";
            // 
            // FormAddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 341);
            this.Controls.Add(this.labelAdd);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.labelDOB);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxDOB);
            this.Controls.Add(this.buttonAddStudent);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.labelStudentID);
            this.Controls.Add(this.textBoxName);
            this.Name = "FormAddStudent";
            this.Text = "FormAddStudent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelStudentID;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Button buttonAddStudent;
        private System.Windows.Forms.TextBox textBoxDOB;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelDOB;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelAdd;
    }
}