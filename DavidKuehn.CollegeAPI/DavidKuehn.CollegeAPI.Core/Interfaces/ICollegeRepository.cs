using DavidKuehn.CollegeAPI.Core.Models;
using System.Threading.Tasks;

namespace DavidKuehn.CollegeAPI.Core.Interfaces
{
    public interface ICollegeRepository
    {
        Task<College> GetCollegeByName(string name);
    }
}
