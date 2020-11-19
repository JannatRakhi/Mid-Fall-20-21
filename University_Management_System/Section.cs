using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Management_System
{
    class Section
    {
        private string sectionName;
       
        
        Faculty teacherName;

        public string SectionName
        {
            get { return sectionName; }
            set { sectionName = value; }
        }
       
        public Section(string sectionName)
        {
            this.sectionName = sectionName;
           
        }
       

        public void AddTeacher(Faculty teacherName)
        {
            if (teacherName.totalHourOfClass < 21)
            {
                this.teacherName = teacherName;
            }
            else
            {
                Console.WriteLine("Faculty Don't add any courses");
            }

        }

        public void ShowDetails()
        {
            Console.WriteLine("Section Name:" + sectionName);
            
            teacherName.ShowTeacherDetails();
        }
    }
}



