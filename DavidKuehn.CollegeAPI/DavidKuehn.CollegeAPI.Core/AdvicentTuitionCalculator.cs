using DavidKuehn.CollegeAPI.Core.Interfaces;
using DavidKuehn.CollegeAPI.Core.Models;
using System;

namespace DavidKuehn.CollegeAPI.Core
{
    public sealed class AdvicentTuitionCalculator : ITuitionCalculator
    {
        public decimal CalculateAnnualCost(College college, bool includeRoomAndBoard)
        {
            if (college == null)
            {
                throw new ArgumentNullException(nameof(college));
            }

            // TODO: Confirm that in-state tuition is always used
            decimal annualCost = college.InStateTuition;

            if (includeRoomAndBoard)
            {
                annualCost += college.RoomAndBoard;
            }

            return annualCost;
        }
    }
}
