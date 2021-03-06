using System;

namespace CS_Day1
{
    public class Member
    {
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Gender { get; set; }
        public DateTime Birthday { get; set; }
        public String PhoneNumber { get; set; }
        public String BirthPlace { get; set; }
        public int Age { get { return DateTime.Now.Year - Birthday.Year; } }
        public bool IsGraduated { get; set; }
    }
}
