using System.ComponentModel.DataAnnotations;

namespace DavidKuehn.CollegeAPI.Infrastructure
{
    public class CollegeEntity
    {
        [Key]
        public string Name { get; private set; }
        public decimal InStateTuition { get; private set; }
        public decimal? OutOfStateTuition { get; private set; }
        public decimal RoomAndBoard { get; private set; }
    }
}
