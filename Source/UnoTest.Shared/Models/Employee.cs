using System;
using System.Collections.Generic;
using System.Text;

namespace UnoTest.Models
{
    public class Employee
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Initials => $"{FirstName[0]}{LastName[0]}";

        public char? ProfileImageId { get; set; }

        public string Name => $"{FirstName} {LastName}";
    }
}
