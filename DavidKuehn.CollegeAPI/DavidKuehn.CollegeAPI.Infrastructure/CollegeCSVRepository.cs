using DavidKuehn.CollegeAPI.Core.Interfaces;
using DavidKuehn.CollegeAPI.Core.Models;
using System;

namespace DavidKuehn.CollegeAPI.Infrastructure
{
    public class CollegeCSVRepository : ICollegeRepository
    {
        public College GetCollegeByName(string name)
        {
            //TODO: Awaiting Cassie's answer to the question

            return new College("Adelphi University", 38657, 15527);
        }
    }
}
