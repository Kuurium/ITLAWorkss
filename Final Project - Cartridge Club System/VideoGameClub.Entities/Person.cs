using System;

namespace VideoGameClub.Entities
{
    //Base class for specific person types (e.g., Member).
    // Cannot be instantiated directly.
    public abstract class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }

        // Computed property (Read-only)
        public string FullName
        {
            get { return $"{FirstName} {LastName}"; }
        }
    }
}