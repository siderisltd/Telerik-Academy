using System;
using System.Globalization;
using System.Threading;

class Program
{
    static void Main()
    {
         Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;


          int tommatoSeedAmount = int.Parse(Console.ReadLine());
          int tommatoArea = int.Parse(Console.ReadLine());
          int cucumberSeedsAmount = int.Parse(Console.ReadLine());
          int cucumberArea = int.Parse(Console.ReadLine());
          int potatoSeedsAmount = int.Parse(Console.ReadLine());
          int potatoArea = int.Parse(Console.ReadLine());
          int carrotSeedAmount = int.Parse(Console.ReadLine());
          int carrotArea = int.Parse(Console.ReadLine());
          int cabbageSeedAmount = int.Parse(Console.ReadLine());
          int cabbageArea= int.Parse(Console.ReadLine());
          int beenSeedsAmount = int.Parse(Console.ReadLine());

          int peshoGarden = 250;

          float tomatoSeedCost = 0.5f;
          float cucumberSeedCost = 0.4f;
          float potatoSeedCost = 0.25f;
          float carrotSeedCost = 0.6f;
          float cabbageSeedCost = 0.3f;
          float beenSeedCost = 0.4f;

          float costResult = tommatoSeedAmount * tomatoSeedCost + cucumberSeedCost * cucumberSeedsAmount + potatoSeedsAmount * potatoSeedCost +
              carrotSeedAmount * carrotSeedCost + cabbageSeedAmount * cabbageSeedCost + beenSeedsAmount * beenSeedCost;

          int areaLeft = peshoGarden - (tommatoArea + cucumberArea + potatoArea + carrotArea + cabbageArea);
          if (areaLeft < 0)
          {
              Console.WriteLine("Total costs: {0:0.00}", costResult);
              Console.WriteLine("Insufficient area");
          }

          if (areaLeft == 0)
          {
              Console.WriteLine("Total costs: {0:0.00}",costResult);
              Console.WriteLine("No area for beans");
          }

          if (areaLeft > 0)
          {
              Console.WriteLine("Total costs: {0:0.00}",costResult);
              Console.WriteLine("Beans area: {0}",areaLeft);
          }

    }
}