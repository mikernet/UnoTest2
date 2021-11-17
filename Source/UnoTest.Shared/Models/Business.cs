using System;
using System.Collections.Generic;
using System.Text;

namespace UnoTest.Models
{
    public class Business
    {
        public string Name { get; set; }

        public string BusinessType { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string Website { get; set; }

        public string Address { get; set; }

        public string Country { get; set; }

        public string CountryCode { get; set; }

        public string Region { get; set; }

        public string RegionShortName { get; set; }

        public string City { get; set; }

        public string PostalCode { get; set; }

        public List<Employee> Employees { get; set; } = new List<Employee>();

        public static Business GetTestBusiness() => new Business
        {
            Name = "Singulink",
            BusinessType = "Software Development",
            Phone = "519-914-0475",
            Email = "test@test.com",
            Website = "https://www.singulink.com",
            Address = "123 Test St.",
            Country = "Canada",
            CountryCode = "CA",
            Region = "Ontario",
            RegionShortName = "ON",
            City = "London",
            PostalCode = "A1A 1A1",
            Employees =
            {
                new Employee
                {
                    FirstName = "Alice",
                    LastName = "NoImage",
                },
                new Employee
                {
                    FirstName = "Albert",
                    LastName = "NoImage",
                },
                new Employee
                {
                    FirstName = "Bob",
                    LastName = "Image",
                    ProfileImageId = 'B',
                },
                new Employee
                {
                    FirstName = "Gabby",
                    LastName = "NoImage",
                },
                new Employee
                {
                    FirstName = "Frank",
                    LastName = "NoImage",
                },
                new Employee
                {
                    FirstName = "Greg",
                    LastName = "Image",
                    ProfileImageId = 'G',
                },
                new Employee
                {
                    FirstName = "Gary",
                    LastName = "NoImage",
                },
                new Employee
                {
                    FirstName = "Herbert",
                    LastName = "NoImage",
                },
                new Employee
                {
                    FirstName = "Harry",
                    LastName = "NoImage",
                },
                new Employee
                {
                    FirstName = "Harry",
                    LastName = "NoImage",
                },
                new Employee
                {
                    FirstName = "Harry",
                    LastName = "NoImage",
                },
                new Employee
                {
                    FirstName = "Harry",
                    LastName = "NoImage",
                },
                new Employee
                {
                    FirstName = "Harry",
                    LastName = "NoImage",
                },
                new Employee
                {
                    FirstName = "Harry",
                    LastName = "NoImage",
                },
                new Employee
                {
                    FirstName = "Harry",
                    LastName = "NoImage",
                },
                new Employee
                {
                    FirstName = "Harry",
                    LastName = "NoImage",
                },
                new Employee
                {
                    FirstName = "Harry",
                    LastName = "NoImage",
                },
                new Employee
                {
                    FirstName = "Harry",
                    LastName = "NoImage",
                },
                new Employee
                {
                    FirstName = "Harry",
                    LastName = "NoImage",
                },
                new Employee
                {
                    FirstName = "Harry",
                    LastName = "NoImage",
                },
                new Employee
                {
                    FirstName = "Harry",
                    LastName = "NoImage",
                },
                new Employee
                {
                    FirstName = "Harry",
                    LastName = "NoImage",
                },
                new Employee
                {
                    FirstName = "Harry",
                    LastName = "NoImage",
                },
                new Employee
                {
                    FirstName = "Harry",
                    LastName = "NoImage",
                },
                new Employee
                {
                    FirstName = "Harry",
                    LastName = "NoImage",
                },
                new Employee
                {
                    FirstName = "Harry",
                    LastName = "NoImage",
                },
                new Employee
                {
                    FirstName = "Harry",
                    LastName = "NoImage",
                },
                new Employee
                {
                    FirstName = "Harry",
                    LastName = "NoImage",
                },
                new Employee
                {
                    FirstName = "Harry",
                    LastName = "NoImage",
                },
                new Employee
                {
                    FirstName = "Harry",
                    LastName = "NoImage",
                },
                new Employee
                {
                    FirstName = "Harry",
                    LastName = "NoImage",
                },
                new Employee
                {
                    FirstName = "Harry",
                    LastName = "NoImage",
                },
                new Employee
                {
                    FirstName = "Harry",
                    LastName = "NoImage",
                },
                new Employee
                {
                    FirstName = "Harry",
                    LastName = "NoImage",
                },
                new Employee
                {
                    FirstName = "Harry",
                    LastName = "NoImage",
                },
                new Employee
                {
                    FirstName = "Harry",
                    LastName = "NoImage",
                },
                new Employee
                {
                    FirstName = "Harry",
                    LastName = "NoImage",
                },
                new Employee
                {
                    FirstName = "Harry",
                    LastName = "NoImage",
                },
            },
        };
    }
}
