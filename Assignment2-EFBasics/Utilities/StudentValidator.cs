using Assignment2_EFBasics.Interfaces;

namespace Assignment2_EFBasics.Utilities
{
    public class StudentValidator : IStudentValidator
    {
        bool isStudent = false;
        string[] subjects = Array.Empty<string>();
        public StudentValidator() { }

        public StudentValidator(bool isValid)
        {
            this.isStudent = isValid;
        }

        public bool isUCStudent(string value)
        {
            return true;
        }

        public void enrollSubject(string subjectName)
        {
            subjects.Append(subjectName);
        }
    }
}
