using Microsoft.Data.SqlClient;
using RewardPoints.iRepository;
using RewardPoints.Model;
using System.Configuration;
using System.Data;

namespace RewardPoints.Repository
{
    public class RewardPointsCalculator : iRewardPoints
    {
        public RewardPointsModel GetRewardPoints(int CustomerID)
        {
            RewardPointsModel rpm = new RewardPointsModel();
            using (SqlConnection con = new SqlConnection(SqlHelper.GetSqlConnection))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "spGetRewardPoints";
                cmd.Parameters.AddWithValue("@CustomerID", CustomerID);
                cmd.Connection = con;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // Calculating Reward Points
                // January Reward Points
                int JanTransaction = Convert.ToInt32(dt.Rows[0]["Transaction"]); ;
                int JanRewardPoints = 0;
                if (JanTransaction > 50 & JanTransaction <= 100)
                {
                    JanRewardPoints = (JanTransaction - 50) * 1;
                }
                else if(JanTransaction > 100)
                {
                    JanRewardPoints = ((JanTransaction - 50) * 1) + ((JanTransaction - 100) * 1);
                }
                

                // February Reward Points
                int FebTransaction = Convert.ToInt32(dt.Rows[1]["Transaction"]);
                int FebRewardPoints = 0;
                if (FebTransaction > 50 & FebTransaction <= 100)
                {
                    FebRewardPoints = (FebTransaction - 50) * 1;
                }
                else if (FebTransaction > 100)
                {
                    FebRewardPoints = ((FebTransaction - 50) * 1) + ((FebTransaction - 100) * 1);
                }

                // March Reward Points
                int MarchTransaction = Convert.ToInt32(dt.Rows[2]["Transaction"]);
                int MarchRewardPoints = 0;
                if (MarchTransaction > 50 & MarchTransaction <= 100)
                {
                    MarchRewardPoints = (MarchTransaction - 50) * 1;
                }
                else if (MarchTransaction > 100)
                {
                    MarchRewardPoints = ((MarchTransaction - 50) * 1) + ((MarchTransaction - 100) * 1);
                }

                // Total Reward Points
                int TotalTransaction = JanTransaction + FebTransaction + MarchTransaction;
                int TotalRewardPoints = JanRewardPoints + FebRewardPoints + MarchRewardPoints;

                // Setting the model
                if (dt.Rows.Count > 0)
                {
                    rpm.CustomerID =Convert.ToInt32(dt.Rows[0]["CustomerID"]);
                    rpm.JanTransaction = JanTransaction;
                    rpm.JanRewardPoints = JanRewardPoints;
                    rpm.FebTransation = FebTransaction;
                    rpm.FebRewardPoints = FebRewardPoints;
                    rpm.MarchTransaction = MarchTransaction;
                    rpm.MarchRewardPoints = MarchRewardPoints;
                    rpm.TotalTransaction = TotalTransaction;
                    rpm.TotalRewardPoints = TotalRewardPoints;
                }
                
                
            }
            return rpm;
        }
    }
}
