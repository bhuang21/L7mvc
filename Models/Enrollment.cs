namespace ContosoUniversity.Models
{
    //tinfo200:[2021-03-09-bhuang91-dykstra2] - Created a public class called enrollment to get and set EnrollmentID, CourseID, StudentID, Grade, and student
    public enum Grade 
    {
        A, B, C, D, F
    }
    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public Grade? Grade { get; set; }
        public Student Student { get; set; }
    }
}