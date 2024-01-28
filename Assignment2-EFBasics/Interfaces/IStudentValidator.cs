namespace Assignment2_EFBasics.Interfaces
{
    public interface IStudentValidator
    {
        bool isUCStudent(string value);
        void enrollSubject(string subjectName);
    }
}
