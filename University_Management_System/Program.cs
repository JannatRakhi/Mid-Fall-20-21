using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Management_System
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ");
            Console.WriteLine("_ _ _ _ _ _ University Management System_ _ _ _ _ _ _ _ _ _ _");
            
             Console.WriteLine("........................KuraToli Software Solution.......................");
            Console.WriteLine("");
            Console.WriteLine("..........CSE Department..........");
            Department cse = new Department("CSE");
            Course c1 = new Course("OOP1", "11-22-33");
            Course c2 = new Course("OOP2", "12-21-31");
            cse.AddCourse(c1);
            cse.AddCourse(c2);
            Console.WriteLine("");
            Section s1 = new Section("J");
            Section s2 = new Section("L");
            c1.AddSection(s1);
            c2.AddSection(s2);
            Faculty fac1 = new Faculty("Tanvir Ahmed", "999-4040-1", 14.0f);
            fac1.AddSection(s1);
            fac1.AddSection(s2);
            s1.AddTeacher(fac1);
            s2.AddTeacher(fac1);
            c2.ShowSectionTeacher();
            fac1.ShowSectionDetails();
            Console.WriteLine("");
            Console.WriteLine("..........EEE Department..........");
            
            Department eee = new Department("EEE");
            Course e1 = new Course("DLC", "22-33-44");
            Course e2 = new Course("Electronic Device", "33-44-55");
            eee.AddCourse(e1);
            eee.AddCourse(e2);
            Console.WriteLine("");
            Section t1 = new Section("K");
            Section t2 = new Section("F");
            e1.AddSection(t1);
            e2.AddSection(t2);
            Faculty fac2 = new Faculty("Noushin Alam", "8888-3030-2",15.0f);
            fac2.AddSection(t1);
            fac2.AddSection(t2);
            t1.AddTeacher(fac2);
            t2.AddTeacher(fac2);
            c2.ShowSectionTeacher();
            fac2.ShowSectionDetails();
            Console.ReadLine();

        }

    }
}

