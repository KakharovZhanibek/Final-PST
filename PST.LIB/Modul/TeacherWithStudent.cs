using P_S_T.Modul;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PST.LIB.Modul
{
    public class TeacherWithStudent : Teacher
    {
        public List<Student> DB;
        public List<Student> students;

        public TeacherWithStudent()
        {
            DB = new List<Student>();
            students = new List<Student>();
        }
        public static TeacherWithStudent Random_Teacher(ref List<TeacherWithStudent>r_teacher)
        {
            Random rnd = new Random();
            return r_teacher[rnd.Next(1, r_teacher.Count)];
        }
    }
}
