using System;

namespace VideoGameClub.Entities
{
    public class Tournament
    {
        public int TournamentId { get; set; }
        public string TournamentName { get; set; }
        public DateTime StartDate { get; set; }
        public int MaxCapacity { get; set; }
        public string TournamentFormat { get; set; }
        public string Prizes { get; set; }

        // 0=Scheduled, 1=Ongoing, 2=Finished
        public int Status { get; set; }

        public Tournament()
        {
            // Set default values
            MaxCapacity = 16;
            Status = 0; // 0 = Scheduled
            StartDate = DateTime.Now;
        }

        // Relationship with Game
        public int GameId { get; set; }
        public Game Game { get; set; }

        // Computed property for UI Display (Returns Spanish strings)
        public string StatusText
        {
            get
            {
                switch (Status)
                {
                    case 0: return "Pendiente";    // Scheduled
                    case 1: return "En Curso";     // Ongoing
                    case 2: return "Finalizado";   // Finished
                    default: return "Desconocido"; // Unknown
                }
            }
        }
    }
}