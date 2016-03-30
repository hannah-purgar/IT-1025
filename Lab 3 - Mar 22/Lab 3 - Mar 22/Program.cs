

namespace Lab_3___Mar_22
{
    class Program
    {
        static void Main(string[] args)
        {

            //     INSTUCTOR CREATION     //
            Instructor john = new Instructor("John", "English");
            Instructor mike = new Instructor("Mike", "Math");
            
            //     STUDENT CREATION     //
            Student jane = new Student("Jane", john);
            Student joe = new Student("Joe", john);
            Student melissa = new Student("Melissa", mike);
            Student matt = new Student("Matt", mike);

            //     GRADE ASSIGNMENT     //
            john.SetGrade(jane, 95);
            john.SetGrade(joe, 85);
            mike.SetGrade(melissa, 90);
            mike.SetGrade(matt, 92);

            jane.Print();
            joe.Print();
            melissa.Print();
            matt.Print();
            System.Console.Read();

        }
    }
}
