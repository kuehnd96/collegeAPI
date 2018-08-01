using DavidKuehn.CollegeAPI.Core.Models;

namespace DavidKuehn.CollegeAPI.Core.Interfaces
{
    public interface ITuitionCalculator
    {
        decimal CalculateAnnualCost(College college, bool includeRoomAndBoard);
    }
}
