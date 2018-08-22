using P_S_T.Modul;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PST.LIB.Modul
{
    public class StudentWithAdvisor : Student
    {
        public List<Teacher> DB;
        public Teacher Teacher;

        public static StudentWithAdvisor Random_Student(ref List<StudentWithAdvisor> r_student)
        {
            Random rnd = new Random();
            return r_student[rnd.Next(1, r_student.Count)];
        }
    }
    
}
