using System;

namespace DavidKuehn.CollegeAPI.Core.Models
{
    public sealed class College
    {
        public string Name { get; private set; }
        public decimal InStateTuition { get; private set; }
        public decimal? OutOfStateTuition { get; private set; } 
        public decimal RoomAndBoard { get; private set; }

        public College(string name, decimal inStateTuition, decimal roomAndBoard, decimal? outOfStateTuition = null)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException(nameof(name));
            }

            Name = name;
            InStateTuition = inStateTuition;
            RoomAndBoard = roomAndBoard;
            OutOfStateTuition = outOfStateTuition;
        }
    }
}
