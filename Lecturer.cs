using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsGradesApp
{
    class Lecturer
    {
        public string lecturerName;
        public string studentName;
        public int taz;
        public int[] grades;
        private List<string> stringList;
        public static List<string> StringList { set; get; }
    public Lecturer(string _studentName, int _taz, int[] _grades)
        {
            this.studentName = _studentName;
            this.taz = _taz;
            this.grades = _grades;
        }
        public Lecturer() { }
        
    }
}
