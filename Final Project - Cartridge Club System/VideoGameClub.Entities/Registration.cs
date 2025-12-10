using System;

namespace VideoGameClub.Entities
{
    public class Registration
    {
        public int RegistrationId { get; set; }
        public DateTime RegistrationDate { get; set; }
        public int Rank { get; set; }
        public int Score { get; set; }

        // Relationships (Foreign Keys & Navigation Properties)
        public int TournamentId { get; set; }
        public Tournament Tournament { get; set; }

        public int MemberId { get; set; }
        public Member Member { get; set; }
    }
}