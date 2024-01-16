using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp38
{
    public static class University
    {

        private static List<Student> _students = new List<Student>();
        private static int grade;

        public static void AddStudent(string name, int id, int type, string Course)
        {
            switch (type)
            {
                case 1:

                    {
                        var student = new GuestStudents(name, id);
                        _students.Add(student);
                        break;
                    }
                case 2:
                    {
                        var studentuniversity = new StudentUniversity(name, id, grade);
                        _students.Add(studentuniversity);
                        break;
                    }


                default:
                    throw new Exception("Invalid student type");
            }


        }

        public static void ShowStudent()
        {
            foreach (var item in _students)
            {

                item.ShowDetail();
            }

        }

    }
}