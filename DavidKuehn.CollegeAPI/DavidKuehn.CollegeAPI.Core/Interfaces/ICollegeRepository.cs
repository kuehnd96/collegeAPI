using DavidKuehn.CollegeAPI.Core.Models;

namespace DavidKuehn.CollegeAPI.Core.Interfaces
{
    public interface ICollegeRepository
    {
        College GetCollegeByName(string name);
    }
}
