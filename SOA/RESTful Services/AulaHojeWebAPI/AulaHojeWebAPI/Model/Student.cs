using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AulaHojeWebAPI.Model
{
 
    /// <summary>
    /// Model for Student
    /// </summary>
    public class Student
    {
        string name;
        int number;


        public Student()
        {
            name = "";
            number = -1;
        }
        public Student( string s, int n)
        {
            name = s;
            number = n;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public int Number
        {
            get => number;
            set => number = value;
        }
    }

    /// <summary>
    /// Model for Students
    /// </summary>
    public class Students
    {
        List<Student> course;

        #region Management Methods

        /// <summary>
        /// Constructor
        /// </summary>
        public Students()
        {
            if (course==null) 
                course = new List<Student>();
        }

        /// <summary>
        /// Property: ATTENTION
        /// </summary>
        public List<Student> Course
        {
            get => course;      //better a clone of it!!!
        }

        /// <summary>
        /// Add new student!
        /// Student cannot exist!
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public bool AddStudent(Student s)
        {
            if (!course.Contains(s))
            {
                course.Add(s); return true;
            }
            return false;
        }

        /// <summary>
        /// Find the name of a particular student
        /// </summary>
        /// <param name="numberStudent"></param>
        /// <returns></returns>
        public string GetStudentName(int numberStudent)
        {
            foreach(Student s in course)
            {
                if (s.Number == numberStudent) return s.Name;
            }
            return "";
        }

        #endregion

    }
}
