using System;

namespace VideoGameClub.Entities
{
    public class Achievement
    {
        public int AchievementId { get; set; }
        public string Title { get; set; }
        public DateTime DateEarned { get; set; }
        public string Description { get; set; }
        public int MemberId { get; set; }
        public Member Member { get; set; }
    }
}