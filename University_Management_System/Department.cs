using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Management_System
{
    class Department
    {
        private string departmentName;
        

        public string DepartmentName
        {
            get { return departmentName; }
            set { departmentName = value; }
        }
        Course[] courseName = new Course[40];
        private int countCourse = 0;
        public Department(string departmentName)
        {
            this.departmentName = departmentName;
        }

        public void ShowInfo()
        {
            Console.WriteLine(departmentName);
        }
        public void AddCourse(Course courseName)
        {
            this.courseName[countCourse++] = courseName;
        }
    }
}

