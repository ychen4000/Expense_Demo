namespace WindowsFormsAssignment5
{
    partial class Mainpage
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showStudentListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPaperListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveWorkingListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openWorkingListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveWorkingListAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewPaperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewRight = new System.Windows.Forms.DataGridView();
            this.buttonEnrollpaper = new System.Windows.Forms.Button();
            this.buttonEnrollStudent = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRight)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(32, 73);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 23;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(575, 315);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(929, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showStudentListToolStripMenuItem,
            this.showPaperListToolStripMenuItem,
            this.saveWorkingListToolStripMenuItem,
            this.openWorkingListToolStripMenuItem,
            this.saveWorkingListAsToolStripMenuItem,
            this.importFileToolStripMenuItem,
            this.exportFileToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(39, 21);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // showStudentListToolStripMenuItem
            // 
            this.showStudentListToolStripMenuItem.Name = "showStudentListToolStripMenuItem";
            this.showStudentListToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.showStudentListToolStripMenuItem.Text = "Show student list";
            this.showStudentListToolStripMenuItem.Click += new System.EventHandler(this.showStudentListToolStripMenuItem_Click);
            // 
            // showPaperListToolStripMenuItem
            // 
            this.showPaperListToolStripMenuItem.Name = "showPaperListToolStripMenuItem";
            this.showPaperListToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.showPaperListToolStripMenuItem.Text = "Show paper list";
            this.showPaperListToolStripMenuItem.Click += new System.EventHandler(this.showPaperListToolStripMenuItem_Click);
            // 
            // saveWorkingListToolStripMenuItem
            // 
            this.saveWorkingListToolStripMenuItem.Name = "saveWorkingListToolStripMenuItem";
            this.saveWorkingListToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.saveWorkingListToolStripMenuItem.Text = "Save working list";
            this.saveWorkingListToolStripMenuItem.Click += new System.EventHandler(this.saveWorkingListToolStripMenuItem_Click);
            // 
            // openWorkingListToolStripMenuItem
            // 
            this.openWorkingListToolStripMenuItem.Name = "openWorkingListToolStripMenuItem";
            this.openWorkingListToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.openWorkingListToolStripMenuItem.Text = "Open working list";
            this.openWorkingListToolStripMenuItem.Click += new System.EventHandler(this.openWorkingListToolStripMenuItem_Click);
            // 
            // saveWorkingListAsToolStripMenuItem
            // 
            this.saveWorkingListAsToolStripMenuItem.Name = "saveWorkingListAsToolStripMenuItem";
            this.saveWorkingListAsToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.saveWorkingListAsToolStripMenuItem.Text = "Save working list as";
            // 
            // importFileToolStripMenuItem
            // 
            this.importFileToolStripMenuItem.Name = "importFileToolStripMenuItem";
            this.importFileToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.importFileToolStripMenuItem.Text = "Import file";
            this.importFileToolStripMenuItem.Click += new System.EventHandler(this.importFileToolStripMenuItem_Click);
            // 
            // exportFileToolStripMenuItem
            // 
            this.exportFileToolStripMenuItem.Name = "exportFileToolStripMenuItem";
            this.exportFileToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.exportFileToolStripMenuItem.Text = "Export file";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewPaperToolStripMenuItem,
            this.addNewStudentToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(42, 21);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // addNewPaperToolStripMenuItem
            // 
            this.addNewPaperToolStripMenuItem.Name = "addNewPaperToolStripMenuItem";
            this.addNewPaperToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.addNewPaperToolStripMenuItem.Text = "Add new paper";
            this.addNewPaperToolStripMenuItem.Click += new System.EventHandler(this.addNewPaperToolStripMenuItem_Click);
            // 
            // addNewStudentToolStripMenuItem
            // 
            this.addNewStudentToolStripMenuItem.Name = "addNewStudentToolStripMenuItem";
            this.addNewStudentToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.addNewStudentToolStripMenuItem.Text = "Add new student";
            this.addNewStudentToolStripMenuItem.Click += new System.EventHandler(this.addNewStudentToolStripMenuItem_Click);
            // 
            // dataGridViewRight
            // 
            this.dataGridViewRight.AllowUserToOrderColumns = true;
            this.dataGridViewRight.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRight.Location = new System.Drawing.Point(649, 73);
            this.dataGridViewRight.Name = "dataGridViewRight";
            this.dataGridViewRight.RowTemplate.Height = 23;
            this.dataGridViewRight.Size = new System.Drawing.Size(237, 315);
            this.dataGridViewRight.TabIndex = 2;
            // 
            // buttonEnrollpaper
            // 
            this.buttonEnrollpaper.Location = new System.Drawing.Point(32, 415);
            this.buttonEnrollpaper.Name = "buttonEnrollpaper";
            this.buttonEnrollpaper.Size = new System.Drawing.Size(272, 46);
            this.buttonEnrollpaper.TabIndex = 3;
            this.buttonEnrollpaper.Text = "Enroll Selected Student into New Paper";
            this.buttonEnrollpaper.UseVisualStyleBackColor = true;
            this.buttonEnrollpaper.Click += new System.EventHandler(this.buttonEnrollpaper_Click);
            // 
            // buttonEnrollStudent
            // 
            this.buttonEnrollStudent.Location = new System.Drawing.Point(32, 467);
            this.buttonEnrollStudent.Name = "buttonEnrollStudent";
            this.buttonEnrollStudent.Size = new System.Drawing.Size(272, 46);
            this.buttonEnrollStudent.TabIndex = 4;
            this.buttonEnrollStudent.Text = "Enroll Student into selected paper";
            this.buttonEnrollStudent.UseVisualStyleBackColor = true;
            // 
            // Mainpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 519);
            this.Controls.Add(this.buttonEnrollStudent);
            this.Controls.Add(this.buttonEnrollpaper);
            this.Controls.Add(this.dataGridViewRight);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Mainpage";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showStudentListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPaperListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewPaperToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportFileToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridViewRight;
        private System.Windows.Forms.ToolStripMenuItem saveWorkingListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveWorkingListAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openWorkingListToolStripMenuItem;
        private System.Windows.Forms.Button buttonEnrollpaper;
        private System.Windows.Forms.Button buttonEnrollStudent;

    }
}

