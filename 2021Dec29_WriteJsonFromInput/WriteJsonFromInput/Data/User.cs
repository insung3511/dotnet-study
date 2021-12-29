using System;
using System.ComponentModel.DataAnnotations;

namespace WriteJsonFromInput.Data
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }

        [EmailAddress]
        public string Email { get; set; }
    }
}
