using System;

namespace VideoGameClub.Entities
{
    public class MembershipType
    {
        public int MembershipTypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Cost { get; set; }
        public int DurationMonths { get; set; }

        // Computed property to display Name + Cost in dropdowns
        public string DisplayText
        {
            get
            {
                return $"{Name} (RD$ {Cost:N0})";
            }
        }

        public override string ToString()
        {
            return DisplayText;
        }
    }
}