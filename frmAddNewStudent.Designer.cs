namespace Lab_2
{
    partial class frmAddNewStudent
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblTotalScores = new System.Windows.Forms.Label();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.txtBoxScore = new System.Windows.Forms.TextBox();
            this.btnAddScore = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtTotalScores = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 17);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(12, 40);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(49, 17);
            this.lblScore.TabIndex = 1;
            this.lblScore.Text = "Score:";
            // 
            // lblTotalScores
            // 
            this.lblTotalScores.AutoSize = true;
            this.lblTotalScores.Location = new System.Drawing.Point(4, 68);
            this.lblTotalScores.Name = "lblTotalScores";
            this.lblTotalScores.Size = new System.Drawing.Size(56, 17);
            this.lblTotalScores.TabIndex = 2;
            this.lblTotalScores.Text = "Scores:";
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(67, 6);
            this.txtBoxName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(248, 22);
            this.txtBoxName.TabIndex = 1;
            // 
            // txtBoxScore
            // 
            this.txtBoxScore.Location = new System.Drawing.Point(67, 37);
            this.txtBoxScore.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxScore.Name = "txtBoxScore";
            this.txtBoxScore.Size = new System.Drawing.Size(143, 22);
            this.txtBoxScore.TabIndex = 2;
            this.txtBoxScore.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxScore_KeyPress);
            // 
            // btnAddScore
            // 
            this.btnAddScore.Location = new System.Drawing.Point(231, 37);
            this.btnAddScore.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddScore.Name = "btnAddScore";
            this.btnAddScore.Size = new System.Drawing.Size(84, 23);
            this.btnAddScore.TabIndex = 3;
            this.btnAddScore.Text = "Add Score";
            this.btnAddScore.UseVisualStyleBackColor = true;
            this.btnAddScore.Click += new System.EventHandler(this.BtnAddScore_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(212, 93);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(103, 24);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear Scores";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(214, 136);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(101, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(97, 136);
            this.btnOK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(100, 23);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // txtTotalScores
            // 
            this.txtTotalScores.Location = new System.Drawing.Point(67, 65);
            this.txtTotalScores.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalScores.Name = "txtTotalScores";
            this.txtTotalScores.ReadOnly = true;
            this.txtTotalScores.Size = new System.Drawing.Size(248, 22);
            this.txtTotalScores.TabIndex = 4;
            // 
            // frmAddNewStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 174);
            this.Controls.Add(this.txtTotalScores);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAddScore);
            this.Controls.Add(this.txtBoxScore);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.lblTotalScores);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblName);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmAddNewStudent";
            this.Text = "Add New Student";
            this.Load += new System.EventHandler(this.FormAddNewStudent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblTotalScores;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.TextBox txtBoxScore;
        private System.Windows.Forms.Button btnAddScore;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtTotalScores;
    }
}