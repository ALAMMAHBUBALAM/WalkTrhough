using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DepartmentStudentApp
{
    public partial class DepartmentStudentUIcs : Form
    {
        public DepartmentStudentUIcs()
        {
            InitializeComponent();
        }
        Department aDepartment = new Department();
        private void buttonSaveDept_Click(object sender, EventArgs e)
        {
            
            aDepartment.DepartmentCode = textBoxDeptCode.Text;
            aDepartment.DepartmentName = textBoxDeptName.Text;
            textBoxDeptCode.Text = "";
            textBoxDeptName.Text = "";
            MessageBox.Show(aDepartment.DepartmentCode + " " + aDepartment.DepartmentName);


        }

        private void buttonSaveStudent_Click(object sender, EventArgs e)
        {
            Student aStudent = new Student();
            aStudent.studentregno = textBoxStudentRegNo.Text;
            aStudent.studentname = textBoxStudentName.Text;
            aStudent.studentemail = textBoxStudentEmail.Text;
            aDepartment.AddStudent(aStudent); // 
            MessageBox.Show("Student Added!");
            textBoxStudentRegNo.Text = "";
            textBoxStudentName.Text = "";
            textBoxStudentEmail.Text = "";
            }

        private void buttonShowInfo_Click(object sender, EventArgs e)
        {
            // /n new line /t tab 

           // string info = 
        }
    }
}
