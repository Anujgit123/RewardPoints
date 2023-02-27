using Microsoft.Extensions.Configuration;
using NUnit.Framework;
using RewardPoints;
using RewardPoints.Model;
using RewardPoints.Repository;
using System.Configuration;

namespace TestProject_RewardPoints
{
    public class RewardPointsTest
    {

        
        [Test]
        public void Get_Reward_Points_monthwise()
        {
            RewardPointsModel rpm = new RewardPointsModel();
            rpm.CustomerID = 1;
            rpm.JanTransaction = 120;
            rpm.JanRewardPoints = 90;
            rpm.FebTransation = 70;
            rpm.FebRewardPoints = 20;
            rpm.MarchTransaction = 250;
            rpm.MarchRewardPoints = 350;
            rpm.TotalTransaction = 440;
            rpm.TotalRewardPoints = 460;
            RewardPointsCalculator rewardpoints = new RewardPointsCalculator();
            SqlHelper.GetSqlConnection = TestSqlHelper.ConnectionString;

            // Actual Result
            var result= rewardpoints.GetRewardPoints(1);

            // Compare Results
            Assert.AreEqual(rpm.CustomerID, result.CustomerID);
            Assert.AreEqual(rpm.JanTransaction, result.JanTransaction);
            Assert.AreEqual(rpm.JanRewardPoints, result.JanRewardPoints);
            Assert.AreEqual(rpm.FebTransation, result.FebTransation);
            Assert.AreEqual(rpm.FebRewardPoints, result.FebRewardPoints);
            Assert.AreEqual(rpm.MarchTransaction, result.MarchTransaction);
            Assert.AreEqual(rpm.MarchRewardPoints, result.MarchRewardPoints);
            Assert.AreEqual(rpm.TotalTransaction, result.TotalTransaction);
            Assert.AreEqual(rpm.TotalRewardPoints, result.TotalRewardPoints);

        }
    }
}