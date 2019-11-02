namespace Lab_2
{
    partial class frmStudentScores
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
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblStudents = new System.Windows.Forms.Label();
            this.labelScoreTotal = new System.Windows.Forms.Label();
            this.labelScoreCount = new System.Windows.Forms.Label();
            this.labelAverage = new System.Windows.Forms.Label();
            this.textBoxScoreTotal = new System.Windows.Forms.TextBox();
            this.textBoxScoreCount = new System.Windows.Forms.TextBox();
            this.textBoxScoreAverage = new System.Windows.Forms.TextBox();
            this.lstBoxStudents = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(264, 148);
            this.btnAddNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(75, 28);
            this.btnAddNew.TabIndex = 0;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.ButtonAddNew_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(264, 180);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 28);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(264, 212);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 28);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(264, 334);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 31);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // lblStudents
            // 
            this.lblStudents.AutoSize = true;
            this.lblStudents.Location = new System.Drawing.Point(12, 9);
            this.lblStudents.Name = "lblStudents";
            this.lblStudents.Size = new System.Drawing.Size(68, 17);
            this.lblStudents.TabIndex = 4;
            this.lblStudents.Text = "Students:";
            // 
            // labelScoreTotal
            // 
            this.labelScoreTotal.AutoSize = true;
            this.labelScoreTotal.Location = new System.Drawing.Point(97, 257);
            this.labelScoreTotal.Name = "labelScoreTotal";
            this.labelScoreTotal.Size = new System.Drawing.Size(80, 17);
            this.labelScoreTotal.TabIndex = 5;
            this.labelScoreTotal.Text = "Score total:";
            // 
            // labelScoreCount
            // 
            this.labelScoreCount.AutoSize = true;
            this.labelScoreCount.Location = new System.Drawing.Point(89, 283);
            this.labelScoreCount.Name = "labelScoreCount";
            this.labelScoreCount.Size = new System.Drawing.Size(88, 17);
            this.labelScoreCount.TabIndex = 6;
            this.labelScoreCount.Text = "Score count:";
            // 
            // labelAverage
            // 
            this.labelAverage.AutoSize = true;
            this.labelAverage.Location = new System.Drawing.Point(112, 309);
            this.labelAverage.Name = "labelAverage";
            this.labelAverage.Size = new System.Drawing.Size(65, 17);
            this.labelAverage.TabIndex = 7;
            this.labelAverage.Text = "Average:";
            // 
            // textBoxScoreTotal
            // 
            this.textBoxScoreTotal.Location = new System.Drawing.Point(183, 254);
            this.textBoxScoreTotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxScoreTotal.Name = "textBoxScoreTotal";
            this.textBoxScoreTotal.ReadOnly = true;
            this.textBoxScoreTotal.Size = new System.Drawing.Size(75, 22);
            this.textBoxScoreTotal.TabIndex = 9;
            this.textBoxScoreTotal.TabStop = false;
            // 
            // textBoxScoreCount
            // 
            this.textBoxScoreCount.Location = new System.Drawing.Point(183, 280);
            this.textBoxScoreCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxScoreCount.Name = "textBoxScoreCount";
            this.textBoxScoreCount.ReadOnly = true;
            this.textBoxScoreCount.Size = new System.Drawing.Size(75, 22);
            this.textBoxScoreCount.TabIndex = 10;
            this.textBoxScoreCount.TabStop = false;
            // 
            // textBoxScoreAverage
            // 
            this.textBoxScoreAverage.Location = new System.Drawing.Point(183, 306);
            this.textBoxScoreAverage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxScoreAverage.Name = "textBoxScoreAverage";
            this.textBoxScoreAverage.ReadOnly = true;
            this.textBoxScoreAverage.Size = new System.Drawing.Size(75, 22);
            this.textBoxScoreAverage.TabIndex = 11;
            this.textBoxScoreAverage.TabStop = false;
            // 
            // lstBoxStudents
            // 
            this.lstBoxStudents.FormattingEnabled = true;
            this.lstBoxStudents.ItemHeight = 16;
            this.lstBoxStudents.Location = new System.Drawing.Point(12, 28);
            this.lstBoxStudents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstBoxStudents.Name = "lstBoxStudents";
            this.lstBoxStudents.Size = new System.Drawing.Size(246, 212);
            this.lstBoxStudents.TabIndex = 14;
            this.lstBoxStudents.SelectedIndexChanged += new System.EventHandler(this.LstboxStudents_SelectedIndexChanged);
            // 
            // frmStudentScores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 376);
            this.Controls.Add(this.lstBoxStudents);
            this.Controls.Add(this.textBoxScoreAverage);
            this.Controls.Add(this.textBoxScoreCount);
            this.Controls.Add(this.textBoxScoreTotal);
            this.Controls.Add(this.labelAverage);
            this.Controls.Add(this.labelScoreCount);
            this.Controls.Add(this.labelScoreTotal);
            this.Controls.Add(this.lblStudents);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAddNew);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmStudentScores";
            this.Text = "Student Scores";
            this.Load += new System.EventHandler(this.frmStudentScores_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblStudents;
        private System.Windows.Forms.Label labelScoreTotal;
        private System.Windows.Forms.Label labelScoreCount;
        private System.Windows.Forms.Label labelAverage;
        private System.Windows.Forms.TextBox textBoxScoreTotal;
        private System.Windows.Forms.TextBox textBoxScoreCount;
        private System.Windows.Forms.TextBox textBoxScoreAverage;
        private System.Windows.Forms.ListBox lstBoxStudents;
    }
}

