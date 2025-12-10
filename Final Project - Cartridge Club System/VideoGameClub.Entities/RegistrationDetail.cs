using System;

namespace VideoGameClub.Entities
{
    public class RegistrationDetail
    {
        public int RegistrationId { get; set; }

        public string TournamentName { get; set; }
        public string MemberName { get; set; }
        public string GameTitle { get; set; }
        public DateTime Date { get; set; }
    }
}