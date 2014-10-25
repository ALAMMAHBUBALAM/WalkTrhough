namespace DepartmentStudentApp
{
    partial class DepartmentStudentUIcs
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
            this.buttonSaveDept = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDeptCode = new System.Windows.Forms.TextBox();
            this.textBoxDeptName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxStudentRegNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxStudentName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxStudentEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonSaveStudent = new System.Windows.Forms.Button();
            this.buttonShowInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSaveDept
            // 
            this.buttonSaveDept.Location = new System.Drawing.Point(239, 48);
            this.buttonSaveDept.Name = "buttonSaveDept";
            this.buttonSaveDept.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveDept.TabIndex = 0;
            this.buttonSaveDept.Text = "Save";
            this.buttonSaveDept.UseVisualStyleBackColor = true;
            this.buttonSaveDept.Click += new System.EventHandler(this.buttonSaveDept_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dept Code";
            // 
            // textBoxDeptCode
            // 
            this.textBoxDeptCode.Location = new System.Drawing.Point(110, 27);
            this.textBoxDeptCode.Name = "textBoxDeptCode";
            this.textBoxDeptCode.Size = new System.Drawing.Size(100, 20);
            this.textBoxDeptCode.TabIndex = 2;
            // 
            // textBoxDeptName
            // 
            this.textBoxDeptName.Location = new System.Drawing.Point(110, 53);
            this.textBoxDeptName.Name = "textBoxDeptName";
            this.textBoxDeptName.Size = new System.Drawing.Size(100, 20);
            this.textBoxDeptName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dept Name";
            // 
            // textBoxStudentRegNo
            // 
            this.textBoxStudentRegNo.Location = new System.Drawing.Point(110, 94);
            this.textBoxStudentRegNo.Name = "textBoxStudentRegNo";
            this.textBoxStudentRegNo.Size = new System.Drawing.Size(100, 20);
            this.textBoxStudentRegNo.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Student Reg No";
            // 
            // textBoxStudentName
            // 
            this.textBoxStudentName.Location = new System.Drawing.Point(110, 120);
            this.textBoxStudentName.Name = "textBoxStudentName";
            this.textBoxStudentName.Size = new System.Drawing.Size(100, 20);
            this.textBoxStudentName.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Student Name";
            // 
            // textBoxStudentEmail
            // 
            this.textBoxStudentEmail.Location = new System.Drawing.Point(110, 146);
            this.textBoxStudentEmail.Name = "textBoxStudentEmail";
            this.textBoxStudentEmail.Size = new System.Drawing.Size(100, 20);
            this.textBoxStudentEmail.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Student Email";
            // 
            // buttonSaveStudent
            // 
            this.buttonSaveStudent.Location = new System.Drawing.Point(239, 148);
            this.buttonSaveStudent.Name = "buttonSaveStudent";
            this.buttonSaveStudent.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveStudent.TabIndex = 11;
            this.buttonSaveStudent.Text = "Save ";
            this.buttonSaveStudent.UseVisualStyleBackColor = true;
            this.buttonSaveStudent.Click += new System.EventHandler(this.buttonSaveStudent_Click);
            // 
            // buttonShowInfo
            // 
            this.buttonShowInfo.Location = new System.Drawing.Point(155, 191);
            this.buttonShowInfo.Name = "buttonShowInfo";
            this.buttonShowInfo.Size = new System.Drawing.Size(75, 23);
            this.buttonShowInfo.TabIndex = 12;
            this.buttonShowInfo.Text = "Show Info";
            this.buttonShowInfo.UseVisualStyleBackColor = true;
            this.buttonShowInfo.Click += new System.EventHandler(this.buttonShowInfo_Click);
            // 
            // DepartmentStudentUIcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 265);
            this.Controls.Add(this.buttonShowInfo);
            this.Controls.Add(this.buttonSaveStudent);
            this.Controls.Add(this.textBoxStudentEmail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxStudentName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxStudentRegNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxDeptName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxDeptCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSaveDept);
            this.Name = "DepartmentStudentUIcs";
            this.Text = "Department wise Student Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSaveDept;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDeptCode;
        private System.Windows.Forms.TextBox textBoxDeptName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxStudentRegNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxStudentName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxStudentEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonSaveStudent;
        private System.Windows.Forms.Button buttonShowInfo;
    }
}