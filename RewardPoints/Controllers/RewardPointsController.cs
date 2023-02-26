using Microsoft.AspNetCore.Mvc;
using RewardPoints.iRepository;
using RewardPoints.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RewardPoints.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RewardPointsController : ControllerBase
    {
        private readonly IConfiguration configuration;
        private readonly iRewardPoints _irewardpoints;
        public RewardPointsController(iRewardPoints irewardPoints, IConfiguration _configuration)
        {
            configuration = _configuration;
            _irewardpoints = irewardPoints;
            SqlHelper.GetSqlConnection = configuration.GetConnectionString("RewardPointsContext");
        }

        // GET api/<RewardPointsController>/5
        [HttpGet("{id}")]
        public RewardPointsModel Get(int id)
        {
            RewardPointsModel rpm = new RewardPointsModel();
            rpm = _irewardpoints.GetRewardPoints(id);
            return rpm;
        }
        
    }
}
