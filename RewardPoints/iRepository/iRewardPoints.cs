using RewardPoints.Model;

namespace RewardPoints.iRepository
{
    public interface iRewardPoints
    {
        RewardPointsModel GetRewardPoints(int CustomerID);
        
    }
}
