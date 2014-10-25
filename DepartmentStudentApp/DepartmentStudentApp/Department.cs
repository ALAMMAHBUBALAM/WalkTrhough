using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepartmentStudentApp
{
    public class Department
    {
        public string DepartmentCode { set; get; }
        public string DepartmentName { set; get; }

        public List <Student > StudentList { private set; get; } // this line creates the Null List or Cast


        public Department()
        { StudentList = new List<Student>();} // this line actually creates the list or the box 

        public void AddStudent(Student a)
        { 
            StudentList.Add(a);

        }


    }


}
