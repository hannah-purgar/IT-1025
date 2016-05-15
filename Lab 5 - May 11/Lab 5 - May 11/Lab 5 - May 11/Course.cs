

namespace Lab_5___May_11
{
    class Course
    {
        public string courseName;
        public int CRN;
        public int numStudents;
        public string[] Students;

        public string GetCourse()
        {
            Course course = new Course();
            System.Console.WriteLine("Enter Course Name:        ");
            Course.courseName = System.Console.ReadLine();
            System.Console.WriteLine("Enter Couse Number:       ");
            Course.CRN = System.Console.ReadLine();
            System.Console.WriteLine("Enter Number of Students: ");
            Course.numStudents = System.Console.ReadLine();

            for (Course.numStudents > 1)
            {
                Students student = new Students();
                System.Console.WriteLine("Enter Student Name:        ");
                Student.studentName = System.Console.ReadLine();
                System.Console.WriteLine("Enter Student S-Number:       ");
                Student.sNumber = System.Console.ReadLine();
                Course.numStudents = Course.numStudents - 1;

                System.Console.WriteLine(student.studentName);
                System.Console.WriteLine(student.sNumber);

            }

            System.Console.WriteLine(Course.courseName);
            System.Console.WriteLine(Course.CRN);
        }

        
    }
}
