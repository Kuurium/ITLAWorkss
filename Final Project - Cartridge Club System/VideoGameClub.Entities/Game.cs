using System;

namespace VideoGameClub.Entities
{
    public class Game
    {
        public int GameId { get; set; }

        public string Title { get; set; }
        public string Genre { get; set; }
        public string Platform { get; set; }
        public string Version { get; set; }

        public int MinPlayers { get; set; }
        public int MaxPlayers { get; set; }

        public string DefaultTournamentMode { get; set; }
        public int MatchDurationMinutes { get; set; }
        public string SpecificRules { get; set; }

        public string DistributionType { get; set; }
        public string RequiredEquipment { get; set; }
        public string SoftwareRequirements { get; set; }

        public override string ToString()
        {
            return Title;
        }
    }
}