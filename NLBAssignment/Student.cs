using System.Security.Cryptography.X509Certificates;

namespace NLBAssignment
{
    public class Student
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public IList<string> Hobbies { get; set; }
    }
}