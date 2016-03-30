

namespace Lab_3___Mar_22
{
    class Instructor
    {
        private string Name;
        private string CourseName;

        // Values specified are assigned to Object as Name and CourseName //
        public Instructor(string theirName, string theirCourseName)
        {
            this.Name = theirName;
            this.CourseName = theirCourseName;
        }

        // Values specified are assigend to Object as Student Name and Student Grade //
        public void SetGrade(Student student, int grade)
        {
            student.Grade += grade;
        }

        // Print the Name & Course of Instructor //
        public void Print()
        {
            System.Console.WriteLine("Instructor Name: " + this.Name + "... Course Name: " + this.CourseName);
        }
    }
}