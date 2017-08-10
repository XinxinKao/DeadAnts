using System;
using System.Linq;

namespace DeadAnts
{
    public class DeadAnt
    {
        public int DeadAntCount(string ants)
        {
            if (string.IsNullOrEmpty(ants))
            {
                return 0;
            }

            var antWithoutLife = ants.Replace("ant", "").Replace(".", "").Replace(" ", "");
            if (antWithoutLife.Trim().Length == 0)
            {
                return 0;
            }

            return Math.Max(antWithoutLife.Count(c => c == 'a'), Math.Max(antWithoutLife.Count(c => c == 'n'), antWithoutLife.Count(c => c == 't')));
        }
    }
}
