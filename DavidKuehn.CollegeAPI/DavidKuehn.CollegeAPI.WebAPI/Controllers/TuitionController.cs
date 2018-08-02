using DavidKuehn.CollegeAPI.Core.Interfaces;
using System.Threading.Tasks;
using System.Web.Http;

namespace DavidKuehn.CollegeAPI.WebAPI.Controllers
{
    public class TuitionController : ApiController
    {
        ITuitionCalculator _tuitionCalculator;
        ICollegeRepository _collegeRepo;

        public TuitionController(ITuitionCalculator tuitionCalculator, ICollegeRepository collegeRepo)
        {
            _tuitionCalculator = tuitionCalculator;
            _collegeRepo = collegeRepo;
        }

        public TuitionController()
        {
        }

        [HttpGet]
        public async Task<IHttpActionResult> Get(string collegeName, bool includeRoomAndBoard = true)
        {
            if (string.IsNullOrEmpty(collegeName))
            {
                BadRequest("Error: College name is required");
            }

            var college = await _collegeRepo.GetCollegeByName(collegeName);

            if (college == null)
            {
                // NOTE: I would normally use NotFound() but the requirments state an error message must be returned
                return BadRequest("Error: College not found");
            }

            decimal annualCollegeCost = _tuitionCalculator.CalculateAnnualCost(college, includeRoomAndBoard);

            return Ok(annualCollegeCost);
        }

    }
}
