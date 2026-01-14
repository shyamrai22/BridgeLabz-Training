using System;

namespace BridgeLabzTraining.Scenario_oops.CustomFurnitureMnufacturing
{
    internal class FurnitureUtility : IFurniture
    {
        private Furniture furniture=new Furniture();


        public int MaxProfit(int n)
        {
            int[] length = furniture.getLength();
            int[] price = furniture.getPrice();

            return MaxProfitHelper(n, length, price);
        }

        private int MaxProfitHelper(int n, int[] length, int[] price)
        {
            if (n == 0)
                return 0;

            int maxProfit = 0;

            for (int i = 0; i < length.Length; i++)
            {
                if (length[i] <= n)
                {
                    int currentProfit =
                        price[i] + MaxProfitHelper(n - length[i], length, price);

                    maxProfit = Math.Max(maxProfit, currentProfit);
                }
            }
            return maxProfit;
        }

        public int MaxProfitWithWaste(int n, int wasteAllowed)
        {
            int[] length = furniture.getLength();
            int[] price = furniture.getPrice();

            int bestProfit = 0;

            for (int used = n - wasteAllowed; used <= n; used++)
            {
                bestProfit = Math.Max(
                    bestProfit,
                    MaxProfitHelper(used, length, price)
                );
            }

            return bestProfit;
        }

    }
}
