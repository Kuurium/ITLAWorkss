using System;

namespace VideoGameClub.Entities
{
    // Inherits common properties (FirstName, LastName, etc.) from Person
    public class Member : Person
    {
        public int MembershipTypeId { get; set; } // Foreign Key
        public DateTime JoinDate { get; set; }

        // Nullable (?) because a new member might not have a renewal date yet
        public DateTime? RenewalDate { get; set; }

        public int Status { get; set; }
        public string SkillLevel { get; set; }
        public string ClubRole { get; set; }

        // Navigation Property: Allows access to MembershipType details (e.g., Name, Cost)
        public MembershipType MembershipType { get; set; }
    }
}