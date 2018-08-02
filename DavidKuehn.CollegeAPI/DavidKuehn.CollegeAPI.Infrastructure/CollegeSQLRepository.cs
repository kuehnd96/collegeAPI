using DavidKuehn.CollegeAPI.Core.Interfaces;
using DavidKuehn.CollegeAPI.Core.Models;
using System;
using System.Threading.Tasks;

namespace DavidKuehn.CollegeAPI.Infrastructure
{
    public class CollegeSQLRepository : ICollegeRepository
    {
        public async Task<College> GetCollegeByName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException(nameof(name));
            }

            using (var collegeContext = new CollegeContext())
            {
                var collegeEntity =  await collegeContext.Colleges.FindAsync(name);

                if (collegeEntity != null)
                {
                    return new College(collegeEntity.Name, collegeEntity.InStateTuition, 
                        collegeEntity.RoomAndBoard, collegeEntity.OutOfStateTuition);
                }
            }

            return null;
        }
    }
}
