namespace WindowsFormsAssignment5
{
    partial class FormAddNewPaper
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
            this.labelPaperName = new System.Windows.Forms.Label();
            this.textBoxPaperName = new System.Windows.Forms.TextBox();
            this.textBoxPaperCode = new System.Windows.Forms.TextBox();
            this.labelCourseCoordinator = new System.Windows.Forms.Label();
            this.textBoxCourseCoordinator = new System.Windows.Forms.TextBox();
            this.buttonCreateNewPaper = new System.Windows.Forms.Button();
            this.labelPaperCode = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelPaperName
            // 
            this.labelPaperName.AutoSize = true;
            this.labelPaperName.Location = new System.Drawing.Point(25, 37);
            this.labelPaperName.Name = "labelPaperName";
            this.labelPaperName.Size = new System.Drawing.Size(65, 12);
            this.labelPaperName.TabIndex = 0;
            this.labelPaperName.Text = "Paper Name";
            // 
            // textBoxPaperName
            // 
            this.textBoxPaperName.Location = new System.Drawing.Point(144, 37);
            this.textBoxPaperName.Name = "textBoxPaperName";
            this.textBoxPaperName.Size = new System.Drawing.Size(197, 21);
            this.textBoxPaperName.TabIndex = 1;
            // 
            // textBoxPaperCode
            // 
            this.textBoxPaperCode.Location = new System.Drawing.Point(144, 83);
            this.textBoxPaperCode.Name = "textBoxPaperCode";
            this.textBoxPaperCode.Size = new System.Drawing.Size(89, 21);
            this.textBoxPaperCode.TabIndex = 3;
            // 
            // labelCourseCoordinator
            // 
            this.labelCourseCoordinator.AutoSize = true;
            this.labelCourseCoordinator.Location = new System.Drawing.Point(25, 130);
            this.labelCourseCoordinator.Name = "labelCourseCoordinator";
            this.labelCourseCoordinator.Size = new System.Drawing.Size(113, 12);
            this.labelCourseCoordinator.TabIndex = 4;
            this.labelCourseCoordinator.Text = "Course Coordinator";
            // 
            // textBoxCourseCoordinator
            // 
            this.textBoxCourseCoordinator.Location = new System.Drawing.Point(144, 130);
            this.textBoxCourseCoordinator.Name = "textBoxCourseCoordinator";
            this.textBoxCourseCoordinator.Size = new System.Drawing.Size(197, 21);
            this.textBoxCourseCoordinator.TabIndex = 5;
            // 
            // buttonCreateNewPaper
            // 
            this.buttonCreateNewPaper.Location = new System.Drawing.Point(144, 211);
            this.buttonCreateNewPaper.Name = "buttonCreateNewPaper";
            this.buttonCreateNewPaper.Size = new System.Drawing.Size(145, 52);
            this.buttonCreateNewPaper.TabIndex = 6;
            this.buttonCreateNewPaper.Text = "Create New Paper";
            this.buttonCreateNewPaper.UseVisualStyleBackColor = true;
            this.buttonCreateNewPaper.Click += new System.EventHandler(this.buttonCreateNewPaper_Click);
            // 
            // labelPaperCode
            // 
            this.labelPaperCode.AutoSize = true;
            this.labelPaperCode.Location = new System.Drawing.Point(27, 83);
            this.labelPaperCode.Name = "labelPaperCode";
            this.labelPaperCode.Size = new System.Drawing.Size(65, 12);
            this.labelPaperCode.TabIndex = 7;
            this.labelPaperCode.Text = "Paper Code";
            // 
            // FormAddNewPaper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 306);
            this.Controls.Add(this.labelPaperCode);
            this.Controls.Add(this.buttonCreateNewPaper);
            this.Controls.Add(this.textBoxCourseCoordinator);
            this.Controls.Add(this.labelCourseCoordinator);
            this.Controls.Add(this.textBoxPaperCode);
            this.Controls.Add(this.textBoxPaperName);
            this.Controls.Add(this.labelPaperName);
            this.Name = "FormAddNewPaper";
            this.Text = "Add New Paper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPaperName;
        private System.Windows.Forms.TextBox textBoxPaperName;
        private System.Windows.Forms.TextBox textBoxPaperCode;
        private System.Windows.Forms.Label labelCourseCoordinator;
        private System.Windows.Forms.TextBox textBoxCourseCoordinator;
        private System.Windows.Forms.Button buttonCreateNewPaper;
        private System.Windows.Forms.Label labelPaperCode;
    }
}