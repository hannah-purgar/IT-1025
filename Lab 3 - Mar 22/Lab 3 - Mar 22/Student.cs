

namespace Lab_3___Mar_22
{
    class Student
    {
        private string Name;
        public int Grade;
        private Instructor Teacher;

        // Values specified are assigned to Object as Name and Teacher //
        // Default Grade is equal to zero //
        public Student(string theirName, Instructor theirTeacher)
        {
            this.Name = theirName;
            this.Teacher = theirTeacher;
            this.Grade = 0;
        }

        // Print the Name & Course of Instructor //
        public void Print()
        {
            System.Console.WriteLine("Student Name:    " + this.Name + "... Grade: " + this.Grade);
            this.Teacher.Print();
        }













    }
}
